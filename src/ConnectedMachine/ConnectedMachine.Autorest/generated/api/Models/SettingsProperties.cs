// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Extensions;

    /// <summary>Settings properties</summary>
    public partial class SettingsProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ISettingsProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ISettingsPropertiesInternal
    {

        /// <summary>Backing field for <see cref="GatewayProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ISettingsGatewayProperties _gatewayProperty;

        /// <summary>Settings Gateway properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ISettingsGatewayProperties GatewayProperty { get => (this._gatewayProperty = this._gatewayProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.SettingsGatewayProperties()); set => this._gatewayProperty = value; }

        /// <summary>Associated Gateway Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public string GatewayPropertyGatewayResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ISettingsGatewayPropertiesInternal)GatewayProperty).GatewayResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ISettingsGatewayPropertiesInternal)GatewayProperty).GatewayResourceId = value ?? null; }

        /// <summary>Internal Acessors for GatewayProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ISettingsGatewayProperties Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ISettingsPropertiesInternal.GatewayProperty { get => (this._gatewayProperty = this._gatewayProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.SettingsGatewayProperties()); set { {_gatewayProperty = value;} } }

        /// <summary>Internal Acessors for TenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ISettingsPropertiesInternal.TenantId { get => this._tenantId; set { {_tenantId = value;} } }

        /// <summary>Backing field for <see cref="TenantId" /> property.</summary>
        private string _tenantId;

        /// <summary>Azure resource tenant Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string TenantId { get => this._tenantId; }

        /// <summary>Creates an new <see cref="SettingsProperties" /> instance.</summary>
        public SettingsProperties()
        {

        }
    }
    /// Settings properties
    public partial interface ISettingsProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.IJsonSerializable
    {
        /// <summary>Associated Gateway Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Associated Gateway Resource Id",
        SerializedName = @"gatewayResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string GatewayPropertyGatewayResourceId { get; set; }
        /// <summary>Azure resource tenant Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Azure resource tenant Id",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get;  }

    }
    /// Settings properties
    internal partial interface ISettingsPropertiesInternal

    {
        /// <summary>Settings Gateway properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ISettingsGatewayProperties GatewayProperty { get; set; }
        /// <summary>Associated Gateway Resource Id</summary>
        string GatewayPropertyGatewayResourceId { get; set; }
        /// <summary>Azure resource tenant Id</summary>
        string TenantId { get; set; }

    }
}