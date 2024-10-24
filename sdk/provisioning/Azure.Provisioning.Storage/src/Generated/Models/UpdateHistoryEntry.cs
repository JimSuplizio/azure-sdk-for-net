// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// An update history of the ImmutabilityPolicy of a blob container.
/// </summary>
public partial class UpdateHistoryEntry : ProvisionableConstruct
{
    /// <summary>
    /// The ImmutabilityPolicy update type of a blob container, possible values
    /// include: put, lock and extend.
    /// </summary>
    public BicepValue<ImmutabilityPolicyUpdateType> UpdateType { get => _updateType; }
    private readonly BicepValue<ImmutabilityPolicyUpdateType> _updateType;

    /// <summary>
    /// The immutability period for the blobs in the container since the policy
    /// creation, in days.
    /// </summary>
    public BicepValue<int> ImmutabilityPeriodSinceCreationInDays { get => _immutabilityPeriodSinceCreationInDays; }
    private readonly BicepValue<int> _immutabilityPeriodSinceCreationInDays;

    /// <summary>
    /// Returns the date and time the ImmutabilityPolicy was updated.
    /// </summary>
    public BicepValue<DateTimeOffset> Timestamp { get => _timestamp; }
    private readonly BicepValue<DateTimeOffset> _timestamp;

    /// <summary>
    /// Returns the Object ID of the user who updated the ImmutabilityPolicy.
    /// </summary>
    public BicepValue<string> ObjectIdentifier { get => _objectIdentifier; }
    private readonly BicepValue<string> _objectIdentifier;

    /// <summary>
    /// Returns the Tenant ID that issued the token for the user who updated
    /// the ImmutabilityPolicy.
    /// </summary>
    public BicepValue<Guid> TenantId { get => _tenantId; }
    private readonly BicepValue<Guid> _tenantId;

    /// <summary>
    /// Returns the User Principal Name of the user who updated the
    /// ImmutabilityPolicy.
    /// </summary>
    public BicepValue<string> Upn { get => _upn; }
    private readonly BicepValue<string> _upn;

    /// <summary>
    /// This property can only be changed for unlocked time-based retention
    /// policies. When enabled, new blocks can be written to an append blob
    /// while maintaining immutability protection and compliance. Only new
    /// blocks can be added and any existing blocks cannot be modified or
    /// deleted. This property cannot be changed with ExtendImmutabilityPolicy
    /// API.
    /// </summary>
    public BicepValue<bool> AllowProtectedAppendWrites { get => _allowProtectedAppendWrites; }
    private readonly BicepValue<bool> _allowProtectedAppendWrites;

    /// <summary>
    /// This property can only be changed for unlocked time-based retention
    /// policies. When enabled, new blocks can be written to both &apos;Append
    /// and Bock Blobs&apos; while maintaining immutability protection and
    /// compliance. Only new blocks can be added and any existing blocks
    /// cannot be modified or deleted. This property cannot be changed with
    /// ExtendImmutabilityPolicy API. The
    /// &apos;allowProtectedAppendWrites&apos; and
    /// &apos;allowProtectedAppendWritesAll&apos; properties are mutually
    /// exclusive.
    /// </summary>
    public BicepValue<bool> AllowProtectedAppendWritesAll { get => _allowProtectedAppendWritesAll; }
    private readonly BicepValue<bool> _allowProtectedAppendWritesAll;

    /// <summary>
    /// Creates a new UpdateHistoryEntry.
    /// </summary>
    public UpdateHistoryEntry()
    {
        _updateType = BicepValue<ImmutabilityPolicyUpdateType>.DefineProperty(this, "UpdateType", ["update"], isOutput: true);
        _immutabilityPeriodSinceCreationInDays = BicepValue<int>.DefineProperty(this, "ImmutabilityPeriodSinceCreationInDays", ["immutabilityPeriodSinceCreationInDays"], isOutput: true);
        _timestamp = BicepValue<DateTimeOffset>.DefineProperty(this, "Timestamp", ["timestamp"], isOutput: true);
        _objectIdentifier = BicepValue<string>.DefineProperty(this, "ObjectIdentifier", ["objectIdentifier"], isOutput: true);
        _tenantId = BicepValue<Guid>.DefineProperty(this, "TenantId", ["tenantId"], isOutput: true);
        _upn = BicepValue<string>.DefineProperty(this, "Upn", ["upn"], isOutput: true);
        _allowProtectedAppendWrites = BicepValue<bool>.DefineProperty(this, "AllowProtectedAppendWrites", ["allowProtectedAppendWrites"], isOutput: true);
        _allowProtectedAppendWritesAll = BicepValue<bool>.DefineProperty(this, "AllowProtectedAppendWritesAll", ["allowProtectedAppendWritesAll"], isOutput: true);
    }
}
