// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DeviceRegistry
{
    public partial class DeviceRegistryDiscoveredAssetEndpointProfileResource : IJsonModel<DeviceRegistryDiscoveredAssetEndpointProfileData>
    {
        void IJsonModel<DeviceRegistryDiscoveredAssetEndpointProfileData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DeviceRegistryDiscoveredAssetEndpointProfileData>)Data).Write(writer, options);

        DeviceRegistryDiscoveredAssetEndpointProfileData IJsonModel<DeviceRegistryDiscoveredAssetEndpointProfileData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DeviceRegistryDiscoveredAssetEndpointProfileData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<DeviceRegistryDiscoveredAssetEndpointProfileData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        DeviceRegistryDiscoveredAssetEndpointProfileData IPersistableModel<DeviceRegistryDiscoveredAssetEndpointProfileData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DeviceRegistryDiscoveredAssetEndpointProfileData>(data, options);

        string IPersistableModel<DeviceRegistryDiscoveredAssetEndpointProfileData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DeviceRegistryDiscoveredAssetEndpointProfileData>)Data).GetFormatFromOptions(options);
    }
}
