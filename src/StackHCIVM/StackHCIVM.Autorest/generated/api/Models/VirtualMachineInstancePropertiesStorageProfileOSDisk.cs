// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Extensions;

    /// <summary>VHD to attach as OS disk</summary>
    public partial class VirtualMachineInstancePropertiesStorageProfileOSDisk :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IVirtualMachineInstancePropertiesStorageProfileOSDisk,
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IVirtualMachineInstancePropertiesStorageProfileOSDiskInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource ID of the OS disk</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="OSType" /> property.</summary>
        private string _oSType;

        /// <summary>
        /// This property allows you to specify the type of the OS that is included in the disk if creating a VM from user-image or
        /// a specialized VHD. Possible values are: **Windows,** **Linux.**
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.PropertyOrigin.Owned)]
        public string OSType { get => this._oSType; set => this._oSType = value; }

        /// <summary>
        /// Creates an new <see cref="VirtualMachineInstancePropertiesStorageProfileOSDisk" /> instance.
        /// </summary>
        public VirtualMachineInstancePropertiesStorageProfileOSDisk()
        {

        }
    }
    /// VHD to attach as OS disk
    public partial interface IVirtualMachineInstancePropertiesStorageProfileOSDisk :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.IJsonSerializable
    {
        /// <summary>Resource ID of the OS disk</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource ID of the OS disk",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>
        /// This property allows you to specify the type of the OS that is included in the disk if creating a VM from user-image or
        /// a specialized VHD. Possible values are: **Windows,** **Linux.**
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"This property allows you to specify the type of the OS that is included in the disk if creating a VM from user-image or a specialized VHD. Possible values are: **Windows,** **Linux.**",
        SerializedName = @"osType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.PSArgumentCompleterAttribute("Windows", "Linux")]
        string OSType { get; set; }

    }
    /// VHD to attach as OS disk
    internal partial interface IVirtualMachineInstancePropertiesStorageProfileOSDiskInternal

    {
        /// <summary>Resource ID of the OS disk</summary>
        string Id { get; set; }
        /// <summary>
        /// This property allows you to specify the type of the OS that is included in the disk if creating a VM from user-image or
        /// a specialized VHD. Possible values are: **Windows,** **Linux.**
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.PSArgumentCompleterAttribute("Windows", "Linux")]
        string OSType { get; set; }

    }
}