
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
Gets the specified agent pool in the provisioned cluster
.Description
Gets the specified agent pool in the provisioned cluster
.Example
Get-AzAksArcNodepool -ClusterName azps_test_cluster -ResourceGroupName azps_test_group
.Example
Get-AzAksArcNodepool -ClusterName azps_test_cluster -ResourceGroupName azps_test_group -Name azps_test_nodepool1

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IAksArcIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IAgentPool
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IAksArcIdentity>: Identity Parameter
  [AgentPoolName <String>]: Parameter for the name of the agent pool in the provisioned cluster.
  [ConnectedClusterResourceUri <String>]: The fully qualified Azure Resource Manager identifier of the connected cluster resource.
  [CustomLocationResourceUri <String>]: The fully qualified Azure Resource Manager identifier of the custom location resource.
  [Id <String>]: Resource identity path
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SubscriptionId <String>]: The ID of the target subscription. The value must be an UUID.
  [VirtualNetworkName <String>]: Parameter for the name of the virtual network
.Link
https://learn.microsoft.com/powershell/module/az.aksarc/get-azaksarcnodepool
#>
function Get-AzAksArcNodepool {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IAgentPool])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Path')]
    [System.String]
    # The name of the Kubernetes cluster on which get is called.
    ${ClusterName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Path')]
    [System.String]
    # Parameter for the name of the agent pool in the provisioned cluster.
    ${Name},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IAksArcIdentity]
    # Identity Parameter
    ${InputObject},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

process {
    $Scope = GetConnectedClusterResourceURI -SubscriptionId $SubscriptionId -ResourceGroupName $ResourceGroupName -ClusterName $ClusterName
    $null = $PSBoundParameters.Remove("SubscriptionId")
    $null = $PSBoundParameters.Remove("ResourceGroupName")
    $null = $PSBoundParameters.Remove("ClusterName")
    $null = $PSBoundParameters.Add("ConnectedClusterResourceUri", $Scope)
    Az.AksArc.internal\Get-AzAksArcNodepool @PSBoundParameters
} 
}
