// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Managed Certificate used for https
    /// </summary>
    [Newtonsoft.Json.JsonObject("ManagedCertificate")]
    public partial class ManagedCertificateParameters : SecretParameters
    {
        /// <summary>
        /// Initializes a new instance of the ManagedCertificateParameters
        /// class.
        /// </summary>
        public ManagedCertificateParameters()
        {
            CustomInit();
        }


        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
