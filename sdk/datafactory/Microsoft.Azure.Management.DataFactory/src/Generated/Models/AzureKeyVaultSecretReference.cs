// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Azure Key Vault secret reference.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureKeyVaultSecret")]
    public partial class AzureKeyVaultSecretReference : SecretBase
    {
        /// <summary>
        /// Initializes a new instance of the AzureKeyVaultSecretReference
        /// class.
        /// </summary>
        public AzureKeyVaultSecretReference()
        {
            Store = new LinkedServiceReference();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureKeyVaultSecretReference
        /// class.
        /// </summary>
        /// <param name="store">The Azure Key Vault linked service
        /// reference.</param>
        /// <param name="secretName">The name of the secret in Azure Key Vault.
        /// Type: string (or Expression with resultType string).</param>
        /// <param name="secretVersion">The version of the secret in Azure Key
        /// Vault. The default value is the latest version of the secret. Type:
        /// string (or Expression with resultType string).</param>
        public AzureKeyVaultSecretReference(LinkedServiceReference store, object secretName, object secretVersion = default(object))
        {
            Store = store;
            SecretName = secretName;
            SecretVersion = secretVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Azure Key Vault linked service reference.
        /// </summary>
        [JsonProperty(PropertyName = "store")]
        public LinkedServiceReference Store { get; set; }

        /// <summary>
        /// Gets or sets the name of the secret in Azure Key Vault. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "secretName")]
        public object SecretName { get; set; }

        /// <summary>
        /// Gets or sets the version of the secret in Azure Key Vault. The
        /// default value is the latest version of the secret. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "secretVersion")]
        public object SecretVersion { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Store == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Store");
            }
            if (SecretName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SecretName");
            }
            if (Store != null)
            {
                Store.Validate();
            }
        }
    }
}