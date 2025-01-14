// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.EventHubs;

/// <summary>
/// A class representing the EventHubsPrivateEndpointConnection data model.
/// Properties of the PrivateEndpointConnection.
/// </summary>
public partial class EventHubsPrivateEndpointConnectionData : ProvisionableConstruct
{
    /// <summary>
    /// Gets or sets Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> PrivateEndpointId 
    {
        get { Initialize(); return _privateEndpointId!; }
        set { Initialize(); _privateEndpointId!.Assign(value); }
    }
    private BicepValue<ResourceIdentifier>? _privateEndpointId;

    /// <summary>
    /// Details about the state of the connection.
    /// </summary>
    public EventHubsPrivateLinkServiceConnectionState ConnectionState 
    {
        get { Initialize(); return _connectionState!; }
        set { Initialize(); AssignOrReplace(ref _connectionState, value); }
    }
    private EventHubsPrivateLinkServiceConnectionState? _connectionState;

    /// <summary>
    /// Provisioning state of the Private Endpoint Connection.
    /// </summary>
    public BicepValue<EventHubsPrivateEndpointConnectionProvisioningState> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
        set { Initialize(); _provisioningState!.Assign(value); }
    }
    private BicepValue<EventHubsPrivateEndpointConnectionProvisioningState>? _provisioningState;

    /// <summary>
    /// The geo-location where the resource lives.
    /// </summary>
    public BicepValue<AzureLocation> Location 
    {
        get { Initialize(); return _location!; }
    }
    private BicepValue<AzureLocation>? _location;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Creates a new EventHubsPrivateEndpointConnectionData.
    /// </summary>
    public EventHubsPrivateEndpointConnectionData()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// EventHubsPrivateEndpointConnectionData.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _privateEndpointId = DefineProperty<ResourceIdentifier>("PrivateEndpointId", ["properties", "privateEndpoint", "id"]);
        _connectionState = DefineModelProperty<EventHubsPrivateLinkServiceConnectionState>("ConnectionState", ["properties", "privateLinkServiceConnectionState"]);
        _provisioningState = DefineProperty<EventHubsPrivateEndpointConnectionProvisioningState>("ProvisioningState", ["properties", "provisioningState"]);
        _location = DefineProperty<AzureLocation>("Location", ["location"], isOutput: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _name = DefineProperty<string>("Name", ["name"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
    }
}
