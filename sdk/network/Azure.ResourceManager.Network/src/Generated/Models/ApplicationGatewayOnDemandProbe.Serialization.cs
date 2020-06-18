// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayOnDemandProbe : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Protocol != null)
            {
                writer.WritePropertyName("protocol");
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Host != null)
            {
                writer.WritePropertyName("host");
                writer.WriteStringValue(Host);
            }
            if (Path != null)
            {
                writer.WritePropertyName("path");
                writer.WriteStringValue(Path);
            }
            if (Timeout != null)
            {
                writer.WritePropertyName("timeout");
                writer.WriteNumberValue(Timeout.Value);
            }
            if (PickHostNameFromBackendHttpSettings != null)
            {
                writer.WritePropertyName("pickHostNameFromBackendHttpSettings");
                writer.WriteBooleanValue(PickHostNameFromBackendHttpSettings.Value);
            }
            if (Match != null)
            {
                writer.WritePropertyName("match");
                writer.WriteObjectValue(Match);
            }
            if (BackendAddressPool != null)
            {
                writer.WritePropertyName("backendAddressPool");
                writer.WriteObjectValue(BackendAddressPool);
            }
            if (BackendHttpSettings != null)
            {
                writer.WritePropertyName("backendHttpSettings");
                writer.WriteObjectValue(BackendHttpSettings);
            }
            writer.WriteEndObject();
        }
    }
}