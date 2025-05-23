// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class GatewayListDebugCredentialsContract : IUtf8JsonSerializable, IJsonModel<GatewayListDebugCredentialsContract>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GatewayListDebugCredentialsContract>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<GatewayListDebugCredentialsContract>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GatewayListDebugCredentialsContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GatewayListDebugCredentialsContract)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(CredentialsExpireAfter))
            {
                writer.WritePropertyName("credentialsExpireAfter"u8);
                writer.WriteStringValue(CredentialsExpireAfter.Value, "P");
            }
            writer.WritePropertyName("purposes"u8);
            writer.WriteStartArray();
            foreach (var item in Purposes)
            {
                writer.WriteStringValue(item.ToString());
            }
            writer.WriteEndArray();
            writer.WritePropertyName("apiId"u8);
            writer.WriteStringValue(ApiId);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        GatewayListDebugCredentialsContract IJsonModel<GatewayListDebugCredentialsContract>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GatewayListDebugCredentialsContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GatewayListDebugCredentialsContract)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGatewayListDebugCredentialsContract(document.RootElement, options);
        }

        internal static GatewayListDebugCredentialsContract DeserializeGatewayListDebugCredentialsContract(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TimeSpan? credentialsExpireAfter = default;
            IList<GatewayListDebugCredentialsContractPurpose> purposes = default;
            ResourceIdentifier apiId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("credentialsExpireAfter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    credentialsExpireAfter = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("purposes"u8))
                {
                    List<GatewayListDebugCredentialsContractPurpose> array = new List<GatewayListDebugCredentialsContractPurpose>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new GatewayListDebugCredentialsContractPurpose(item.GetString()));
                    }
                    purposes = array;
                    continue;
                }
                if (property.NameEquals("apiId"u8))
                {
                    apiId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new GatewayListDebugCredentialsContract(credentialsExpireAfter, purposes, apiId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GatewayListDebugCredentialsContract>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GatewayListDebugCredentialsContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerApiManagementContext.Default);
                default:
                    throw new FormatException($"The model {nameof(GatewayListDebugCredentialsContract)} does not support writing '{options.Format}' format.");
            }
        }

        GatewayListDebugCredentialsContract IPersistableModel<GatewayListDebugCredentialsContract>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GatewayListDebugCredentialsContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeGatewayListDebugCredentialsContract(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GatewayListDebugCredentialsContract)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<GatewayListDebugCredentialsContract>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
