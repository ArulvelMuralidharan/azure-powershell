// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Relay.Runtime.Extensions;

    /// <summary>Namespace/Relay Connection String</summary>
    public partial class AccessKeys :
        Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IAccessKeys,
        Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IAccessKeysInternal
    {

        /// <summary>Backing field for <see cref="KeyName" /> property.</summary>
        private string _keyName;

        /// <summary>A string that describes the authorization rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Origin(Microsoft.Azure.PowerShell.Cmdlets.Relay.PropertyOrigin.Owned)]
        public string KeyName { get => this._keyName; set => this._keyName = value; }

        /// <summary>Backing field for <see cref="PrimaryConnectionString" /> property.</summary>
        private string _primaryConnectionString;

        /// <summary>Primary connection string of the created namespace authorization rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Origin(Microsoft.Azure.PowerShell.Cmdlets.Relay.PropertyOrigin.Owned)]
        public string PrimaryConnectionString { get => this._primaryConnectionString; set => this._primaryConnectionString = value; }

        /// <summary>Backing field for <see cref="PrimaryKey" /> property.</summary>
        private string _primaryKey;

        /// <summary>A base64-encoded 256-bit primary key for signing and validating the SAS token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Origin(Microsoft.Azure.PowerShell.Cmdlets.Relay.PropertyOrigin.Owned)]
        public string PrimaryKey { get => this._primaryKey; set => this._primaryKey = value; }

        /// <summary>Backing field for <see cref="SecondaryConnectionString" /> property.</summary>
        private string _secondaryConnectionString;

        /// <summary>Secondary connection string of the created namespace authorization rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Origin(Microsoft.Azure.PowerShell.Cmdlets.Relay.PropertyOrigin.Owned)]
        public string SecondaryConnectionString { get => this._secondaryConnectionString; set => this._secondaryConnectionString = value; }

        /// <summary>Backing field for <see cref="SecondaryKey" /> property.</summary>
        private string _secondaryKey;

        /// <summary>
        /// A base64-encoded 256-bit secondary key for signing and validating the SAS token.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Origin(Microsoft.Azure.PowerShell.Cmdlets.Relay.PropertyOrigin.Owned)]
        public string SecondaryKey { get => this._secondaryKey; set => this._secondaryKey = value; }

        /// <summary>Creates an new <see cref="AccessKeys" /> instance.</summary>
        public AccessKeys()
        {

        }
    }
    /// Namespace/Relay Connection String
    public partial interface IAccessKeys :
        Microsoft.Azure.PowerShell.Cmdlets.Relay.Runtime.IJsonSerializable
    {
        /// <summary>A string that describes the authorization rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A string that describes the authorization rule.",
        SerializedName = @"keyName",
        PossibleTypes = new [] { typeof(string) })]
        string KeyName { get; set; }
        /// <summary>Primary connection string of the created namespace authorization rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Primary connection string of the created namespace authorization rule.",
        SerializedName = @"primaryConnectionString",
        PossibleTypes = new [] { typeof(string) })]
        string PrimaryConnectionString { get; set; }
        /// <summary>A base64-encoded 256-bit primary key for signing and validating the SAS token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A base64-encoded 256-bit primary key for signing and validating the SAS token.",
        SerializedName = @"primaryKey",
        PossibleTypes = new [] { typeof(string) })]
        string PrimaryKey { get; set; }
        /// <summary>Secondary connection string of the created namespace authorization rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Secondary connection string of the created namespace authorization rule.",
        SerializedName = @"secondaryConnectionString",
        PossibleTypes = new [] { typeof(string) })]
        string SecondaryConnectionString { get; set; }
        /// <summary>
        /// A base64-encoded 256-bit secondary key for signing and validating the SAS token.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A base64-encoded 256-bit secondary key for signing and validating the SAS token.",
        SerializedName = @"secondaryKey",
        PossibleTypes = new [] { typeof(string) })]
        string SecondaryKey { get; set; }

    }
    /// Namespace/Relay Connection String
    internal partial interface IAccessKeysInternal

    {
        /// <summary>A string that describes the authorization rule.</summary>
        string KeyName { get; set; }
        /// <summary>Primary connection string of the created namespace authorization rule.</summary>
        string PrimaryConnectionString { get; set; }
        /// <summary>A base64-encoded 256-bit primary key for signing and validating the SAS token.</summary>
        string PrimaryKey { get; set; }
        /// <summary>Secondary connection string of the created namespace authorization rule.</summary>
        string SecondaryConnectionString { get; set; }
        /// <summary>
        /// A base64-encoded 256-bit secondary key for signing and validating the SAS token.
        /// </summary>
        string SecondaryKey { get; set; }

    }
}