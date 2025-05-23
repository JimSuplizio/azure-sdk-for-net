// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class ProtectionContainerMappingProperties : IUtf8JsonSerializable, IJsonModel<ProtectionContainerMappingProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProtectionContainerMappingProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ProtectionContainerMappingProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProtectionContainerMappingProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProtectionContainerMappingProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(TargetProtectionContainerId))
            {
                writer.WritePropertyName("targetProtectionContainerId"u8);
                writer.WriteStringValue(TargetProtectionContainerId);
            }
            if (Optional.IsDefined(TargetProtectionContainerFriendlyName))
            {
                writer.WritePropertyName("targetProtectionContainerFriendlyName"u8);
                writer.WriteStringValue(TargetProtectionContainerFriendlyName);
            }
            if (Optional.IsDefined(ProviderSpecificDetails))
            {
                writer.WritePropertyName("providerSpecificDetails"u8);
                writer.WriteObjectValue(ProviderSpecificDetails, options);
            }
            if (Optional.IsDefined(Health))
            {
                writer.WritePropertyName("health"u8);
                writer.WriteStringValue(Health);
            }
            if (Optional.IsCollectionDefined(HealthErrorDetails))
            {
                writer.WritePropertyName("healthErrorDetails"u8);
                writer.WriteStartArray();
                foreach (var item in HealthErrorDetails)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PolicyId))
            {
                writer.WritePropertyName("policyId"u8);
                writer.WriteStringValue(PolicyId);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
            }
            if (Optional.IsDefined(SourceProtectionContainerFriendlyName))
            {
                writer.WritePropertyName("sourceProtectionContainerFriendlyName"u8);
                writer.WriteStringValue(SourceProtectionContainerFriendlyName);
            }
            if (Optional.IsDefined(SourceFabricFriendlyName))
            {
                writer.WritePropertyName("sourceFabricFriendlyName"u8);
                writer.WriteStringValue(SourceFabricFriendlyName);
            }
            if (Optional.IsDefined(TargetFabricFriendlyName))
            {
                writer.WritePropertyName("targetFabricFriendlyName"u8);
                writer.WriteStringValue(TargetFabricFriendlyName);
            }
            if (Optional.IsDefined(PolicyFriendlyName))
            {
                writer.WritePropertyName("policyFriendlyName"u8);
                writer.WriteStringValue(PolicyFriendlyName);
            }
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

        ProtectionContainerMappingProperties IJsonModel<ProtectionContainerMappingProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProtectionContainerMappingProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProtectionContainerMappingProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProtectionContainerMappingProperties(document.RootElement, options);
        }

        internal static ProtectionContainerMappingProperties DeserializeProtectionContainerMappingProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier targetProtectionContainerId = default;
            string targetProtectionContainerFriendlyName = default;
            ProtectionContainerMappingProviderSpecificDetails providerSpecificDetails = default;
            string health = default;
            IReadOnlyList<SiteRecoveryHealthError> healthErrorDetails = default;
            ResourceIdentifier policyId = default;
            string state = default;
            string sourceProtectionContainerFriendlyName = default;
            string sourceFabricFriendlyName = default;
            string targetFabricFriendlyName = default;
            string policyFriendlyName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetProtectionContainerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetProtectionContainerId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetProtectionContainerFriendlyName"u8))
                {
                    targetProtectionContainerFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerSpecificDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerSpecificDetails = ProtectionContainerMappingProviderSpecificDetails.DeserializeProtectionContainerMappingProviderSpecificDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("health"u8))
                {
                    health = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthErrorDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryHealthError> array = new List<SiteRecoveryHealthError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryHealthError.DeserializeSiteRecoveryHealthError(item, options));
                    }
                    healthErrorDetails = array;
                    continue;
                }
                if (property.NameEquals("policyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceProtectionContainerFriendlyName"u8))
                {
                    sourceProtectionContainerFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceFabricFriendlyName"u8))
                {
                    sourceFabricFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetFabricFriendlyName"u8))
                {
                    targetFabricFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyFriendlyName"u8))
                {
                    policyFriendlyName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ProtectionContainerMappingProperties(
                targetProtectionContainerId,
                targetProtectionContainerFriendlyName,
                providerSpecificDetails,
                health,
                healthErrorDetails ?? new ChangeTrackingList<SiteRecoveryHealthError>(),
                policyId,
                state,
                sourceProtectionContainerFriendlyName,
                sourceFabricFriendlyName,
                targetFabricFriendlyName,
                policyFriendlyName,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProtectionContainerMappingProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProtectionContainerMappingProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerRecoveryServicesSiteRecoveryContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ProtectionContainerMappingProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ProtectionContainerMappingProperties IPersistableModel<ProtectionContainerMappingProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProtectionContainerMappingProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeProtectionContainerMappingProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProtectionContainerMappingProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProtectionContainerMappingProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
