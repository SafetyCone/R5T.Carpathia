using System;
using System.Threading.Tasks;

using R5T.T0064;

using IOrganizationalDirectoryPathProvider = R5T.Costobocia.IOrganizationDirectoryPathProvider;


namespace R5T.Carpathia.Costobocia
{
    [ServiceImplementationMarker]
    public class PrivateOrganizationDirectoryPathProvider : IPrivateOrganizationDirectoryPathProvider, IServiceImplementation
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
