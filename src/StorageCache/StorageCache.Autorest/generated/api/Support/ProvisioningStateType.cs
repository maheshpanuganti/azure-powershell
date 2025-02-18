// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Support
{

    /// <summary>
    /// ARM provisioning state, see https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/Addendum.md#provisioningstate-property
    /// </summary>
    public partial struct ProvisioningStateType :
        System.IEquatable<ProvisioningStateType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Support.ProvisioningStateType Canceled = @"Canceled";

        public static Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Support.ProvisioningStateType Creating = @"Creating";

        public static Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Support.ProvisioningStateType Deleting = @"Deleting";

        public static Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Support.ProvisioningStateType Failed = @"Failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Support.ProvisioningStateType Succeeded = @"Succeeded";

        public static Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Support.ProvisioningStateType Updating = @"Updating";

        /// <summary>the value for an instance of the <see cref="ProvisioningStateType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ProvisioningStateType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ProvisioningStateType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ProvisioningStateType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ProvisioningStateType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Support.ProvisioningStateType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ProvisioningStateType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ProvisioningStateType && Equals((ProvisioningStateType)obj);
        }

        /// <summary>Returns hashCode for enum ProvisioningStateType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="ProvisioningStateType"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ProvisioningStateType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for ProvisioningStateType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ProvisioningStateType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ProvisioningStateType" />.</param>

        public static implicit operator ProvisioningStateType(string value)
        {
            return new ProvisioningStateType(value);
        }

        /// <summary>Implicit operator to convert ProvisioningStateType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ProvisioningStateType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Support.ProvisioningStateType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ProvisioningStateType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Support.ProvisioningStateType e1, Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Support.ProvisioningStateType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ProvisioningStateType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Support.ProvisioningStateType e1, Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Support.ProvisioningStateType e2)
        {
            return e2.Equals(e1);
        }
    }
}