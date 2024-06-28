
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Updates a workspace.
.Description
Updates a workspace.
.Example
Get-AzDatabricksWorkspace -ResourceGroupName azps_test_gp_db -Name azps-databricks-workspace-t1 | Update-AzDatabricksWorkspace -Tag @{"key"="value"}
.Example
Update-AzDatabricksWorkspace -ResourceGroupName azps_test_gp_db -Name azps-databricks-workspace-t2 -PrepareEncryption
$updWsp = Get-AzDatabricksWorkspace -ResourceGroupName azps_test_gp_db -Name azps-databricks-workspace-t2
Set-AzKeyVaultAccessPolicy -VaultName azps-keyvault -ObjectId $updWsp.StorageAccountIdentityPrincipalId -PermissionsToKeys wrapkey,unwrapkey,get
Update-AzDatabricksWorkspace -ResourceGroupName azps_test_gp_db -Name azps-databricks-workspace-t2 -EncryptionKeySource 'Microsoft.KeyVault' -EncryptionKeyVaultUri https://azps-keyvault.vault.azure.net/ -EncryptionKeyName azps-k1 -EncryptionKeyVersion a563a8021cba47109d93bd6d690621a7
.Example
Update-AzDatabricksWorkspace -ResourceGroupName azps_test_gp_db -Name azps-databricks-workspace-t3 -EncryptionKeySource 'Default'
.Example
Update-AzDatabricksWorkspace -ResourceGroupName azps_test_gp_db -Name azps-databricks-workspace-t2 -RequiredNsgRule 'AllRules'

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.IDatabricksIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20240501.IWorkspace
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IDatabricksIdentity>: Identity Parameter
  [ConnectorName <String>]: The name of the azure databricks accessConnector.
  [GroupId <String>]: The name of the private link resource
  [Id <String>]: Resource identity path
  [PeeringName <String>]: The name of the workspace vNet peering.
  [PrivateEndpointConnectionName <String>]: The name of the private endpoint connection
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SubscriptionId <String>]: The ID of the target subscription.
  [WorkspaceName <String>]: The name of the workspace.
.Link
https://learn.microsoft.com/powershell/module/az.databricks/update-azdatabricksworkspace
#>
function Update-AzDatabricksWorkspace {
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20240501.IWorkspace])]
    [CmdletBinding(DefaultParameterSetName = 'UpdateExpanded', PositionalBinding = $false, SupportsShouldProcess, ConfirmImpact = 'Medium')]
    param(
        [Parameter(ParameterSetName = 'UpdateExpanded', Mandatory, HelpMessage = "The name of the workspace.")]
        [Alias('WorkspaceName')]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Path')]
        [System.String]
        # The name of the workspace.
        ${Name},

        [Parameter(ParameterSetName = 'UpdateExpanded', Mandatory, HelpMessage = "The name of the resource group. The name is case insensitive.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Path')]
        [System.String]
        # The name of the resource group.
        # The name is case insensitive.
        ${ResourceGroupName},

        [Parameter(ParameterSetName = 'UpdateExpanded', HelpMessage = "The ID of the target subscription.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.DefaultInfo(Script = '(Get-AzContext).Subscription.Id')]
        [System.String]
        # The ID of the target subscription.
        ${SubscriptionId},

        [Parameter(ParameterSetName = 'UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline, HelpMessage = "Identity parameter. To construct, see NOTES section for INPUTOBJECT properties and create a hash table.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.IDatabricksIdentity]
        # Identity Parameter
        # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
        ${InputObject},

        [Parameter(HelpMessage = "Prepare the workspace for encryption. Enables the Managed Identity for managed storage account.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
        [System.Management.Automation.SwitchParameter]
        # Prepare the workspace for encryption. Enables the Managed Identity for managed storage account.
        ${PrepareEncryption},

        [Parameter(HelpMessage = "The encryption keySource (provider). Possible values (case-insensitive): Default, Microsoft.Keyvault")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.KeySource])]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.KeySource]
        # The encryption keySource (provider).
        # Possible values (case-insensitive): Default, Microsoft.Keyvault
        ${EncryptionKeySource},

        [Parameter(HelpMessage = "The URI (DNS name) of the Key Vault.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
        [System.String]
        # The Uri of KeyVault.
        ${EncryptionKeyVaultUri},

        [Parameter(HelpMessage = "The name of Key Vault key.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
        [System.String]
        # The name of KeyVault key.
        ${EncryptionKeyName},

        [Parameter(HelpMessage = "The version of KeyVault key.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
        [System.String]
        # The version of KeyVault key.
        ${EncryptionKeyVersion},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
        [System.String]
        # The name of KeyVault key.
        ${KeyVaultKeyName},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
        [System.String]
        # The version of KeyVault key.
        ${KeyVaultKeyVersion},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
        [System.String]
        # The Uri of KeyVault.
        ${KeyVaultUri},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
        [System.String]
        # The value which should be used for this field.
        ${AmlWorkspaceId},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
        [System.String]
        # The SKU tier.
        ${SkuTier},

        [Parameter()]
        [AllowEmptyCollection()]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20240501.IWorkspaceProviderAuthorization[]]
        # The workspace provider authorizations.
        # To construct, see NOTES section for AUTHORIZATION properties and create a hash table.
        ${Authorization},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
        [System.String]
        # The name of KeyVault key.
        ${ManagedDiskKeyVaultPropertiesKeyName},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
        [System.String]
        # The URI of KeyVault.
        ${ManagedDiskKeyVaultPropertiesKeyVaultUri},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
        [System.String]
        # The version of KeyVault key.
        ${ManagedDiskKeyVaultPropertiesKeyVersion},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
        [System.Management.Automation.SwitchParameter]
        # Indicate whether the latest key version should be automatically used for Managed Disk Encryption.
        ${ManagedDiskRotationToLatestKeyVersionEnabled},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
        [System.String]
        # The name of KeyVault key.
        ${ManagedServicesKeyVaultPropertiesKeyName},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
        [System.String]
        # The Uri of KeyVault.
        ${ManagedServicesKeyVaultPropertiesKeyVaultUri},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
        [System.String]
        # The version of KeyVault key.
        ${ManagedServicesKeyVaultPropertiesKeyVersion},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
        [System.String]
        # The blob URI where the UI definition file is located.
        ${UiDefinitionUri},

        [Parameter(HelpMessage = "Resource tags.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(PossibleTypes = ([Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20240501.IWorkspaceUpdateTags]))]
        [System.Collections.Hashtable]
        # Resource tags.
        ${Tag},

        [Parameter()]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.RequiredNsgRules])]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.RequiredNsgRules]
        # Gets or sets a value indicating whether data plane (clusters) to control plane communication happen over private endpoint.
        # Supported values are 'AllRules' and 'NoAzureDatabricksRules'.
        # 'NoAzureServiceRules' value is for internal use only.
        ${RequiredNsgRule},

        [Parameter(HelpMessage="The network access type for accessing workspace. Set value to disabled to access workspace only via private link.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PublicNetworkAccess])]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PublicNetworkAccess]
        # The network access type for accessing workspace.
        # Set value to disabled to access workspace only via private link.
        ${PublicNetworkAccess},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
        [System.Management.Automation.SwitchParameter]
        # The value which should be used for this field.
        ${EnableNoPublicIP},

        [Parameter()]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.EnhancedSecurityMonitoringValue])]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.EnhancedSecurityMonitoringValue]
        # Status of Enhanced Security Monitoring feature.
        ${EnhancedSecurityMonitoringValue},

        [Parameter()]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.AutomaticClusterUpdateValue])]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.AutomaticClusterUpdateValue]
        # Status of automated cluster updates feature.
        ${AutomaticClusterUpdateValue},

        [Parameter()]
        [AllowEmptyCollection()]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.ComplianceStandard])]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.ComplianceStandard[]]
        # Compliance standards associated with the workspace.
        ${ComplianceSecurityProfileComplianceStandard},

        [Parameter()]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.ComplianceSecurityProfileValue])]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.ComplianceSecurityProfileValue]
        # Status of Compliance Security Profile feature.
        ${ComplianceSecurityProfileValue},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
        [System.String]
        # The resource ID of Azure Databricks Access Connector Resource.
        ${AccessConnectorId},

        [Parameter()]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.IdentityType])]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.IdentityType]
        # The identity type of the Access Connector Resource.
        ${AccessConnectorIdentityType},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
        [System.String]
        # The resource ID of the User Assigned Identity associated with the Access Connector Resource.
        # This is required for type 'UserAssigned' and not valid for type 'SystemAssigned'.
        ${AccessConnectorUserAssignedIdentityId},

        [Parameter()]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.DefaultStorageFirewall])]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.DefaultStorageFirewall]
        # Gets or Sets Default Storage Firewall configuration information
        ${DefaultStorageFirewall},
        
        [Parameter(HelpMessage = "The credentials, account, tenant, and subscription used for communication with Azure.")]
        [Alias('AzureRMContext', 'AzureCredential')]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Azure')]
        [System.Management.Automation.PSObject]
        # The DefaultProfile parameter is not functional.
        # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
        ${DefaultProfile},

        [Parameter(HelpMessage = "Run the command as a job")]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Run the command as a job
        ${AsJob},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Wait for .NET debugger to attach
        ${Break},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be appended to the front of the pipeline
        ${HttpPipelineAppend},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be prepended to the front of the pipeline
        ${HttpPipelinePrepend},

        [Parameter(HelpMessage = "Run the command asynchronously")]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Run the command asynchronously
        ${NoWait},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Runtime')]
        [System.Uri]
        # The URI for the proxy server to use
        ${Proxy},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Runtime')]
        [System.Management.Automation.PSCredential]
        # Credentials for a proxy server to use for the remote call
        ${ProxyCredential},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Use the default credentials for the proxy
        ${ProxyUseDefaultCredentials}
    )

    process {
        try {
            # 1. GET
            $hasPrepareEncryption = $PSBoundParameters.Remove('PrepareEncryption')
            $hasEncryptionKeySource = $PSBoundParameters.Remove('EncryptionKeySource')
            $hasEncryptionKeyVaultUri = $PSBoundParameters.Remove('EncryptionKeyVaultUri')
            $hasEncryptionKeyName = $PSBoundParameters.Remove('EncryptionKeyName')
            $hasEncryptionKeyVersion = $PSBoundParameters.Remove('EncryptionKeyVersion')
            $hasKeyVaultKeyName = $PSBoundParameters.Remove('KeyVaultKeyName')
            $hasKeyVaultKeyVersion = $PSBoundParameters.Remove('KeyVaultKeyVersion')
            $hasKeyVaultUri = $PSBoundParameters.Remove('KeyVaultUri')
            $hasAmlWorkspaceId = $PSBoundParameters.Remove('AmlWorkspaceId')
            $hasSkuTier = $PSBoundParameters.Remove('SkuTier')
            $hasAuthorization = $PSBoundParameters.Remove('Authorization')
            $hasManagedDiskKeyVaultPropertiesKeyName = $PSBoundParameters.Remove('ManagedDiskKeyVaultPropertiesKeyName')
            $hasManagedDiskKeyVaultPropertiesKeyVaultUri = $PSBoundParameters.Remove('ManagedDiskKeyVaultPropertiesKeyVaultUri')
            $hasManagedDiskKeyVaultPropertiesKeyVersion = $PSBoundParameters.Remove('ManagedDiskKeyVaultPropertiesKeyVersion')
            $hasManagedDiskRotationToLatestKeyVersionEnabled = $PSBoundParameters.Remove('ManagedDiskRotationToLatestKeyVersionEnabled')
            $hasManagedServicesKeyVaultPropertiesKeyName = $PSBoundParameters.Remove('ManagedServicesKeyVaultPropertiesKeyName')
            $hasManagedServicesKeyVaultPropertiesKeyVaultUri = $PSBoundParameters.Remove('ManagedServicesKeyVaultPropertiesKeyVaultUri')
            $hasManagedServicesKeyVaultPropertiesKeyVersion = $PSBoundParameters.Remove('ManagedServicesKeyVaultPropertiesKeyVersion')
            $hasUiDefinitionUri = $PSBoundParameters.Remove('UiDefinitionUri')
            $hasTag = $PSBoundParameters.Remove('Tag')
            $hasRequiredNsgRule = $PSBoundParameters.Remove('RequiredNsgRule')
            $hasEnableNoPublicIP = $PSBoundParameters.Remove('EnableNoPublicIP')
            $hasPublicNetworkAccess = $PSBoundParameters.Remove('PublicNetworkAccess')
            $hasAccessConnectorId = $PSBoundParameters.Remove('AccessConnectorId')
            $hasAccessConnectorIdentityType = $PSBoundParameters.Remove('AccessConnectorIdentityType')
            $hasAccessConnectorUserAssignedIdentityId = $PSBoundParameters.Remove('AccessConnectorUserAssignedIdentityId')
            $hasDefaultStorageFirewall = $PSBoundParameters.Remove('DefaultStorageFirewall')
            $hasEnhancedSecurityMonitoringValue = $PSBoundParameters.Remove('EnhancedSecurityMonitoringValue')
            $hasAutomaticClusterUpdateValue = $PSBoundParameters.Remove('AutomaticClusterUpdateValue')
            $hasComplianceSecurityProfileComplianceStandard = $PSBoundParameters.Remove('ComplianceSecurityProfileComplianceStandard')
            $hasComplianceSecurityProfileValue = $PSBoundParameters.Remove('ComplianceSecurityProfileValue')
            $hasAsJob = $PSBoundParameters.Remove('AsJob')
            $null = $PSBoundParameters.Remove('WhatIf')
            $null = $PSBoundParameters.Remove('Confirm')

            $workspace = Get-AzDatabricksWorkspace @PSBoundParameters

            # 2. PUT
            $null = $PSBoundParameters.Remove('InputObject')
            $null = $PSBoundParameters.Remove('ResourceGroupName')
            $null = $PSBoundParameters.Remove('Name')
            $null = $PSBoundParameters.Remove('SubscriptionId')
            if ($hasPrepareEncryption) {
                $workspace.PrepareEncryption = $PrepareEncryption
            }
            if ($hasEncryptionKeySource) {
                $workspace.EncryptionKeySource = $EncryptionKeySource
            }
            if ($hasEncryptionKeyVaultUri) {
                $workspace.EncryptionKeyVaultUri = $EncryptionKeyVaultUri
            }
            if ($hasEncryptionKeyName) {
                $workspace.EncryptionKeyName = $EncryptionKeyName
            }
            if ($hasEncryptionKeyVersion) {
                $workspace.EncryptionKeyVersion = $EncryptionKeyVersion
            }
            if ($hasKeyVaultKeyName) {
                $workspace.KeyVaultKeyName = $KeyVaultKeyName
            }

            if ($hasKeyVaultKeyVersion) {
                $workspace.KeyVaultKeyVersion = $KeyVaultKeyVersion
            }

            if ($hasKeyVaultUri) {
                $workspace.KeyVaultUri = $KeyVaultUri
            }

            if ($hasAmlWorkspaceId) {
                $workspace.AmlWorkspaceId = $AmlWorkspaceId
            }

            if ($hasSkuTier) {
                $workspace.SkuTier = $SkuTier
            }

            if ($hasTag) {
                $workspace.Tag = $Tag
            }

            if ($hasAuthorization) {
                $workspace.Authorization = $Authorization
            }
            if ($hasManagedDiskKeyVaultPropertiesKeyName) {
                $workspace.ManagedDiskKeyVaultPropertiesKeyName = $ManagedDiskKeyVaultPropertiesKeyName
            }
            if ($hasManagedDiskKeyVaultPropertiesKeyVaultUri) {
                $workspace.ManagedDiskKeyVaultPropertiesKeyVaultUri = $ManagedDiskKeyVaultPropertiesKeyVaultUri
            }
            if ($hasManagedDiskKeyVaultPropertiesKeyVersion) {
                $workspace.ManagedDiskKeyVaultPropertiesKeyVersion = $ManagedDiskKeyVaultPropertiesKeyVersion
            }
            if ($hasManagedDiskRotationToLatestKeyVersionEnabled) {
                $workspace.ManagedDiskRotationToLatestKeyVersionEnabled = $ManagedDiskRotationToLatestKeyVersionEnabled
            }
            if ($hasManagedServicesKeyVaultPropertiesKeyName) {
                $workspace.ManagedServicesKeyVaultPropertiesKeyName = $ManagedServicesKeyVaultPropertiesKeyName
            }
            if ($hasManagedServicesKeyVaultPropertiesKeyVaultUri) {
                $workspace.ManagedServicesKeyVaultPropertiesKeyVaultUri = $ManagedServicesKeyVaultPropertiesKeyVaultUri
            }
            if ($hasManagedServicesKeyVaultPropertiesKeyVersion) {
                $workspace.ManagedServicesKeyVaultPropertiesKeyVersion = $ManagedServicesKeyVaultPropertiesKeyVersion
            }
            if ($hasUiDefinitionUri) {
                $workspace.UiDefinitionUri = $UiDefinitionUri
            }

            if ($hasEnableNoPublicIP) {
                $workspace.EnableNoPublicIP = $EnableNoPublicIP
            }
            if ($hasPublicNetworkAccess) {
                $workspace.PublicNetworkAccess = $PublicNetworkAccess
            }
            if ($hasRequiredNsgRule) {
                $workspace.RequiredNsgRule = $RequiredNsgRule
            }
            if ($hasEnhancedSecurityMonitoringValue)
            {
                $workspace.EnhancedSecurityMonitoringValue = $EnhancedSecurityMonitoringValue
            }
            if ($hasAutomaticClusterUpdateValue)
            {
                $workspace.AutomaticClusterUpdateValue = $AutomaticClusterUpdateValue
            }
            if ($hasComplianceSecurityProfileComplianceStandard)
            {
                $workspace.ComplianceSecurityProfileComplianceStandard = $ComplianceSecurityProfileComplianceStandard
            }
            if ($hasComplianceSecurityProfileValue)
            {
                $workspace.ComplianceSecurityProfileValue = $ComplianceSecurityProfileValue
            }
            if ($hasDefaultStorageFirewall)
            {
                $workspace.DefaultStorageFirewall = $DefaultStorageFirewall
            }
            if ($hasAsJob) {
                $PSBoundParameters.Add('AsJob', $true)
            }

            if ($PSCmdlet.ShouldProcess("Databricks workspace $($workspace.Name)", "Create or update")) {
                Az.Databricks.private\New-AzDatabricksWorkspace_CreateViaIdentity -InputObject $workspace -Parameter $workspace @PSBoundParameters
            }
        }
        catch {
            throw
        }
    }
}