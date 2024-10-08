// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Extensions;

    /// <summary>Cluster access profile.</summary>
    public partial class ClusterAccessProfile :
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterAccessProfile,
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterAccessProfileInternal
    {

        /// <summary>Backing field for <see cref="EnableInternalIngress" /> property.</summary>
        private bool _enableInternalIngress;

        /// <summary>
        /// Whether to create cluster using private IP instead of public IP. This property must be set at create time.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Owned)]
        public bool EnableInternalIngress { get => this._enableInternalIngress; set => this._enableInternalIngress = value; }

        /// <summary>Internal Acessors for PrivateLinkServiceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterAccessProfileInternal.PrivateLinkServiceId { get => this._privateLinkServiceId; set { {_privateLinkServiceId = value;} } }

        /// <summary>Backing field for <see cref="PrivateLinkServiceId" /> property.</summary>
        private string _privateLinkServiceId;

        /// <summary>
        /// Private link service resource ID. Only when enableInternalIngress is true, this property will be returned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Owned)]
        public string PrivateLinkServiceId { get => this._privateLinkServiceId; }

        /// <summary>Creates an new <see cref="ClusterAccessProfile" /> instance.</summary>
        public ClusterAccessProfile()
        {

        }
    }
    /// Cluster access profile.
    public partial interface IClusterAccessProfile :
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Whether to create cluster using private IP instead of public IP. This property must be set at create time.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Whether to create cluster using private IP instead of public IP. This property must be set at create time.",
        SerializedName = @"enableInternalIngress",
        PossibleTypes = new [] { typeof(bool) })]
        bool EnableInternalIngress { get; set; }
        /// <summary>
        /// Private link service resource ID. Only when enableInternalIngress is true, this property will be returned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Private link service resource ID. Only when enableInternalIngress is true, this property will be returned.",
        SerializedName = @"privateLinkServiceId",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkServiceId { get;  }

    }
    /// Cluster access profile.
    internal partial interface IClusterAccessProfileInternal

    {
        /// <summary>
        /// Whether to create cluster using private IP instead of public IP. This property must be set at create time.
        /// </summary>
        bool EnableInternalIngress { get; set; }
        /// <summary>
        /// Private link service resource ID. Only when enableInternalIngress is true, this property will be returned.
        /// </summary>
        string PrivateLinkServiceId { get; set; }

    }
}