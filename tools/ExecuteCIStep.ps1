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
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost If the code
# is regenerated.
# ----------------------------------------------------------------------------------

# Usage: 1. This script can be called by build.proj used in CI pipeline
#        2. Can be used to do static analysis in local env. Such as: .\tools\ExecuteCIStep.ps1 -StaticAnalysisSignature -TargetModule "Accounts;Compute"
Param(
    [Switch]
    $Build,

    [String]
    $BuildAction='build',

    [Switch]
    $GenerateDocumentationFile,

    [Switch]
    $Test,

    [Switch]
    $StaticAnalysisBreakingChange,

    [Switch]
    $StaticAnalysisDependency,
    
    [Switch]
    $StaticAnalysisSignature,
    
    [Switch]
    $StaticAnalysisHelp,

    [String]
    $RepoArtifacts='artifacts',

    [String]
    $Configuration='Debug',

    [String]
    $TestFramework='netcoreapp2.2',

    [String]
    $TestOutputDirectory='artifacts/TestResults',

    [String]
    $StaticAnalysisOutputDirectory='artifacts/StaticAnalysisResults',

    [String]
    $TargetModule
)
$ErrorActionPreference = 'Stop'

If ($Build)
{
    $LogFile = "$RepoArtifacts/Build.Log"
    If ($GenerateDocumentationFile)
    {
        dotnet $BuildAction $RepoArtifacts/Azure.PowerShell.sln -c $Configuration -fl "/flp1:logFile=$LogFile;verbosity=quiet"
    }
    Else
    {
        dotnet $BuildAction $RepoArtifacts/Azure.PowerShell.sln -c $Configuration -p:GenerateDocumentationFile=false -fl "/flp1:logFile=$LogFile;verbosity=quiet"
    }
    If (Test-Path -Path "$RepoArtifacts/PipelineResult")
    {
        $LogContent = Get-Content $LogFile
        $BuildResultArray = @()
        ForEach ($Line In $LogContent)
        {
            $Position, $ErrorOrWarningType, $Detail = $Line.Split(": ")
            $Detail = Join-String -Separator ": " -InputObject $Detail
            If ($Position.Contains("src"))
            {
                $ModuleName = "Az." + $Position.Replace("\", "/").Split("src/")[1].Split('/')[0]
            }
            Else
            {
                $ModuleName = "dotnet"
            }
            $Type, $Code = $ErrorOrWarningType.Split(" ")
            $BuildResultArray += @{
                "Position" = $Position;
                "Module" = $ModuleName;
                "Type" = $Type;
                "Code" = $Code;
                "Detail" = $Detail
            }
        }

        #Region produce result.json for GitHub bot to comsume
        If ($IsWindows)
        {
            $OS = "Windows"
        }
        ElseIf ($IsLinux)
        {
            $OS = "Linux"
        }
        ElseIf ($IsMacOS)
        {
            $OS = "MacOS"
        }
        Else
        {
            $OS = "Others"
        }
        $Platform = "$($Env:PowerShellPlatform) - $OS"
        $Template = Get-Content "$PSScriptRoot/PipelineResultTemplate.json" | ConvertFrom-Json
        $ModuleBuildInfoList = @()
        $CIPlan = Get-Content "$RepoArtifacts/PipelineResult/CIPlan.json" | ConvertFrom-Json
        ForEach ($ModuleName In $CIPlan.build)
        {
            $BuildResultOfModule = $BuildResultArray | Where-Object { $_.Module -Eq "Az.$ModuleName" }
            If ($BuildResultOfModule.Length -Eq 0)
            {
                $ModuleBuildInfoList += @{
                    Module = "Az.$ModuleName";
                    Status = "Success";
                    Content = "";
                }
            }
            Else
            {
                $Content = "|Type|Code|Position|Detail|`n|---|---|---|---|`n"
                ForEach ($BuildResult In $BuildResultOfModule)
                {
                    If ($BuildResult.Type -Eq "Error")
                    {
                        $ErrorTypeEmoji = "❌"
                    }
                    ElseIf ($BuildResult.Type -Eq "Warning")
                    {
                        $ErrorTypeEmoji = "⚠️"
                    }
                    $Content += "|$ErrorTypeEmoji|$($BuildResult.Code)|$($BuildResult.Position)|$($BuildResult.Detail)|`n"
                }
                $ModuleBuildInfoList += @{
                    Module = "Az.$ModuleName";
                    Status = "Failed";
                    Content = $Content;
                }
            }
        }
        $BuildDetail = @{
            Platform = $Platform;
            Modules = $ModuleBuildInfoList;
        }
        If ($BuildResultArray.Length -Ne 0)
        {
            $BuildDetail.Status = "Failed"
            $DependencyStepStatus = "Canceled"
        }
        Else
        {
            $BuildDetail.Status = "Success"
            $DependencyStepStatus = "Running"
        }
        $Template.Build.Details += $BuildDetail

        $DependencyStepList = $Template | Get-Member -MemberType NoteProperty | Select-Object -ExpandProperty Name | Where-Object { $_ -Ne "build" }

        ForEach ($DependencyStep In $DependencyStepList)
        {
            $ModuleInfoList = @()
            ForEach ($ModuleName In $CIPlan.$DependencyStep)
            {
                $ModuleInfoList += @{
                    Module = "Az.$ModuleName";
                    Status = $DependencyStepStatus;
                    Content = "";
                }
            }
            $Detail = @{
                Status = $DependencyStepStatus;
                Modules = $ModuleInfoList;
            }
            $Template.$DependencyStep.Details += $Detail
        }

        ConvertTo-Json -Depth 10 -InputObject $Template | Out-File -FilePath "$RepoArtifacts/PipelineResult/PipelineResult.json"
        #EndRegion
    }
    Return
}

If (-Not $PSBoundParameters.ContainsKey("TargetModule"))
{
    $CIPlan = Get-Content $RepoArtifacts/PipelineResult/CIPlan.json | ConvertFrom-Json
}

If ($Test -And $CIPlan.test.Length -Ne 0)
{
    dotnet test $RepoArtifacts/Azure.PowerShell.sln --filter "AcceptanceType=CheckIn&RunType!=DesktopOnly" --configuration $Configuration --framework $TestFramework --logger trx --results-directory $TestOutputDirectory
    Return
}

If ($StaticAnalysisBreakingChange)
{
    If ($PSBoundParameters.ContainsKey("TargetModule"))
    {
        $BreakingChangeCheckModuleList = $TargetModule
    }
    Else
    {
        $BreakingChangeCheckModuleList = Join-String -Separator ';' -InputObject $CIPlan.'breaking-change'
    }
    If ("" -Ne $BreakingChangeCheckModuleList)
    {
        dotnet $RepoArtifacts/StaticAnalysis/StaticAnalysis.Netcore.dll -p $RepoArtifacts/$Configuration -r $StaticAnalysisOutputDirectory --analyzers breaking-change -u -m $BreakingChangeCheckModuleList
    }
    Return
}

If ($StaticAnalysisDependency)
{
    If ($PSBoundParameters.ContainsKey("TargetModule"))
    {
        $DependencyCheckModuleList = $TargetModule
    }
    Else
    {
        $DependencyCheckModuleList = Join-String -Separator ';' -InputObject $CIPlan.dependency
    }
    If ("" -Ne $DependencyCheckModuleList)
    {
        dotnet $RepoArtifacts/StaticAnalysis/StaticAnalysis.Netcore.dll -p $RepoArtifacts/$Configuration -r $StaticAnalysisOutputDirectory --analyzers dependency -u -m $DependencyCheckModuleList
    }
    Return
}

If ($StaticAnalysisSignature)
{
    If ($PSBoundParameters.ContainsKey("TargetModule"))
    {
        $SignatureCheckModuleList = $TargetModule
    }
    Else
    {
        $SignatureCheckModuleList = Join-String -Separator ';' -InputObject $CIPlan.signature
    }
    If ("" -Ne $SignatureCheckModuleList)
    {
        dotnet $RepoArtifacts/StaticAnalysis/StaticAnalysis.Netcore.dll -p $RepoArtifacts/$Configuration -r $StaticAnalysisOutputDirectory --analyzers signature -u -m $SignatureCheckModuleList
    }
    Return
}

If ($StaticAnalysisHelp)
{
    If ($PSBoundParameters.ContainsKey("TargetModule"))
    {
        $HelpCheckModuleList = $TargetModule
    }
    Else
    {
        $HelpCheckModuleList = Join-String -Separator ';' -InputObject $CIPlan.help
    }
    If ("" -Ne $HelpCheckModuleList)
    {
        dotnet $RepoArtifacts/StaticAnalysis/StaticAnalysis.Netcore.dll -p $RepoArtifacts/$Configuration -r $StaticAnalysisOutputDirectory --analyzers help -u -m $HelpCheckModuleList
    }
    Return
}