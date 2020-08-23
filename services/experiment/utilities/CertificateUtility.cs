using System.Security.Cryptography.X509Certificates;

namespace experiment.Utilities
{
    public class CertificateUtility
    {
        /// <summary>
        /// Given a findtype and findvalue, retrieve a certificate from the CurrentUser/Personal store
        /// </summary>
        /// <typeparam name="T">Type for FindValue</typeparam>
        /// <param name="findType">X509FindType</param>
        /// <param name="findValue">string/bool/etc.</param>
        /// <param name="findValidOnly">If true, only find valid certificates</param>
        /// <returns>First certificate found matching the criteria or null if not found</returns>
        private static X509Certificate2 GetCertificateBy<T>(X509FindType findType, T findValue, bool findValidOnly = false)
        {
            using (var certStore = new X509Store(StoreName.My, StoreLocation.CurrentUser))
            {
                certStore.Open(OpenFlags.ReadOnly);

                var certs = certStore.Certificates.Find(findType, findValue, findValidOnly);
                return certs.Count > 0 ? certs[0] : null;
            }
        }

        /// <summary>
        /// Given a certificate's SubjectDistinguishedName, retrieve a certificate from the CurrentUser/Personal store
        /// </summary>
        /// <param name="subject">Certificate's SubjectDistinguishedName</param>
        /// <returns>First certificate found matching the criteria or null if not found</returns>
        public static X509Certificate2 GetBySubject(string subject)
        {
            return GetCertificateBy(X509FindType.FindBySubjectDistinguishedName, subject);
        }
    }
}