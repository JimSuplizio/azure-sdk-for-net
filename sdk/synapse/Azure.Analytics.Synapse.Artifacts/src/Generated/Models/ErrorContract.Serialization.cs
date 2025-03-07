// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(ErrorContractConverter))]
    internal partial class ErrorContract
    {
        internal static ErrorContract DeserializeErrorContract(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ErrorResponse error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = ErrorResponse.DeserializeErrorResponse(property.Value);
                    continue;
                }
            }
            return new ErrorContract(error);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ErrorContract FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeErrorContract(document.RootElement);
        }

        internal partial class ErrorContractConverter : JsonConverter<ErrorContract>
        {
            public override void Write(Utf8JsonWriter writer, ErrorContract model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override ErrorContract Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeErrorContract(document.RootElement);
            }
        }
    }
}
