// ***********************************************************************
// Assembly         : CommonCore
// Author           : John Reasor
// Created          : 06-14-2017
//
// Last Modified By : John Reasor
// Last Modified On : 06-14-2017
// ***********************************************************************
// <copyright file="EncrytAppSettings.cs" company="J&S Software, LLC">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace CommonCore.Encryption.ConfigEncryption
{
    using System;
    using System.Configuration;
    using System.Linq;
    using System.Security;
    using System.Security.Cryptography;
    using System.Text;

    /// <summary>
    /// Class EncrytAppSettings.
    /// </summary>
    internal class EncryptAppSettings
    {
        /// <summary>
        /// The entropy
        /// </summary>
        private static byte[] entropy = Encoding.Unicode.GetBytes("199 197 17 23 31 37 73 89 97 167 137 173 2");

        /// <summary>
        /// Encrypts the string.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.String.</returns>
        internal static string EncryptString(SecureString input)
        {
            byte[] encryptedData = ProtectedData.Protect(
                Encoding.Unicode.GetBytes(ToInsecureString(input)),
                entropy,
                DataProtectionScope.CurrentUser);

            return Convert.ToBase64String(encryptedData);
        }

        /// <summary>
        /// Decrypts the string.
        /// </summary>
        /// <param name="encryptedData">The encrypted data.</param>
        /// <returns>SecureString.</returns>
        internal static SecureString DecryptString(string encryptedData)
        {
            try
            {
                byte[] decryptedData = ProtectedData.Unprotect(
                    Convert.FromBase64String(encryptedData),
                    entropy,
                    DataProtectionScope.CurrentUser);

                return ToSecureString(Encoding.Unicode.GetString(decryptedData));
            }
            catch
            {
                return new SecureString();
            }
        }

        /// <summary>
        /// To the secure string.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>SecureString.</returns>
        internal static SecureString ToSecureString(string input)
        {
            SecureString secure = new SecureString();

            foreach (char c in input)
            {
                secure.AppendChar(c);
            }

            secure.MakeReadOnly();

            return secure;
        }

        /// <summary>
        /// To the insecure string.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.String.</returns>
        internal static string ToInsecureString(SecureString input)
        {
            string returnValue = string.Empty;

            IntPtr ptr = System.Runtime.InteropServices.Marshal.SecureStringToBSTR(input);

            try
            {
                returnValue = System.Runtime.InteropServices.Marshal.PtrToStringBSTR(ptr);
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.ZeroFreeBSTR(ptr);
            }

            return returnValue;
        }

        /// <summary>
        /// Configurations the on load.
        /// </summary>
        /// <param name="connectionName">Name of the connection.</param>
        /// <param name="providerName">Name of the provider.</param>
        /// <param name="connectionString">The connection string.</param>
        internal static void SetConStringOnLoad(string connectionName, string providerName, string connectionString)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (config.ConnectionStrings.ConnectionStrings[connectionName] == null
                || config.ConnectionStrings.ConnectionStrings[connectionName].ConnectionString.Contains("source"))
            {
                var secureString = EncryptAppSettings.ToSecureString(connectionString);
                var encrypted = EncryptAppSettings.EncryptString(secureString);

                config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings()
                {
                    Name = connectionName,
                    ConnectionString = encrypted,
                    ProviderName = providerName
                });

                config.Save(ConfigurationSaveMode.Modified);

                ConfigurationManager.RefreshSection("connectionStrings");
            }
        }

        /// <summary>
        /// Gets the con string un encrypt.
        /// </summary>
        /// <param name="connectionName">Name of the connection.</param>
        /// <returns>System.String.</returns>
        internal static string GetConStringUnEncrypt(string connectionName)
        {
            string conString = string.Empty;

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var conStringEncrypted = config.ConnectionStrings.ConnectionStrings[connectionName].ConnectionString;
            var encrypted = EncryptAppSettings.DecryptString(conStringEncrypted);
            conString = EncryptAppSettings.ToInsecureString(encrypted);

            return conString;
        }
    }
}
