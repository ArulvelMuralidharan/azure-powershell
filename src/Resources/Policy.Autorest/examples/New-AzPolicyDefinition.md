### Example 1: Create a policy definition by using a policy file

```powershell
{
   "if": {
      "field": "location",
      "notIn": ["eastus", "westus", "centralus"]
   },
   "then": {
      "effect": "audit"
   }
}

New-AzPolicyDefinition -Name 'LocationDefinition' -Policy C:\LocationPolicy.json
```

This command creates a policy definition named LocationDefinition that contains the policy rule specified in C:\LocationPolicy.json. Example content for the LocationPolicy.json file is provided above. Three file content formats are supported:
1. Policy rule only (example above).
2. Policy properties object. This format is displayed in the portal when editing a policy definition and may include parameters.
3. Full policy object. This format is generated by the Azure Policy export function and may include parameters.

Note: Values provided on the command line (e.g. parameters, metadata) override corresponding values present in the file.

### Example 2: Create a parameterized policy definition using inline parameters

```powershell
{
   "if": {
      "field": "location",
      "notIn": "[parameters('listOfAllowedLocations')]"
   },
   "then": {
      "effect": "audit"
   }
}
New-AzPolicyDefinition -Name 'LocationDefinition' -Policy C:\LocationPolicy.json -Parameter '{ "listOfAllowedLocations": { "type": "array" } }'
```

This command creates a policy definition named LocationDefinition that contains the policy rule specified in C:\LocationPolicy.json. The parameter definition for the policy rule is provided inline.

### Example 3: Create a policy definition inline in a management group
```powershell
New-AzPolicyDefinition -Name 'VMPolicyDefinition' -ManagementGroupName Dept42 -DisplayName 'Virtual Machine policy definition' -Policy '{"if":{"field":"type","equals":"Microsoft.Compute/virtualMachines"},"then":{"effect":"deny"}}'
```

This command creates a policy definition named VMPolicyDefinition in management group Dept42.
The command specifies the policy as a string in valid JSON format.

### Example 4: Create a policy definition inline with metadata
```powershell
New-AzPolicyDefinition -Name 'VMPolicyDefinition' -Metadata '{"category":"Virtual Machine"}' -Policy '{"if":{"field":"type","equals":"Microsoft.Compute/virtualMachines"},"then":{"effect":"deny"}}' | Format-List
```

This command creates a policy definition named VMPolicyDefinition with metadata indicating its category is "Virtual Machine".
The command specifies the policy as a string in valid JSON format.

### Example 5: Create a policy definition inline with mode
```powershell
New-AzPolicyDefinition -Name 'TagsPolicyDefinition' -Policy '{"if":{"value":"[less(length(field(''tags'')), 3)]","equals":true},"then":{"effect":"deny"}}' -Mode Indexed
```

This command creates a policy definition named TagsPolicyDefinition with mode "Indexed" indicating the policy should be evaluated only for resource types that support tags and location.
