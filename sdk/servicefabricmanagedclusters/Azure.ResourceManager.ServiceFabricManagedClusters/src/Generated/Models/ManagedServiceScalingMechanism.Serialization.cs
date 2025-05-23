// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    [PersistableModelProxy(typeof(UnknownScalingMechanism))]
    public partial class ManagedServiceScalingMechanism : IUtf8JsonSerializable, IJsonModel<ManagedServiceScalingMechanism>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedServiceScalingMechanism>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedServiceScalingMechanism>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServiceScalingMechanism>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedServiceScalingMechanism)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        ManagedServiceScalingMechanism IJsonModel<ManagedServiceScalingMechanism>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServiceScalingMechanism>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedServiceScalingMechanism)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedServiceScalingMechanism(document.RootElement, options);
        }

        internal static ManagedServiceScalingMechanism DeserializeManagedServiceScalingMechanism(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AddRemoveIncrementalNamedPartition": return NamedPartitionAddOrRemoveScalingMechanism.DeserializeNamedPartitionAddOrRemoveScalingMechanism(element, options);
                    case "ScalePartitionInstanceCount": return PartitionInstanceCountScalingMechanism.DeserializePartitionInstanceCountScalingMechanism(element, options);
                }
            }
            return UnknownScalingMechanism.DeserializeUnknownScalingMechanism(element, options);
        }

        BinaryData IPersistableModel<ManagedServiceScalingMechanism>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServiceScalingMechanism>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerServiceFabricManagedClustersContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ManagedServiceScalingMechanism)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedServiceScalingMechanism IPersistableModel<ManagedServiceScalingMechanism>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServiceScalingMechanism>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeManagedServiceScalingMechanism(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedServiceScalingMechanism)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedServiceScalingMechanism>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
