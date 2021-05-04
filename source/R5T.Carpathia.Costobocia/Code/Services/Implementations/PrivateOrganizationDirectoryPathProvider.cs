using System;
using System.Threading.Tasks;

using IOrganizationalDirectoryPathProvider = R5T.Costobocia.IOrganizationDirectoryPathProvider;


namespace R5T.Carpathia.Costobocia
{
    public class PrivateOrganizationDirectoryPathProvider : IPrivateOrganizationDirectoryPathProvider
    {
        private IOrganizationalDirectoryPathProvider OrganizationalDirectoryPathProvider { get; }


        public PrivateOrganizationDirectoryPathProvider(
            IOrganizationalDirectoryPathProvider organizationalDirectoryPathProvider)
        {
            this.OrganizationalDirectoryPathProvider = organizationalDirectoryPathProvider;
        }

        public Task<string> GetOrganizationDirectoryPath()
        {
            // The private directory is just the plain organization directory (the shared directory is /Shared).
            return this.OrganizationalDirectoryPathProvider.GetOrganizationDirectoryPath();
        }
    }
}
