// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class AzureFirewallSku : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name.Value.ToString());
            }
            if (Tier != null)
            {
                writer.WritePropertyName("tier");
                writer.WriteStringValue(Tier.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static AzureFirewallSku DeserializeAzureFirewallSku(JsonElement element)
        {
            AzureFirewallSkuName? name = default;
            AzureFirewallSkuTier? tier = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = new AzureFirewallSkuName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tier = new AzureFirewallSkuTier(property.Value.GetString());
                    continue;
                }
            }
            return new AzureFirewallSku(name, tier);
        }
    }
}