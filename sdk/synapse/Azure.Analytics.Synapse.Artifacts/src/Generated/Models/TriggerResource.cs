// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Trigger resource type. </summary>
    public partial class TriggerResource : SubResource
    {
        /// <summary> Initializes a new instance of TriggerResource. </summary>
        /// <param name="properties"> Properties of the trigger. </param>
        public TriggerResource(Trigger properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of TriggerResource. </summary>
        /// <param name="id"> The resource identifier. </param>
        /// <param name="name"> The resource name. </param>
        /// <param name="type"> The resource type. </param>
        /// <param name="etag"> Etag identifies change in the resource. </param>
        /// <param name="properties"> Properties of the trigger. </param>
        internal TriggerResource(string id, string name, string type, string etag, Trigger properties) : base(id, name, type, etag)
        {
            Properties = properties;
        }

        /// <summary> Properties of the trigger. </summary>
        public Trigger Properties { get; set; }
    }
}