// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Extensions;

    /// <summary>Represents the properties of the records in the record set.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.Dns.DoNotFormat]
    public partial class RecordSetProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IRecordSetProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IRecordSetPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ARecord" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IARecord[] _aRecord;

        /// <summary>The list of A records in the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IARecord[] ARecord { get => this._aRecord; set => this._aRecord = value; }

        /// <summary>Backing field for <see cref="AaaaRecord" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IAaaaRecord[] _aaaaRecord;

        /// <summary>The list of AAAA records in the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IAaaaRecord[] AaaaRecord { get => this._aaaaRecord; set => this._aaaaRecord = value; }

        /// <summary>Backing field for <see cref="CaaRecord" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ICaaRecord[] _caaRecord;

        /// <summary>The list of CAA records in the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ICaaRecord[] CaaRecord { get => this._caaRecord; set => this._caaRecord = value; }

        /// <summary>Backing field for <see cref="CnameRecord" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ICnameRecord _cnameRecord;

        /// <summary>The CNAME record in the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ICnameRecord CnameRecord { get => (this._cnameRecord = this._cnameRecord ?? new Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.CnameRecord()); set => this._cnameRecord = value; }

        /// <summary>The canonical name for this CNAME record.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Inlined)]
        public string CnameRecordCname { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ICnameRecordInternal)CnameRecord).Cname; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ICnameRecordInternal)CnameRecord).Cname = value ?? null; }

        /// <summary>Backing field for <see cref="DsRecord" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IDsRecord[] _dsRecord;

        /// <summary>The list of DS records in the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IDsRecord[] DsRecord { get => this._dsRecord; set => this._dsRecord = value; }

        /// <summary>Backing field for <see cref="Fqdn" /> property.</summary>
        private string _fqdn;

        /// <summary>Fully qualified domain name of the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Owned)]
        public string Fqdn { get => this._fqdn; }

        /// <summary>Backing field for <see cref="Metadata" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IRecordSetPropertiesMetadata _metadata;

        /// <summary>The metadata attached to the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IRecordSetPropertiesMetadata Metadata { get => (this._metadata = this._metadata ?? new Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.RecordSetPropertiesMetadata()); set => this._metadata = value; }

        /// <summary>Internal Acessors for CnameRecord</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ICnameRecord Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IRecordSetPropertiesInternal.CnameRecord { get => (this._cnameRecord = this._cnameRecord ?? new Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.CnameRecord()); set { {_cnameRecord = value;} } }

        /// <summary>Internal Acessors for Fqdn</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IRecordSetPropertiesInternal.Fqdn { get => this._fqdn; set { {_fqdn = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IRecordSetPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for SoaRecord</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISoaRecord Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IRecordSetPropertiesInternal.SoaRecord { get => (this._soaRecord = this._soaRecord ?? new Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.SoaRecord()); set { {_soaRecord = value;} } }

        /// <summary>Internal Acessors for TargetResource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISubResource Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IRecordSetPropertiesInternal.TargetResource { get => (this._targetResource = this._targetResource ?? new Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.SubResource()); set { {_targetResource = value;} } }

        /// <summary>Backing field for <see cref="MxRecord" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IMxRecord[] _mxRecord;

        /// <summary>The list of MX records in the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IMxRecord[] MxRecord { get => this._mxRecord; set => this._mxRecord = value; }

        /// <summary>Backing field for <see cref="NaptrRecord" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.INaptrRecord[] _naptrRecord;

        /// <summary>The list of NAPTR records in the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.INaptrRecord[] NaptrRecord { get => this._naptrRecord; set => this._naptrRecord = value; }

        /// <summary>Backing field for <see cref="NsRecord" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.INsRecord[] _nsRecord;

        /// <summary>The list of NS records in the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.INsRecord[] NsRecord { get => this._nsRecord; set => this._nsRecord = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>provisioning State of the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="PtrRecord" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IPtrRecord[] _ptrRecord;

        /// <summary>The list of PTR records in the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IPtrRecord[] PtrRecord { get => this._ptrRecord; set => this._ptrRecord = value; }

        /// <summary>Backing field for <see cref="SoaRecord" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISoaRecord _soaRecord;

        /// <summary>The SOA record in the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISoaRecord SoaRecord { get => (this._soaRecord = this._soaRecord ?? new Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.SoaRecord()); set => this._soaRecord = value; }

        /// <summary>The email contact for this SOA record.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Inlined)]
        public string SoaRecordEmail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISoaRecordInternal)SoaRecord).Email; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISoaRecordInternal)SoaRecord).Email = value ?? null; }

        /// <summary>The expire time for this SOA record.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Inlined)]
        public long? SoaRecordExpireTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISoaRecordInternal)SoaRecord).ExpireTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISoaRecordInternal)SoaRecord).ExpireTime = value ?? default(long); }

        /// <summary>The domain name of the authoritative name server for this SOA record.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Inlined)]
        public string SoaRecordHost { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISoaRecordInternal)SoaRecord).Host; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISoaRecordInternal)SoaRecord).Host = value ?? null; }

        /// <summary>
        /// The minimum value for this SOA record. By convention this is used to determine the negative caching duration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Inlined)]
        public long? SoaRecordMinimumTtl { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISoaRecordInternal)SoaRecord).MinimumTtl; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISoaRecordInternal)SoaRecord).MinimumTtl = value ?? default(long); }

        /// <summary>The refresh value for this SOA record.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Inlined)]
        public long? SoaRecordRefreshTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISoaRecordInternal)SoaRecord).RefreshTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISoaRecordInternal)SoaRecord).RefreshTime = value ?? default(long); }

        /// <summary>The retry time for this SOA record.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Inlined)]
        public long? SoaRecordRetryTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISoaRecordInternal)SoaRecord).RetryTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISoaRecordInternal)SoaRecord).RetryTime = value ?? default(long); }

        /// <summary>The serial number for this SOA record.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Inlined)]
        public long? SoaRecordSerialNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISoaRecordInternal)SoaRecord).SerialNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISoaRecordInternal)SoaRecord).SerialNumber = value ?? default(long); }

        /// <summary>Backing field for <see cref="SrvRecord" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISrvRecord[] _srvRecord;

        /// <summary>The list of SRV records in the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISrvRecord[] SrvRecord { get => this._srvRecord; set => this._srvRecord = value; }

        /// <summary>Backing field for <see cref="TargetResource" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISubResource _targetResource;

        /// <summary>A reference to an azure resource from where the dns resource value is taken.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISubResource TargetResource { get => (this._targetResource = this._targetResource ?? new Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.SubResource()); set => this._targetResource = value; }

        /// <summary>Resource Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Inlined)]
        public string TargetResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISubResourceInternal)TargetResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISubResourceInternal)TargetResource).Id = value ?? null; }

        /// <summary>Backing field for <see cref="TlsaRecord" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ITlsaRecord[] _tlsaRecord;

        /// <summary>The list of TLSA records in the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ITlsaRecord[] TlsaRecord { get => this._tlsaRecord; set => this._tlsaRecord = value; }

        /// <summary>Backing field for <see cref="Ttl" /> property.</summary>
        private long? _ttl;

        /// <summary>The TTL (time-to-live) of the records in the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Owned)]
        public long? Ttl { get => this._ttl; set => this._ttl = value; }

        /// <summary>Backing field for <see cref="TxtRecord" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ITxtRecord[] _txtRecord;

        /// <summary>The list of TXT records in the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ITxtRecord[] TxtRecord { get => this._txtRecord; set => this._txtRecord = value; }

        /// <summary>Creates an new <see cref="RecordSetProperties" /> instance.</summary>
        public RecordSetProperties()
        {

        }
    }
    /// Represents the properties of the records in the record set.
    public partial interface IRecordSetProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.IJsonSerializable
    {
        /// <summary>The list of A records in the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of A records in the record set.",
        SerializedName = @"ARecords",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IARecord) })]
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IARecord[] ARecord { get; set; }
        /// <summary>The list of AAAA records in the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of AAAA records in the record set.",
        SerializedName = @"AAAARecords",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IAaaaRecord) })]
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IAaaaRecord[] AaaaRecord { get; set; }
        /// <summary>The list of CAA records in the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of CAA records in the record set.",
        SerializedName = @"caaRecords",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ICaaRecord) })]
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ICaaRecord[] CaaRecord { get; set; }
        /// <summary>The canonical name for this CNAME record.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The canonical name for this CNAME record.",
        SerializedName = @"cname",
        PossibleTypes = new [] { typeof(string) })]
        string CnameRecordCname { get; set; }
        /// <summary>The list of DS records in the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of DS records in the record set.",
        SerializedName = @"DSRecords",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IDsRecord) })]
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IDsRecord[] DsRecord { get; set; }
        /// <summary>Fully qualified domain name of the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Fully qualified domain name of the record set.",
        SerializedName = @"fqdn",
        PossibleTypes = new [] { typeof(string) })]
        string Fqdn { get;  }
        /// <summary>The metadata attached to the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The metadata attached to the record set.",
        SerializedName = @"metadata",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IRecordSetPropertiesMetadata) })]
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IRecordSetPropertiesMetadata Metadata { get; set; }
        /// <summary>The list of MX records in the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of MX records in the record set.",
        SerializedName = @"MXRecords",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IMxRecord) })]
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IMxRecord[] MxRecord { get; set; }
        /// <summary>The list of NAPTR records in the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of NAPTR records in the record set.",
        SerializedName = @"NAPTRRecords",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.INaptrRecord) })]
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.INaptrRecord[] NaptrRecord { get; set; }
        /// <summary>The list of NS records in the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of NS records in the record set.",
        SerializedName = @"NSRecords",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.INsRecord) })]
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.INsRecord[] NsRecord { get; set; }
        /// <summary>provisioning State of the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"provisioning State of the record set.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get;  }
        /// <summary>The list of PTR records in the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of PTR records in the record set.",
        SerializedName = @"PTRRecords",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IPtrRecord) })]
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IPtrRecord[] PtrRecord { get; set; }
        /// <summary>The email contact for this SOA record.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The email contact for this SOA record.",
        SerializedName = @"email",
        PossibleTypes = new [] { typeof(string) })]
        string SoaRecordEmail { get; set; }
        /// <summary>The expire time for this SOA record.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The expire time for this SOA record.",
        SerializedName = @"expireTime",
        PossibleTypes = new [] { typeof(long) })]
        long? SoaRecordExpireTime { get; set; }
        /// <summary>The domain name of the authoritative name server for this SOA record.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The domain name of the authoritative name server for this SOA record.",
        SerializedName = @"host",
        PossibleTypes = new [] { typeof(string) })]
        string SoaRecordHost { get; set; }
        /// <summary>
        /// The minimum value for this SOA record. By convention this is used to determine the negative caching duration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The minimum value for this SOA record. By convention this is used to determine the negative caching duration.",
        SerializedName = @"minimumTTL",
        PossibleTypes = new [] { typeof(long) })]
        long? SoaRecordMinimumTtl { get; set; }
        /// <summary>The refresh value for this SOA record.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The refresh value for this SOA record.",
        SerializedName = @"refreshTime",
        PossibleTypes = new [] { typeof(long) })]
        long? SoaRecordRefreshTime { get; set; }
        /// <summary>The retry time for this SOA record.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The retry time for this SOA record.",
        SerializedName = @"retryTime",
        PossibleTypes = new [] { typeof(long) })]
        long? SoaRecordRetryTime { get; set; }
        /// <summary>The serial number for this SOA record.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The serial number for this SOA record.",
        SerializedName = @"serialNumber",
        PossibleTypes = new [] { typeof(long) })]
        long? SoaRecordSerialNumber { get; set; }
        /// <summary>The list of SRV records in the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of SRV records in the record set.",
        SerializedName = @"SRVRecords",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISrvRecord) })]
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISrvRecord[] SrvRecord { get; set; }
        /// <summary>Resource Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource Id.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string TargetResourceId { get; set; }
        /// <summary>The list of TLSA records in the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of TLSA records in the record set.",
        SerializedName = @"TLSARecords",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ITlsaRecord) })]
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ITlsaRecord[] TlsaRecord { get; set; }
        /// <summary>The TTL (time-to-live) of the records in the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The TTL (time-to-live) of the records in the record set.",
        SerializedName = @"TTL",
        PossibleTypes = new [] { typeof(long) })]
        long? Ttl { get; set; }
        /// <summary>The list of TXT records in the record set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of TXT records in the record set.",
        SerializedName = @"TXTRecords",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ITxtRecord) })]
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ITxtRecord[] TxtRecord { get; set; }

    }
    /// Represents the properties of the records in the record set.
    internal partial interface IRecordSetPropertiesInternal

    {
        /// <summary>The list of A records in the record set.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IARecord[] ARecord { get; set; }
        /// <summary>The list of AAAA records in the record set.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IAaaaRecord[] AaaaRecord { get; set; }
        /// <summary>The list of CAA records in the record set.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ICaaRecord[] CaaRecord { get; set; }
        /// <summary>The CNAME record in the record set.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ICnameRecord CnameRecord { get; set; }
        /// <summary>The canonical name for this CNAME record.</summary>
        string CnameRecordCname { get; set; }
        /// <summary>The list of DS records in the record set.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IDsRecord[] DsRecord { get; set; }
        /// <summary>Fully qualified domain name of the record set.</summary>
        string Fqdn { get; set; }
        /// <summary>The metadata attached to the record set.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IRecordSetPropertiesMetadata Metadata { get; set; }
        /// <summary>The list of MX records in the record set.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IMxRecord[] MxRecord { get; set; }
        /// <summary>The list of NAPTR records in the record set.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.INaptrRecord[] NaptrRecord { get; set; }
        /// <summary>The list of NS records in the record set.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.INsRecord[] NsRecord { get; set; }
        /// <summary>provisioning State of the record set.</summary>
        string ProvisioningState { get; set; }
        /// <summary>The list of PTR records in the record set.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IPtrRecord[] PtrRecord { get; set; }
        /// <summary>The SOA record in the record set.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISoaRecord SoaRecord { get; set; }
        /// <summary>The email contact for this SOA record.</summary>
        string SoaRecordEmail { get; set; }
        /// <summary>The expire time for this SOA record.</summary>
        long? SoaRecordExpireTime { get; set; }
        /// <summary>The domain name of the authoritative name server for this SOA record.</summary>
        string SoaRecordHost { get; set; }
        /// <summary>
        /// The minimum value for this SOA record. By convention this is used to determine the negative caching duration.
        /// </summary>
        long? SoaRecordMinimumTtl { get; set; }
        /// <summary>The refresh value for this SOA record.</summary>
        long? SoaRecordRefreshTime { get; set; }
        /// <summary>The retry time for this SOA record.</summary>
        long? SoaRecordRetryTime { get; set; }
        /// <summary>The serial number for this SOA record.</summary>
        long? SoaRecordSerialNumber { get; set; }
        /// <summary>The list of SRV records in the record set.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISrvRecord[] SrvRecord { get; set; }
        /// <summary>A reference to an azure resource from where the dns resource value is taken.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISubResource TargetResource { get; set; }
        /// <summary>Resource Id.</summary>
        string TargetResourceId { get; set; }
        /// <summary>The list of TLSA records in the record set.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ITlsaRecord[] TlsaRecord { get; set; }
        /// <summary>The TTL (time-to-live) of the records in the record set.</summary>
        long? Ttl { get; set; }
        /// <summary>The list of TXT records in the record set.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ITxtRecord[] TxtRecord { get; set; }

    }
}