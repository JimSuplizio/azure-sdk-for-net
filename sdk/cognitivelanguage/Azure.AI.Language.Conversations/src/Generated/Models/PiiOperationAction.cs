// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> Task definition for a PII redaction in conversations. </summary>
    public partial class PiiOperationAction : AnalyzeConversationOperationAction
    {
        /// <summary> Initializes a new instance of <see cref="PiiOperationAction"/>. </summary>
        public PiiOperationAction()
        {
            Kind = AnalyzeConversationOperationActionKind.ConversationalPIITask;
        }

        /// <summary> Initializes a new instance of <see cref="PiiOperationAction"/>. </summary>
        /// <param name="name"> task name. </param>
        /// <param name="kind"> Enumeration of supported analysis tasks on a collection of conversations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="actionContent"> parameters. </param>
        internal PiiOperationAction(string name, AnalyzeConversationOperationActionKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, ConversationPiiActionContent actionContent) : base(name, kind, serializedAdditionalRawData)
        {
            ActionContent = actionContent;
        }

        /// <summary> parameters. </summary>
        public ConversationPiiActionContent ActionContent { get; set; }
    }
}
