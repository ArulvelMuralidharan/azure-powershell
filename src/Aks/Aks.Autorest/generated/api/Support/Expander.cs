// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Aks.Support
{

    /// <summary>
    /// If not specified, the default is 'random'. See [expanders](https://github.com/kubernetes/autoscaler/blob/master/cluster-autoscaler/FAQ.md#what-are-expanders)
    /// for more information.
    /// </summary>
    public partial struct Expander :
        System.IEquatable<Expander>
    {
        /// <summary>
        /// Selects the node group that will have the least idle CPU (if tied, unused memory) after scale-up. This is useful when
        /// you have different classes of nodes, for example, high CPU or high memory nodes, and only want to expand those when there
        /// are pending pods that need a lot of those resources.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.Expander LeastWaste = @"least-waste";

        /// <summary>
        /// Selects the node group that would be able to schedule the most pods when scaling up. This is useful when you are using
        /// nodeSelector to make sure certain pods land on certain nodes. Note that this won't cause the autoscaler to select bigger
        /// nodes vs. smaller, as it can add multiple smaller nodes at once.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.Expander MostPods = @"most-pods";

        /// <summary>
        /// Selects the node group that has the highest priority assigned by the user. It's configuration is described in more details
        /// [here](https://github.com/kubernetes/autoscaler/blob/master/cluster-autoscaler/expander/priority/readme.md).
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.Expander Priority = @"priority";

        /// <summary>
        /// Used when you don't have a particular need for the node groups to scale differently.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.Expander Random = @"random";

        /// <summary>the value for an instance of the <see cref="Expander" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to Expander</summary>
        /// <param name="value">the value to convert to an instance of <see cref="Expander" />.</param>
        internal static object CreateFrom(object value)
        {
            return new Expander(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type Expander</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.Expander e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type Expander (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is Expander && Equals((Expander)obj);
        }

        /// <summary>Creates an instance of the <see cref="Expander"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private Expander(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns hashCode for enum Expander</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for Expander</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to Expander</summary>
        /// <param name="value">the value to convert to an instance of <see cref="Expander" />.</param>

        public static implicit operator Expander(string value)
        {
            return new Expander(value);
        }

        /// <summary>Implicit operator to convert Expander to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="Expander" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.Expander e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum Expander</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.Expander e1, Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.Expander e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum Expander</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.Expander e1, Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.Expander e2)
        {
            return e2.Equals(e1);
        }
    }
}