using System;

using R5T.Lombardy;

using R5T.T0062;
using R5T.T0063;

using IOrganizationalDirectoryPathProvider = R5T.Costobocia.IOrganizationDirectoryPathProvider;


namespace R5T.Carpathia.Costobocia
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Forwards the <see cref="ISharedOrganizationDirectoryPathProvider"/> service to <see cref="IOrganizationDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IOrganizationDirectoryPathProvider> ForwardToIOrganizationDirectoryPathProviderAction(this IServiceAction _,
            IServiceAction<ISharedOrganizationDirectoryPathProvider> sharedOrganizationDirectoryPathProviderAction)
        {
            var serviceAction = _.New<IOrganizationDirectoryPathProvider>(services => services.ForwardToIOrganizationDirectoryPathProvider(
                sharedOrganizationDirectoryPathProviderAction));

            return serviceAction;
        }

        /// <summary>
        /// Forwards the <see cref="IPrivateOrganizationDirectoryPathProvider"/> service to <see cref="IOrganizationDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IOrganizationDirectoryPathProvider> ForwardToIOrganizationDirectoryPathProviderAction(this IServiceAction _,
            IServiceAction<IPrivateOrganizationDirectoryPathProvider> privateOrganizationDirectoryPathProviderAction)
        {
            var serviceAction = _.New<IOrganizationDirectoryPathProvider>(services => services.ForwardToIOrganizationDirectoryPathProvider(
                privateOrganizationDirectoryPathProviderAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="SharedOrganizationDirectoryPathProvider"/> implementation of <see cref="ISharedOrganizationDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ISharedOrganizationDirectoryPathProvider> AddSharedOrganizationDirectoryPathProviderAction(this IServiceAction _,
            IServiceAction<IOrganizationalDirectoryPathProvider> organizationalDirectoryPathProviderAction,
            IServiceAction<ISharedDirectoryNameProvider> sharedDirectoryNameProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var serviceAction = _.New<ISharedOrganizationDirectoryPathProvider>(services => services.AddSharedOrganizationDirectoryPathProvider(
                organizationalDirectoryPathProviderAction,
                sharedDirectoryNameProviderAction,
                stringlyTypedPathOperatorAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="PrivateOrganizationDirectoryPathProvider"/> implementation of <see cref="IPrivateOrganizationDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IPrivateOrganizationDirectoryPathProvider> AddPrivateOrganizationDirectoryPathProviderAction(this IServiceAction _,
            IServiceAction<IOrganizationalDirectoryPathProvider> organizationalDirectoryPathProviderAction)
        {
            var serviceAction = _.New<IPrivateOrganizationDirectoryPathProvider>(services => services.AddPrivateOrganizationDirectoryPathProvider(
                organizationalDirectoryPathProviderAction));

            return serviceAction;
        }
    }
}
