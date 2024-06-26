// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models.Api20230501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Extensions;

    /// <summary>Properties pertaining to the ClfsTarget</summary>
    public partial class ClfsTarget :
        Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models.Api20230501.IClfsTarget,
        Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models.Api20230501.IClfsTargetInternal
    {

        /// <summary>Backing field for <see cref="Target" /> property.</summary>
        private string _target;

        /// <summary>Resource ID of storage container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageCache.PropertyOrigin.Owned)]
        public string Target { get => this._target; set => this._target = value; }

        /// <summary>Creates an new <see cref="ClfsTarget" /> instance.</summary>
        public ClfsTarget()
        {

        }
    }
    /// Properties pertaining to the ClfsTarget
    public partial interface IClfsTarget :
        Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.IJsonSerializable
    {
        /// <summary>Resource ID of storage container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource ID of storage container.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string Target { get; set; }

    }
    /// Properties pertaining to the ClfsTarget
    internal partial interface IClfsTargetInternal

    {
        /// <summary>Resource ID of storage container.</summary>
        string Target { get; set; }

    }
}