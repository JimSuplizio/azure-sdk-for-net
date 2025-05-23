// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Quantum.Models
{
    public partial class QuantumProviderProperties : IUtf8JsonSerializable, IJsonModel<QuantumProviderProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<QuantumProviderProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<QuantumProviderProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuantumProviderProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QuantumProviderProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(ProviderType))
            {
                writer.WritePropertyName("providerType"u8);
                writer.WriteStringValue(ProviderType);
            }
            if (options.Format != "W" && Optional.IsDefined(Company))
            {
                writer.WritePropertyName("company"u8);
                writer.WriteStringValue(Company);
            }
            if (options.Format != "W" && Optional.IsDefined(DefaultEndpoint))
            {
                writer.WritePropertyName("defaultEndpoint"u8);
                writer.WriteStringValue(DefaultEndpoint);
            }
            if (Optional.IsDefined(Aad))
            {
                writer.WritePropertyName("aad"u8);
                writer.WriteObjectValue(Aad, options);
            }
            if (Optional.IsDefined(ManagedApplication))
            {
                writer.WritePropertyName("managedApplication"u8);
                writer.WriteObjectValue(ManagedApplication, options);
            }
            if (Optional.IsCollectionDefined(Targets))
            {
                writer.WritePropertyName("targets"u8);
                writer.WriteStartArray();
                foreach (var item in Targets)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Skus))
            {
                writer.WritePropertyName("skus"u8);
                writer.WriteStartArray();
                foreach (var item in Skus)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(QuotaDimensions))
            {
                writer.WritePropertyName("quotaDimensions"u8);
                writer.WriteStartArray();
                foreach (var item in QuotaDimensions)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PricingDimensions))
            {
                writer.WritePropertyName("pricingDimensions"u8);
                writer.WriteStartArray();
                foreach (var item in PricingDimensions)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        QuantumProviderProperties IJsonModel<QuantumProviderProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuantumProviderProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QuantumProviderProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeQuantumProviderProperties(document.RootElement, options);
        }

        internal static QuantumProviderProperties DeserializeQuantumProviderProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string description = default;
            string providerType = default;
            string company = default;
            string defaultEndpoint = default;
            ProviderAadInfo aad = default;
            ProviderApplicationInfo managedApplication = default;
            IReadOnlyList<ProviderTargetDescription> targets = default;
            IReadOnlyList<ProviderSkuDescription> skus = default;
            IReadOnlyList<QuantumQuotaDimension> quotaDimensions = default;
            IReadOnlyList<ProviderPricingDimension> pricingDimensions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerType"u8))
                {
                    providerType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("company"u8))
                {
                    company = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultEndpoint"u8))
                {
                    defaultEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aad"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aad = ProviderAadInfo.DeserializeProviderAadInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("managedApplication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managedApplication = ProviderApplicationInfo.DeserializeProviderApplicationInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("targets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ProviderTargetDescription> array = new List<ProviderTargetDescription>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProviderTargetDescription.DeserializeProviderTargetDescription(item, options));
                    }
                    targets = array;
                    continue;
                }
                if (property.NameEquals("skus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ProviderSkuDescription> array = new List<ProviderSkuDescription>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProviderSkuDescription.DeserializeProviderSkuDescription(item, options));
                    }
                    skus = array;
                    continue;
                }
                if (property.NameEquals("quotaDimensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<QuantumQuotaDimension> array = new List<QuantumQuotaDimension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QuantumQuotaDimension.DeserializeQuantumQuotaDimension(item, options));
                    }
                    quotaDimensions = array;
                    continue;
                }
                if (property.NameEquals("pricingDimensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ProviderPricingDimension> array = new List<ProviderPricingDimension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProviderPricingDimension.DeserializeProviderPricingDimension(item, options));
                    }
                    pricingDimensions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new QuantumProviderProperties(
                description,
                providerType,
                company,
                defaultEndpoint,
                aad,
                managedApplication,
                targets ?? new ChangeTrackingList<ProviderTargetDescription>(),
                skus ?? new ChangeTrackingList<ProviderSkuDescription>(),
                quotaDimensions ?? new ChangeTrackingList<QuantumQuotaDimension>(),
                pricingDimensions ?? new ChangeTrackingList<ProviderPricingDimension>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<QuantumProviderProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuantumProviderProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerQuantumContext.Default);
                default:
                    throw new FormatException($"The model {nameof(QuantumProviderProperties)} does not support writing '{options.Format}' format.");
            }
        }

        QuantumProviderProperties IPersistableModel<QuantumProviderProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuantumProviderProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeQuantumProviderProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(QuantumProviderProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<QuantumProviderProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
