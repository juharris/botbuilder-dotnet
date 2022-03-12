// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.Bot.Connector.Client.Models
{
    /// <summary> An Activity is the basic communication type for the Bot Framework 3.0 protocol. </summary>
    public partial class Activity
    {
        /// <summary> Initializes a new instance of Activity. </summary>
        public Activity()
        {
            MembersAdded = new ChangeTrackingList<ChannelAccount>();
            MembersRemoved = new ChangeTrackingList<ChannelAccount>();
            ReactionsAdded = new ChangeTrackingList<MessageReaction>();
            ReactionsRemoved = new ChangeTrackingList<MessageReaction>();
            Attachments = new ChangeTrackingList<Attachment>();
            Entities = new ChangeTrackingList<Entity>();
            ListenFor = new ChangeTrackingList<string>();
            TextHighlights = new ChangeTrackingList<TextHighlight>();
        }

        /// <summary> Contains the activity type. </summary>
        public ActivityTypes? Type { get; set; }
        /// <summary> Contains an ID that uniquely identifies the activity on the channel. </summary>
        public string Id { get; set; }
        /// <summary> Contains the date and time that the message was sent, in UTC, expressed in ISO-8601 format. </summary>
        public DateTimeOffset? Timestamp { get; set; }
        /// <summary>
        /// Contains the local date and time of the message, expressed in ISO-8601 format.
        /// 
        /// For example, 2016-09-23T13:07:49.4714686-07:00.
        /// </summary>
        public DateTimeOffset? LocalTimestamp { get; set; }
        /// <summary>
        /// Contains the name of the local timezone of the message, expressed in IANA Time Zone database format.
        /// 
        /// For example, America/Los_Angeles.
        /// </summary>
        public string LocalTimezone { get; set; }
        /// <summary>
        /// A string containing an IRI identifying the caller of a bot. This field is not intended to be transmitted
        /// 
        /// over the wire, but is instead populated by bots and clients based on cryptographically verifiable data
        /// 
        /// that asserts the identity of the callers (e.g. tokens).
        /// </summary>
        public string CallerId { get; set; }
        /// <summary> Contains the URL that specifies the channel&apos;s service endpoint. Set by the channel. </summary>
        public string ServiceUrl { get; set; }
        /// <summary> Contains an ID that uniquely identifies the channel. Set by the channel. </summary>
        public string ChannelId { get; set; }
        /// <summary> Identifies the sender of the message. </summary>
        public ChannelAccount From { get; set; }
        /// <summary> Identifies the conversation to which the activity belongs. </summary>
        public ConversationAccount Conversation { get; set; }
        /// <summary> Identifies the recipient of the message. </summary>
        public ChannelAccount Recipient { get; set; }
        /// <summary> Format of text fields Default:markdown. </summary>
        public TextFormatTypes? TextFormat { get; set; }
        /// <summary> The layout hint for multiple attachments. Default: list. </summary>
        public AttachmentLayoutTypes? AttachmentLayout { get; set; }
        /// <summary> The collection of members added to the conversation. </summary>
        public IList<ChannelAccount> MembersAdded { get; }
        /// <summary> The collection of members removed from the conversation. </summary>
        public IList<ChannelAccount> MembersRemoved { get; }
        /// <summary> The collection of reactions added to the conversation. </summary>
        public IList<MessageReaction> ReactionsAdded { get; }
        /// <summary> The collection of reactions removed from the conversation. </summary>
        public IList<MessageReaction> ReactionsRemoved { get; }
        /// <summary> The updated topic name of the conversation. </summary>
        public string TopicName { get; set; }
        /// <summary> Indicates whether the prior history of the channel is disclosed. </summary>
        public bool? HistoryDisclosed { get; set; }
        /// <summary> A BCP-47 locale name for the contents of the text field. </summary>
        public string Locale { get; set; }
        /// <summary> The text content of the message. </summary>
        public string Text { get; set; }
        /// <summary> The text to speak. </summary>
        public string Speak { get; set; }
        /// <summary>
        /// Indicates whether your bot is accepting,
        /// 
        /// expecting, or ignoring user input after the message is delivered to the client.
        /// </summary>
        public InputHints? InputHint { get; set; }
        /// <summary> The text to display if the channel cannot render cards. </summary>
        public string Summary { get; set; }
        /// <summary> The suggested actions for the activity. </summary>
        public SuggestedActions SuggestedActions { get; set; }
        /// <summary> Attachments. </summary>
        public IList<Attachment> Attachments { get; }
        /// <summary> Represents the entities that were mentioned in the message. </summary>
        public IList<Entity> Entities { get; }
        /// <summary> Contains channel-specific content. </summary>
        public object ChannelData { get; set; }
        /// <summary> Indicates whether the recipient of a contactRelationUpdate was added or removed from the sender&apos;s contact list. </summary>
        public string Action { get; set; }
        /// <summary> Contains the ID of the message to which this message is a reply. </summary>
        public string ReplyToId { get; set; }
        /// <summary> A descriptive label for the activity. </summary>
        public string Label { get; set; }
        /// <summary> The type of the activity&apos;s value object. </summary>
        public string ValueType { get; set; }
        /// <summary> A value that is associated with the activity. </summary>
        public object Value { get; set; }
        /// <summary> The name of the operation associated with an invoke or event activity. </summary>
        public string Name { get; set; }
        /// <summary> A reference to another conversation or activity. </summary>
        public ConversationReference RelatesTo { get; set; }
        /// <summary> The a code for endOfConversation activities that indicates why the conversation ended. </summary>
        public EndOfConversationCodes? Code { get; set; }
        /// <summary> The time at which the activity should be considered to be &quot;expired&quot; and should not be presented to the recipient. </summary>
        public DateTimeOffset? Expiration { get; set; }
        /// <summary> The importance of the activity. </summary>
        public ActivityImportance? Importance { get; set; }
        /// <summary>
        /// A delivery hint to signal to the recipient alternate delivery paths for the activity.
        /// 
        /// The default delivery mode is &quot;default&quot;.
        /// </summary>
        public DeliveryModes? DeliveryMode { get; set; }
        /// <summary> List of phrases and references that speech and language priming systems should listen for. </summary>
        public IList<string> ListenFor { get; }
        /// <summary> The collection of text fragments to highlight when the activity contains a ReplyToId value. </summary>
        public IList<TextHighlight> TextHighlights { get; }
        /// <summary> An optional programmatic action accompanying this request. </summary>
        public SemanticAction SemanticAction { get; set; }
    }
}
