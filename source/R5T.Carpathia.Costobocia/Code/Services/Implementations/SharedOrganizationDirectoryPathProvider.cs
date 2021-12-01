using System;
using System.Threading.Tasks;

using R5T.Lombardy;

using R5T.T0064;

using IOrganizationalDirectoryPathProvider = R5T.Costobocia.IOrganizationDirectoryPathProvider;


namespace R5T.Carpathia.Costobocia
{
    [ServiceImplementationMarker]
    public class SharedOrganizationDirectoryPathProvider : ISharedOrganizationDirectoryPathProvider, IServiceImplementation
    {
        private IOrganizationalDirectoryPathProvider OrganizationalDirectoryPathProvider { get; }
        private ISharedDirectoryNameProvider SharedDirectoryNameProvider { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public SharedOrganizationDirectoryPathProvider(
            IOrganizationalDirectoryPathProvider organizationalDirectoryPathProvider,
            ISharedDirectoryNameProvider sharedDirectoryNameProvider,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.OrganizationalDirectoryPathProvider = organizationalDirectoryPathProvider;
            this.SharedDirectoryNameProvider = sharedDirectoryNameProvider;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public async Task<string> GetOrganizationDirectoryPath()
        {
            var gettingOrganizationalDirectoryPath = this.OrganizationalDirectoryPathProvider.GetOrganizationDirectoryPath();
            var gettingSharedDirectoryName = this.SharedDirectoryNameProvider.GetSharedDirectoryName();

            var organizationalDirectoryPath = await gettingOrganizationalDirectoryPath;
            var sharedDirectoryName = await gettingSharedDirectoryName;

            var sharedOrganizationDirectoryPath = this.StringlyTypedPathOperator.GetDirectoryPath(organizationalDirectoryPath, sharedDirectoryName);
            return sharedOrganizationDirectoryPath;
        }
    }
}
