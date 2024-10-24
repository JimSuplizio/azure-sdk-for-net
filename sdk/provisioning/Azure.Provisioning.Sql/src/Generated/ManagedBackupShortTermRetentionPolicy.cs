// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// ManagedBackupShortTermRetentionPolicy.
/// </summary>
public partial class ManagedBackupShortTermRetentionPolicy : ProvisionableResource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The backup retention period in days. This is how many days
    /// Point-in-Time Restore will be supported.
    /// </summary>
    public BicepValue<int> RetentionDays { get => _retentionDays; set => _retentionDays.Assign(value); }
    private readonly BicepValue<int> _retentionDays;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent ManagedDatabase.
    /// </summary>
    public ManagedDatabase? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<ManagedDatabase> _parent;

    /// <summary>
    /// Creates a new ManagedBackupShortTermRetentionPolicy.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the
    /// ManagedBackupShortTermRetentionPolicy resource.  This can be used to
    /// refer to the resource in expressions, but is not the Azure name of the
    /// resource.  This value can contain letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ManagedBackupShortTermRetentionPolicy.</param>
    public ManagedBackupShortTermRetentionPolicy(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Sql/managedInstances/databases/backupShortTermRetentionPolicies", resourceVersion ?? "2021-11-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _retentionDays = BicepValue<int>.DefineProperty(this, "RetentionDays", ["properties", "retentionDays"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<ManagedDatabase>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported ManagedBackupShortTermRetentionPolicy resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-05-01-preview.
        /// </summary>
        public static readonly string V2024_05_01_preview = "2024-05-01-preview";

        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";
    }

    /// <summary>
    /// Creates a reference to an existing
    /// ManagedBackupShortTermRetentionPolicy.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the
    /// ManagedBackupShortTermRetentionPolicy resource.  This can be used to
    /// refer to the resource in expressions, but is not the Azure name of the
    /// resource.  This value can contain letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ManagedBackupShortTermRetentionPolicy.</param>
    /// <returns>The existing ManagedBackupShortTermRetentionPolicy resource.</returns>
    public static ManagedBackupShortTermRetentionPolicy FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
