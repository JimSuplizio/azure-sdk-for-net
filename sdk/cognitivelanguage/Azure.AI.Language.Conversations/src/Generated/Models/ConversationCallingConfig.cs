// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> The option to set to call a Conversation project. </summary>
    public partial class ConversationCallingConfig
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

        /// <summary> Initializes a new instance of <see cref="ConversationCallingConfig"/>. </summary>
        public ConversationCallingConfig()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ConversationCallingConfig"/>. </summary>
        /// <param name="language"> The language of the query in BCP 47 language representation. </param>
        /// <param name="verbose"> If true, the service will return more detailed information. </param>
        /// <param name="isLoggingEnabled"> If true, the query will be saved for customers to further review in authoring, to improve the model quality. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConversationCallingConfig(string language, bool? verbose, bool? isLoggingEnabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Language = language;
            Verbose = verbose;
            IsLoggingEnabled = isLoggingEnabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The language of the query in BCP 47 language representation. </summary>
        public string Language { get; set; }
        /// <summary> If true, the service will return more detailed information. </summary>
        public bool? Verbose { get; set; }
        /// <summary> If true, the query will be saved for customers to further review in authoring, to improve the model quality. </summary>
        public bool? IsLoggingEnabled { get; set; }
    }
}
