// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Orbital
{
    public partial class AvailableGroundStationResource : IJsonModel<AvailableGroundStationData>
    {
        void IJsonModel<AvailableGroundStationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<AvailableGroundStationData>)Data).Write(writer, options);

        AvailableGroundStationData IJsonModel<AvailableGroundStationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<AvailableGroundStationData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<AvailableGroundStationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<AvailableGroundStationData>(Data, options, AzureResourceManagerOrbitalContext.Default);

        AvailableGroundStationData IPersistableModel<AvailableGroundStationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<AvailableGroundStationData>(data, options, AzureResourceManagerOrbitalContext.Default);

        string IPersistableModel<AvailableGroundStationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<AvailableGroundStationData>)Data).GetFormatFromOptions(options);
    }
}
