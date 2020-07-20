// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The ApiProperties. </summary>
    public partial class ApiProperties
    {
        /// <summary> Initializes a new instance of ApiProperties. </summary>
        public ApiProperties()
        {
        }

        /// <summary> Initializes a new instance of ApiProperties. </summary>
        /// <param name="serverVersion"> Describes the ServerVersion of an a MongoDB account. </param>
        internal ApiProperties(ServerVersion? serverVersion)
        {
            ServerVersion = serverVersion;
        }

        /// <summary> Describes the ServerVersion of an a MongoDB account. </summary>
        public ServerVersion? ServerVersion { get; set; }
    }
}