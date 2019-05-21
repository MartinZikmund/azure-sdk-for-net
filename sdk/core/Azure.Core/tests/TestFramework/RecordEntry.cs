﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core.Pipeline;

namespace Azure.Core.Testing
{
    public class RecordEntry
    {
        public string RequestUri { get; set; }

        public HttpPipelineMethod RequestMethod { get; set; }

        public byte[] RequestBody { get; set; }

        public SortedDictionary<string, string[]> RequestHeaders { get; set; } = new SortedDictionary<string, string[]>(StringComparer.InvariantCultureIgnoreCase);

        public SortedDictionary<string, string[]> ResponseHeaders { get; set; } = new SortedDictionary<string, string[]>(StringComparer.InvariantCultureIgnoreCase);

        public byte[] ResponseBody { get; set; }

        public int StatusCode { get; set; }

        public static RecordEntry Deserialize(JsonElement element)
        {
            var record = new RecordEntry();

            if (element.TryGetProperty(nameof(RequestMethod), out JsonElement property))
            {
                record.RequestMethod = HttpPipelineMethodConverter.Parse(property.GetString());
            }

            if (element.TryGetProperty(nameof(RequestUri), out property))
            {
                record.RequestUri = property.GetString();
            }

            if (element.TryGetProperty(nameof(RequestHeaders), out property))
            {
                DeserializeHeaders(record.RequestHeaders, property);
            }

            if (element.TryGetProperty(nameof(RequestBody), out property))
            {
                record.RequestBody = DeserializeBody(record.RequestHeaders, property);
            }

            if (element.TryGetProperty(nameof(StatusCode), out property) &&
                property.TryGetInt32(out var statusCode))
            {
                record.StatusCode = statusCode;
            }

            if (element.TryGetProperty(nameof(ResponseHeaders), out property))
            {
                DeserializeHeaders(record.ResponseHeaders, property);
            }

            if (element.TryGetProperty(nameof(ResponseBody), out property))
            {
                record.ResponseBody = DeserializeBody(record.ResponseHeaders, property);
            }

            return record;
        }

        private static byte[] DeserializeBody(IDictionary<string, string[]> headers, in JsonElement property)
        {
            if (property.Type == JsonValueType.Null)
            {
                return null;
            }

            if (IsTextContentType(headers, out Encoding encoding))
            {
                if (property.Type == JsonValueType.Object)
                {
                    var arrayBufferWriter = new ArrayBufferWriter<byte>();
                    using var writer = new Utf8JsonWriter(arrayBufferWriter);
                    property.WriteAsValue(writer);
                    writer.Flush();
                    return arrayBufferWriter.WrittenMemory.ToArray();
                }
                else if (property.Type == JsonValueType.Array)
                {
                    StringBuilder stringBuilder = new StringBuilder();

                    foreach (var item in property.EnumerateArray())
                    {
                        stringBuilder.Append(item.GetString());
                    }

                    return encoding.GetBytes(stringBuilder.ToString());
                }
                else
                {
                    return encoding.GetBytes(property.GetString());
                }
            }

            return Convert.FromBase64String(property.GetString());
        }

        private static void DeserializeHeaders(IDictionary<string, string[]> headers, in JsonElement property)
        {
            foreach (JsonProperty item in property.EnumerateObject())
            {
                if (item.Value.Type == JsonValueType.Array)
                {
                    var values = new List<string>();
                    foreach (JsonElement headerValue in item.Value.EnumerateArray())
                    {
                        values.Add(headerValue.GetString());
                    }

                    headers[item.Name] = values.ToArray();
                }
                else
                {
                    headers[item.Name] = new[] { item.Value.GetString() };
                }
            }
        }

        public void Serialize(Utf8JsonWriter jsonWriter)
        {
            jsonWriter.WriteStartObject();

            jsonWriter.WriteString(nameof(RequestUri), RequestUri);
            jsonWriter.WriteString(nameof(RequestMethod), HttpPipelineMethodConverter.ToString(RequestMethod));
            jsonWriter.WriteStartObject(nameof(RequestHeaders));
            SerializeHeaders(jsonWriter, RequestHeaders);
            jsonWriter.WriteEndObject();

            SerializeBody(jsonWriter, nameof(RequestBody), RequestBody, RequestHeaders);

            jsonWriter.WriteNumber(nameof(StatusCode), StatusCode);

            jsonWriter.WriteStartObject(nameof(ResponseHeaders));
            SerializeHeaders(jsonWriter, ResponseHeaders);
            jsonWriter.WriteEndObject();

            SerializeBody(jsonWriter, nameof(ResponseBody), ResponseBody, ResponseHeaders);
            jsonWriter.WriteEndObject();
        }

        private void SerializeBody(Utf8JsonWriter jsonWriter, string name, byte[] requestBody, IDictionary<string, string[]> headers)
        {
            if (requestBody == null || requestBody.Length == 0)
            {
                jsonWriter.WriteNull(name);
            }
            else if (IsTextContentType(headers, out Encoding encoding))
            {
                // Try parse response as JSON and write it directly if possible
                try
                {
                    using JsonDocument document = JsonDocument.Parse(requestBody);
                    document.RootElement.WriteAsProperty(name.AsSpan(), jsonWriter);
                    return;
                }
                catch (Exception)
                {
                    // ignore
                }

                ReadOnlySpan<char> text = encoding.GetString(requestBody).AsMemory().Span;

                var indexOfNewline = IndexOfNewline(text);
                if (indexOfNewline == -1)
                {
                    jsonWriter.WriteString(name, text);
                }
                else
                {
                    jsonWriter.WriteStartArray(name);
                    do
                    {
                        jsonWriter.WriteStringValue(text.Slice(0, indexOfNewline + 1));
                        text = text.Slice(indexOfNewline + 1);
                        indexOfNewline = IndexOfNewline(text);
                    } while (indexOfNewline != -1);

                    if (!text.IsEmpty)
                    {
                        jsonWriter.WriteStringValue(text);
                    }

                    jsonWriter.WriteEndArray();
                }
            }
            else
            {
                jsonWriter.WriteString(name, Convert.ToBase64String(requestBody));
            }
        }

        private int IndexOfNewline(ReadOnlySpan<char> span)
        {
            int indexOfNewline = span.IndexOfAny('\r', '\n');

            if (indexOfNewline == -1)
            {
                return -1;
            }

            if (span.Length > indexOfNewline + 1 &&
                (span[indexOfNewline + 1] == '\r' ||
                span[indexOfNewline + 1] == '\n'))
            {
                indexOfNewline++;
            }

            return indexOfNewline;
        }

        private void SerializeHeaders(Utf8JsonWriter jsonWriter, IDictionary<string, string[]> header)
        {
            foreach (var requestHeader in header)
            {
                if (requestHeader.Value.Length == 1)
                {
                    jsonWriter.WriteString(requestHeader.Key, requestHeader.Value[0]);
                }
                else
                {
                    jsonWriter.WriteStartArray(requestHeader.Key);
                    foreach (var value in requestHeader.Value)
                    {
                        jsonWriter.WriteStringValue(value);
                    }

                    jsonWriter.WriteEndArray();
                }
            }
        }

        private static bool IsTextContentType(IDictionary<string, string[]> requestHeaders, out Encoding encoding)
        {
            encoding = null;
            return requestHeaders.TryGetValue("Content-Type", out var contentType) &&
                   contentType.Length == 1 &&
                   ContentTypeUtilities.TryGetTextEncoding(contentType[0], out encoding);
        }

        public void Sanitize(RecordedTestSanitizer sanitizer)
        {
            RequestUri = sanitizer.SanitizeUri(RequestUri);
            if (RequestBody != null)
            {
                if (IsTextContentType(RequestHeaders, out Encoding encoding))
                {
                    RequestBody = Encoding.UTF8.GetBytes(sanitizer.SanitizeTextBody(encoding.GetString(RequestBody)));
                }
                else
                {
                    RequestBody = sanitizer.SanitizeBody(RequestBody);
                }
            }

            sanitizer.SanitizeHeaders(RequestHeaders);

            if (ResponseBody != null)
            {
                if (IsTextContentType(ResponseHeaders, out Encoding encoding))
                {
                    ResponseBody = Encoding.UTF8.GetBytes(sanitizer.SanitizeTextBody(encoding.GetString(ResponseBody)));
                }
                else
                {
                    ResponseBody = sanitizer.SanitizeBody(ResponseBody);
                }
            }

            sanitizer.SanitizeHeaders(ResponseHeaders);
        }
    }
}