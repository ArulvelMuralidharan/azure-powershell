// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Extensions;

    /// <summary>Details of the elasticity profile.</summary>
    public partial class StandbyVirtualMachinePoolElasticityProfile :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolElasticityProfile,
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolElasticityProfileInternal
    {

        /// <summary>Backing field for <see cref="MaxReadyCapacity" /> property.</summary>
        private long _maxReadyCapacity;

        /// <summary>
        /// Specifies maximum number of virtual machines in the standby virtual machine pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public long MaxReadyCapacity { get => this._maxReadyCapacity; set => this._maxReadyCapacity = value; }

        /// <summary>
        /// Creates an new <see cref="StandbyVirtualMachinePoolElasticityProfile" /> instance.
        /// </summary>
        public StandbyVirtualMachinePoolElasticityProfile()
        {

        }
    }
    /// Details of the elasticity profile.
    public partial interface IStandbyVirtualMachinePoolElasticityProfile :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Specifies maximum number of virtual machines in the standby virtual machine pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies maximum number of virtual machines in the standby virtual machine pool.",
        SerializedName = @"maxReadyCapacity",
        PossibleTypes = new [] { typeof(long) })]
        long MaxReadyCapacity { get; set; }

    }
    /// Details of the elasticity profile.
    internal partial interface IStandbyVirtualMachinePoolElasticityProfileInternal

    {
        /// <summary>
        /// Specifies maximum number of virtual machines in the standby virtual machine pool.
        /// </summary>
        long MaxReadyCapacity { get; set; }

    }
}