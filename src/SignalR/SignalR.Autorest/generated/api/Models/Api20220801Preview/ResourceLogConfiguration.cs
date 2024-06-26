// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Extensions;

    /// <summary>Resource log configuration of a Microsoft.SignalRService resource.</summary>
    public partial class ResourceLogConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IResourceLogConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IResourceLogConfigurationInternal
    {

        /// <summary>Backing field for <see cref="Category" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IResourceLogCategory[] _category;

        /// <summary>Gets or sets the list of category configurations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IResourceLogCategory[] Category { get => this._category; set => this._category = value; }

        /// <summary>Creates an new <see cref="ResourceLogConfiguration" /> instance.</summary>
        public ResourceLogConfiguration()
        {

        }
    }
    /// Resource log configuration of a Microsoft.SignalRService resource.
    public partial interface IResourceLogConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets the list of category configurations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the list of category configurations.",
        SerializedName = @"categories",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IResourceLogCategory) })]
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IResourceLogCategory[] Category { get; set; }

    }
    /// Resource log configuration of a Microsoft.SignalRService resource.
    internal partial interface IResourceLogConfigurationInternal

    {
        /// <summary>Gets or sets the list of category configurations.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IResourceLogCategory[] Category { get; set; }

    }
}