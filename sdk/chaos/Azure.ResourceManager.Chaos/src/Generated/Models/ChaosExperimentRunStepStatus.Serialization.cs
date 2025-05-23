// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Chaos.Models
{
    public partial class ChaosExperimentRunStepStatus : IUtf8JsonSerializable, IJsonModel<ChaosExperimentRunStepStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ChaosExperimentRunStepStatus>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ChaosExperimentRunStepStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosExperimentRunStepStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChaosExperimentRunStepStatus)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(StepName))
            {
                writer.WritePropertyName("stepName"u8);
                writer.WriteStringValue(StepName);
            }
            if (options.Format != "W" && Optional.IsDefined(StepId))
            {
                writer.WritePropertyName("stepId"u8);
                writer.WriteStringValue(StepId);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Branches))
            {
                writer.WritePropertyName("branches"u8);
                writer.WriteStartArray();
                foreach (var item in Branches)
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

        ChaosExperimentRunStepStatus IJsonModel<ChaosExperimentRunStepStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosExperimentRunStepStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChaosExperimentRunStepStatus)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChaosExperimentRunStepStatus(document.RootElement, options);
        }

        internal static ChaosExperimentRunStepStatus DeserializeChaosExperimentRunStepStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string stepName = default;
            string stepId = default;
            string status = default;
            IReadOnlyList<ChaosExperimentRunBranchStatus> branches = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stepName"u8))
                {
                    stepName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stepId"u8))
                {
                    stepId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("branches"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ChaosExperimentRunBranchStatus> array = new List<ChaosExperimentRunBranchStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ChaosExperimentRunBranchStatus.DeserializeChaosExperimentRunBranchStatus(item, options));
                    }
                    branches = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ChaosExperimentRunStepStatus(stepName, stepId, status, branches ?? new ChangeTrackingList<ChaosExperimentRunBranchStatus>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ChaosExperimentRunStepStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosExperimentRunStepStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerChaosContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ChaosExperimentRunStepStatus)} does not support writing '{options.Format}' format.");
            }
        }

        ChaosExperimentRunStepStatus IPersistableModel<ChaosExperimentRunStepStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosExperimentRunStepStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeChaosExperimentRunStepStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChaosExperimentRunStepStatus)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChaosExperimentRunStepStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
