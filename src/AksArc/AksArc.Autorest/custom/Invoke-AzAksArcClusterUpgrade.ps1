
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
Update the provisioned cluster instance
.Description
Update the provisioned cluster instance
.Example
Invoke-AzAksArcClusterUpgrade -ClusterName azps_test_cluster -ResourceGroupName azps_test_group
.Example
Invoke-AzAksArcClusterUpgrade -ClusterName azps_test_cluster -ResourceGroupName azps_test_group -KubernetesVersion "1.28.5"
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IProvisionedCluster
.Link
https://learn.microsoft.com/powershell/module/az.aksarc/invoke-azaksarcclusterupgrade
#>
function Invoke-AzAksArcClusterUpgrade {
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IProvisionedCluster])]
    [CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
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
    
        [Parameter(ParameterSetName='Upgrade', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Body')]
        [System.String]
        # The version of Kubernetes in use by the provisioned cluster.
        ${KubernetesVersion},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Run the command as a job
        ${AsJob},
    
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
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Run the command asynchronously
        ${NoWait},
    
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
    
        # Upgrade Provisioned Cluster
        if ($PSBoundParameters.ContainsKey("KubernetesVersion"))
        {   
            $Upgrades = Get-AzAksArcClusterUpgrade -ClusterName $ClusterName -ResourceGroupName $ResourceGroupName -SubscriptionId $SubscriptionId
            if (!($upgrades.ControlPlaneProfileUpgrade.KubernetesVersion -contains $KubernetesVersion)) {
                throw "Kubernetes Version $KubernetesVersion is not a valid upgradable version."
            } 
        } else {
            $Upgrades = Get-AzAksArcClusterUpgrade -ClusterName $ClusterName -ResourceGroupName $ResourceGroupName -SubscriptionId $SubscriptionId
            $UpgradeListLength = $upgrades.ControlPlaneProfileUpgrade.KubernetesVersion.Length
            if ($UpgradeListLength -eq 0) {
                Write-Error "Already on latest kubernetes version."
                return
            }
            $LatestUpgrade = $upgrades.ControlPlaneProfileUpgrade[$UpgradeListLength-1].KubernetesVersion
    
            $null = $PSBoundParameters.Add("KubernetesVersion", $LatestUpgrade)
        }
        
        Az.AksArc.internal\Update-AzAksArcCluster @PSBoundParameters
    }
    }