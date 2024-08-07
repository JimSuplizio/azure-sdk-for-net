// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Trino user telemetry definition. </summary>
    public partial class TrinoTelemetryConfig
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TrinoTelemetryConfig"/>. </summary>
        public TrinoTelemetryConfig()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TrinoTelemetryConfig"/>. </summary>
        /// <param name="hivecatalogName"> Hive Catalog name used to mount external tables on the logs written by trino, if not specified there tables are not created. </param>
        /// <param name="hivecatalogSchema"> Schema of the above catalog to use, to mount query logs as external tables, if not specified tables will be mounted under schema trinologs. </param>
        /// <param name="partitionRetentionInDays"> Retention period for query log table partitions, this doesn't have any affect on actual data. </param>
        /// <param name="path"> Azure storage location of the blobs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TrinoTelemetryConfig(string hivecatalogName, string hivecatalogSchema, int? partitionRetentionInDays, string path, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            HivecatalogName = hivecatalogName;
            HivecatalogSchema = hivecatalogSchema;
            PartitionRetentionInDays = partitionRetentionInDays;
            Path = path;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Hive Catalog name used to mount external tables on the logs written by trino, if not specified there tables are not created. </summary>
        [WirePath("hivecatalogName")]
        public string HivecatalogName { get; set; }
        /// <summary> Schema of the above catalog to use, to mount query logs as external tables, if not specified tables will be mounted under schema trinologs. </summary>
        [WirePath("hivecatalogSchema")]
        public string HivecatalogSchema { get; set; }
        /// <summary> Retention period for query log table partitions, this doesn't have any affect on actual data. </summary>
        [WirePath("partitionRetentionInDays")]
        public int? PartitionRetentionInDays { get; set; }
        /// <summary> Azure storage location of the blobs. </summary>
        [WirePath("path")]
        public string Path { get; set; }
    }
}
