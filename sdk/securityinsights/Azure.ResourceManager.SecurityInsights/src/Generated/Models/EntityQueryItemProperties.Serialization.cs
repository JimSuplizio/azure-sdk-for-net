// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class EntityQueryItemProperties : IUtf8JsonSerializable, IJsonModel<EntityQueryItemProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EntityQueryItemProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EntityQueryItemProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EntityQueryItemProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EntityQueryItemProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(DataTypes))
            {
                writer.WritePropertyName("dataTypes"u8);
                writer.WriteStartArray();
                foreach (var item in DataTypes)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(InputEntityType))
            {
                writer.WritePropertyName("inputEntityType"u8);
                writer.WriteStringValue(InputEntityType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(RequiredInputFieldsSets))
            {
                writer.WritePropertyName("requiredInputFieldsSets"u8);
                writer.WriteStartArray();
                foreach (var item in RequiredInputFieldsSets)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartArray();
                    foreach (var item0 in item)
                    {
                        writer.WriteStringValue(item0);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EntitiesFilter))
            {
                writer.WritePropertyName("entitiesFilter"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(EntitiesFilter);
#else
                using (JsonDocument document = JsonDocument.Parse(EntitiesFilter, ModelSerializationExtensions.JsonDocumentOptions))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        EntityQueryItemProperties IJsonModel<EntityQueryItemProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EntityQueryItemProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EntityQueryItemProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEntityQueryItemProperties(document.RootElement, options);
        }

        internal static EntityQueryItemProperties DeserializeEntityQueryItemProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<EntityQueryItemPropertiesDataTypesItem> dataTypes = default;
            SecurityInsightsEntityType? inputEntityType = default;
            IReadOnlyList<IList<string>> requiredInputFieldsSets = default;
            BinaryData entitiesFilter = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EntityQueryItemPropertiesDataTypesItem> array = new List<EntityQueryItemPropertiesDataTypesItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EntityQueryItemPropertiesDataTypesItem.DeserializeEntityQueryItemPropertiesDataTypesItem(item, options));
                    }
                    dataTypes = array;
                    continue;
                }
                if (property.NameEquals("inputEntityType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    inputEntityType = new SecurityInsightsEntityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("requiredInputFieldsSets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IList<string>> array = new List<IList<string>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            List<string> array0 = new List<string>();
                            foreach (var item0 in item.EnumerateArray())
                            {
                                array0.Add(item0.GetString());
                            }
                            array.Add(array0);
                        }
                    }
                    requiredInputFieldsSets = array;
                    continue;
                }
                if (property.NameEquals("entitiesFilter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    entitiesFilter = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EntityQueryItemProperties(dataTypes ?? new ChangeTrackingList<EntityQueryItemPropertiesDataTypesItem>(), inputEntityType, requiredInputFieldsSets ?? new ChangeTrackingList<IList<string>>(), entitiesFilter, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DataTypes), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  dataTypes: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(DataTypes))
                {
                    if (DataTypes.Any())
                    {
                        builder.Append("  dataTypes: ");
                        builder.AppendLine("[");
                        foreach (var item in DataTypes)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  dataTypes: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(InputEntityType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  inputEntityType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(InputEntityType))
                {
                    builder.Append("  inputEntityType: ");
                    builder.AppendLine($"'{InputEntityType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RequiredInputFieldsSets), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  requiredInputFieldsSets: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(RequiredInputFieldsSets))
                {
                    if (RequiredInputFieldsSets.Any())
                    {
                        builder.Append("  requiredInputFieldsSets: ");
                        builder.AppendLine("[");
                        foreach (var item in RequiredInputFieldsSets)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            builder.AppendLine("[");
                            foreach (var item0 in item)
                            {
                                if (item0 == null)
                                {
                                    builder.Append("null");
                                    continue;
                                }
                                if (item0.Contains(Environment.NewLine))
                                {
                                    builder.AppendLine("    '''");
                                    builder.AppendLine($"{item0}'''");
                                }
                                else
                                {
                                    builder.AppendLine($"    '{item0}'");
                                }
                            }
                            builder.AppendLine("  ]");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EntitiesFilter), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  entitiesFilter: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EntitiesFilter))
                {
                    builder.Append("  entitiesFilter: ");
                    builder.AppendLine($"'{EntitiesFilter.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<EntityQueryItemProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EntityQueryItemProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerSecurityInsightsContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(EntityQueryItemProperties)} does not support writing '{options.Format}' format.");
            }
        }

        EntityQueryItemProperties IPersistableModel<EntityQueryItemProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EntityQueryItemProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeEntityQueryItemProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EntityQueryItemProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EntityQueryItemProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
