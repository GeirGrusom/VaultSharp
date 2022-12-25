﻿using System.Threading.Tasks;
using VaultSharp.V1.AuthMethods.AliCloud;
using VaultSharp.V1.AuthMethods.AppRole;
using VaultSharp.V1.AuthMethods.AWS;
using VaultSharp.V1.AuthMethods.Azure;
using VaultSharp.V1.AuthMethods.Cert;
using VaultSharp.V1.AuthMethods.CloudFoundry;
using VaultSharp.V1.AuthMethods.GitHub;
using VaultSharp.V1.AuthMethods.GoogleCloud;
using VaultSharp.V1.AuthMethods.JWT;
using VaultSharp.V1.AuthMethods.Kerberos;
using VaultSharp.V1.AuthMethods.Kubernetes;
using VaultSharp.V1.AuthMethods.LDAP;
using VaultSharp.V1.AuthMethods.OCI;
using VaultSharp.V1.AuthMethods.Okta;
using VaultSharp.V1.AuthMethods.RADIUS;
using VaultSharp.V1.AuthMethods.Token;
using VaultSharp.V1.AuthMethods.UserPass;

namespace VaultSharp.V1.AuthMethods
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAuthMethod
    {
        /// <summary>
        /// The AliCloud Auth method.
        /// </summary>
        IAliCloudAuthMethod AliCloud { get; }

        /// <summary>
        /// 
        /// </summary>
        IAppRoleAuthMethod AppRole { get; }

        /// <summary>
        /// 
        /// </summary>
        IAWSAuthMethod AWS { get; }

        /// <summary>
        /// 
        /// </summary>
        IAzureAuthMethod Azure { get; }

        /// <summary>
        /// 
        /// </summary>
        ICloudFoundryAuthMethod CloudFoundry { get; }

        /// <summary>
        /// Hmm.
        /// </summary>
        IGitHubAuthMethod GitHub { get; }

        /// <summary>
        /// 
        /// </summary>
        IGoogleCloudAuthMethod GoogleCloud { get; }

        IJWTAuthMethod JWT { get; }

        /// <summary>
        /// 
        /// </summary>
        IKerberosAuthMethod Kerberos { get; }

        /// <summary>
        /// 
        /// </summary>
        IKubernetesAuthMethod Kubernetes { get; }

        /// <summary>
        /// 
        /// </summary>
        ILDAPAuthMethod LDAP { get; }

        /// <summary>
        /// 
        /// </summary>
        IOCIAuthMethod OCI { get; }

        /// <summary>
        /// 
        /// </summary>
        IOktaAuthMethod Okta { get; }


        /// <summary>
        /// 
        /// </summary>
        IRADIUSAuthMethod RADIUS { get; }


        /// <summary>
        /// 
        /// </summary>
        ICertAuthMethod Cert { get; }


        /// <summary>
        /// 
        /// </summary>
        ITokenAuthMethod Token { get; }

        /// <summary>
        /// 
        /// </summary>
        IUserPassAuthMethod UserPass { get; }

        /// <summary>
        /// This will make VaultSharp fetch the vault token again before the new operation
        /// </summary>
        void ResetVaultToken();

        /// <summary>
        /// Performs immediate login to uncover login issues faster.
        /// Cannot be used for Token Authentication, since you already have a token.
        /// </summary>
        /// <returns>Nothing</returns>
        Task PerformImmediateLogin();
    }
}