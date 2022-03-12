// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.Bot.Connector.Client.Models
{
    /// <summary> SuggestedActions that can be performed. </summary>
    public partial class SuggestedActions
    {
        /// <summary> Initializes a new instance of SuggestedActions. </summary>
        public SuggestedActions()
        {
            To = new ChangeTrackingList<string>();
            Actions = new ChangeTrackingList<CardAction>();
        }

        /// <summary> Ids of the recipients that the actions should be shown to.  These Ids are relative to the channelId and a subset of all recipients of the activity. </summary>
        public IList<string> To { get; }
        /// <summary> Actions that can be shown to the user. </summary>
        public IList<CardAction> Actions { get; }
    }
}
