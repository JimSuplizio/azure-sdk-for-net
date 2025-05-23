// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class WeeklyRetentionFormat : IUtf8JsonSerializable, IJsonModel<WeeklyRetentionFormat>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WeeklyRetentionFormat>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<WeeklyRetentionFormat>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WeeklyRetentionFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WeeklyRetentionFormat)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(DaysOfTheWeek))
            {
                writer.WritePropertyName("daysOfTheWeek"u8);
                writer.WriteStartArray();
                foreach (var item in DaysOfTheWeek)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(WeeksOfTheMonth))
            {
                writer.WritePropertyName("weeksOfTheMonth"u8);
                writer.WriteStartArray();
                foreach (var item in WeeksOfTheMonth)
                {
                    writer.WriteStringValue(item.ToSerialString());
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

        WeeklyRetentionFormat IJsonModel<WeeklyRetentionFormat>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WeeklyRetentionFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WeeklyRetentionFormat)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWeeklyRetentionFormat(document.RootElement, options);
        }

        internal static WeeklyRetentionFormat DeserializeWeeklyRetentionFormat(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<BackupDayOfWeek> daysOfTheWeek = default;
            IList<BackupWeekOfMonth> weeksOfTheMonth = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("daysOfTheWeek"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BackupDayOfWeek> array = new List<BackupDayOfWeek>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToBackupDayOfWeek());
                    }
                    daysOfTheWeek = array;
                    continue;
                }
                if (property.NameEquals("weeksOfTheMonth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BackupWeekOfMonth> array = new List<BackupWeekOfMonth>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToBackupWeekOfMonth());
                    }
                    weeksOfTheMonth = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new WeeklyRetentionFormat(daysOfTheWeek ?? new ChangeTrackingList<BackupDayOfWeek>(), weeksOfTheMonth ?? new ChangeTrackingList<BackupWeekOfMonth>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WeeklyRetentionFormat>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WeeklyRetentionFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerRecoveryServicesBackupContext.Default);
                default:
                    throw new FormatException($"The model {nameof(WeeklyRetentionFormat)} does not support writing '{options.Format}' format.");
            }
        }

        WeeklyRetentionFormat IPersistableModel<WeeklyRetentionFormat>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WeeklyRetentionFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeWeeklyRetentionFormat(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WeeklyRetentionFormat)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WeeklyRetentionFormat>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
