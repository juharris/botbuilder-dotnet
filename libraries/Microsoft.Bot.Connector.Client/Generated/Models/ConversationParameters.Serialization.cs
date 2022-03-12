// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Bot.Connector.Client.Models
{
    public partial class ConversationParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsGroup))
            {
                writer.WritePropertyName("isGroup");
                writer.WriteBooleanValue(IsGroup.Value);
            }
            if (Optional.IsDefined(Bot))
            {
                writer.WritePropertyName("bot");
                writer.WriteObjectValue(Bot);
            }
            if (Optional.IsCollectionDefined(Members))
            {
                writer.WritePropertyName("members");
                writer.WriteStartArray();
                foreach (var item in Members)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TopicName))
            {
                writer.WritePropertyName("topicName");
                writer.WriteStringValue(TopicName);
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId");
                writer.WriteStringValue(TenantId);
            }
            if (Optional.IsDefined(Activity))
            {
                writer.WritePropertyName("activity");
                writer.WriteObjectValue(Activity);
            }
            if (Optional.IsDefined(ChannelData))
            {
                writer.WritePropertyName("channelData");
                writer.WriteObjectValue(ChannelData);
            }
            writer.WriteEndObject();
        }
    }
}
