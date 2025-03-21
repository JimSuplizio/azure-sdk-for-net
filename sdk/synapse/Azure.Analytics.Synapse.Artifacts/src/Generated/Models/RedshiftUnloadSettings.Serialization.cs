// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(RedshiftUnloadSettingsConverter))]
    public partial class RedshiftUnloadSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("s3LinkedServiceName"u8);
            writer.WriteObjectValue(S3LinkedServiceName);
            writer.WritePropertyName("bucketName"u8);
            writer.WriteObjectValue<object>(BucketName);
            writer.WriteEndObject();
        }

        internal static RedshiftUnloadSettings DeserializeRedshiftUnloadSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LinkedServiceReference s3LinkedServiceName = default;
            object bucketName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("s3LinkedServiceName"u8))
                {
                    s3LinkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("bucketName"u8))
                {
                    bucketName = property.Value.GetObject();
                    continue;
                }
            }
            return new RedshiftUnloadSettings(s3LinkedServiceName, bucketName);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RedshiftUnloadSettings FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeRedshiftUnloadSettings(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class RedshiftUnloadSettingsConverter : JsonConverter<RedshiftUnloadSettings>
        {
            public override void Write(Utf8JsonWriter writer, RedshiftUnloadSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override RedshiftUnloadSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeRedshiftUnloadSettings(document.RootElement);
            }
        }
    }
}
