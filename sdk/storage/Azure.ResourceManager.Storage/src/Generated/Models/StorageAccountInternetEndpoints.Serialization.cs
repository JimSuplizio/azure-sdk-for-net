// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageAccountInternetEndpoints : IUtf8JsonSerializable, IJsonModel<StorageAccountInternetEndpoints>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageAccountInternetEndpoints>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StorageAccountInternetEndpoints>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountInternetEndpoints>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageAccountInternetEndpoints)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(BlobUri))
            {
                writer.WritePropertyName("blob"u8);
                writer.WriteStringValue(BlobUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(FileUri))
            {
                writer.WritePropertyName("file"u8);
                writer.WriteStringValue(FileUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(WebUri))
            {
                writer.WritePropertyName("web"u8);
                writer.WriteStringValue(WebUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(DfsUri))
            {
                writer.WritePropertyName("dfs"u8);
                writer.WriteStringValue(DfsUri.AbsoluteUri);
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

        StorageAccountInternetEndpoints IJsonModel<StorageAccountInternetEndpoints>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountInternetEndpoints>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageAccountInternetEndpoints)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageAccountInternetEndpoints(document.RootElement, options);
        }

        internal static StorageAccountInternetEndpoints DeserializeStorageAccountInternetEndpoints(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri blob = default;
            Uri file = default;
            Uri web = default;
            Uri dfs = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blob"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blob = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("file"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    file = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("web"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    web = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dfs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dfs = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StorageAccountInternetEndpoints(blob, file, web, dfs, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BlobUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  blob: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(BlobUri))
                {
                    builder.Append("  blob: ");
                    builder.AppendLine($"'{BlobUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(FileUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  file: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(FileUri))
                {
                    builder.Append("  file: ");
                    builder.AppendLine($"'{FileUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(WebUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  web: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(WebUri))
                {
                    builder.Append("  web: ");
                    builder.AppendLine($"'{WebUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DfsUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  dfs: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DfsUri))
                {
                    builder.Append("  dfs: ");
                    builder.AppendLine($"'{DfsUri.AbsoluteUri}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<StorageAccountInternetEndpoints>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountInternetEndpoints>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerStorageContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(StorageAccountInternetEndpoints)} does not support writing '{options.Format}' format.");
            }
        }

        StorageAccountInternetEndpoints IPersistableModel<StorageAccountInternetEndpoints>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountInternetEndpoints>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeStorageAccountInternetEndpoints(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageAccountInternetEndpoints)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageAccountInternetEndpoints>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
