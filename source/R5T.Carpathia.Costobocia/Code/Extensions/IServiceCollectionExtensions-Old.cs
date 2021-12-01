using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Lombardy;

using IOrganizationalDirectoryPathProvider = R5T.Costobocia.IOrganizationDirectoryPathProvider;


namespace R5T.Carpathia.Costobocia
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="PrivateOrganizationDirectoryPathProvider"/> implementation of <see cref="IPrivateOrganizationDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddPrivateOrganizationDirectoryPathProvider_Old(this IServiceCollection services,
            IServiceAction<IOrganizationalDirectoryPathProvider> organizationalDirectoryPathProviderAction)
        {
            services
                .AddSingleton<IPrivateOrganizationDirectoryPathProvider, PrivateOrganizationDirectoryPathProvider>()
                .Run(organizationalDirectoryPathProviderAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="PrivateOrganizationDirectoryPathProvider"/> implementation of <see cref="IPrivateOrganizationDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IPrivateOrganizationDirectoryPathProvider> AddPrivateOrganizationDirectoryPathProviderAction_Old(this IServiceCollection services,
            IServiceAction<IOrganizationalDirectoryPathProvider> organizationalDirectoryPathProviderAction)
        {
            var serviceAction = ServiceAction.New<IPrivateOrganizationDirectoryPathProvider>(() => services.AddPrivateOrganizationDirectoryPathProvider_Old(
                organizationalDirectoryPathProviderAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="SharedOrganizationDirectoryPathProvider"/> implementation of <see cref="ISharedOrganizationDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddSharedOrganizationDirectoryPathProvider_Old(this IServiceCollection services,
            IServiceAction<IOrganizationalDirectoryPathProvider> organizationalDirectoryPathProviderAction,
            IServiceAction<ISharedDirectoryNameProvider> sharedDirectoryNameProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            services
                .AddSingleton<ISharedOrganizationDirectoryPathProvider, SharedOrganizationDirectoryPathProvider>()
                .Run(organizationalDirectoryPathProviderAction)
                .Run(sharedDirectoryNameProviderAction)
                .Run(stringlyTypedPathOperatorAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="SharedOrganizationDirectoryPathProvider"/> implementation of <see cref="ISharedOrganizationDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ISharedOrganizationDirectoryPathProvider> AddSharedOrganizationDirectoryPathProviderAction_Old(this IServiceCollection services,
            IServiceAction<IOrganizationalDirectoryPathProvider> organizationalDirectoryPathProviderAction,
            IServiceAction<ISharedDirectoryNameProvider> sharedDirectoryNameProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var serviceAction = ServiceAction.New<ISharedOrganizationDirectoryPathProvider>(() => services.AddSharedOrganizationDirectoryPathProvider_Old(
                organizationalDirectoryPathProviderAction,
                sharedDirectoryNameProviderAction,
                stringlyTypedPathOperatorAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="IOrganizationDirectoryPathProvider"/> service as the <see cref="IPrivateOrganizationDirectoryPathProvider"/> service as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection UsePrivateOrganizationDirectoryPathProvider_Old(this IServiceCollection services,
            IServiceAction<IPrivateOrganizationDirectoryPathProvider> privateOrganizationDirectoryPathProviderAction)
        {
            services
                .AddSingleton<IOrganizationDirectoryPathProvider>((serviceProvider) =>
                {
                    var privateOrganizationDirectoryPathProvider = serviceProvider.GetRequiredService<IPrivateOrganizationDirectoryPathProvider>();
                    return privateOrganizationDirectoryPathProvider;
                })
                .Run(privateOrganizationDirectoryPathProviderAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IOrganizationDirectoryPathProvider"/> service as the <see cref="IPrivateOrganizationDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IOrganizationDirectoryPathProvider> UsePrivateOrganizationDirectoryPathProviderAction_Old(this IServiceCollection services,
            IServiceAction<IPrivateOrganizationDirectoryPathProvider> privateOrganizationDirectoryPathProviderAction)
        {
            var serviceAction = ServiceAction.New<IOrganizationDirectoryPathProvider>(() => services.UsePrivateOrganizationDirectoryPathProvider_Old(
                privateOrganizationDirectoryPathProviderAction));
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="IOrganizationDirectoryPathProvider"/> service as the <see cref="ISharedOrganizationDirectoryPathProvider"/> service as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection UseSharedOrganizationDirectoryPathProvider_Old(this IServiceCollection services,
            IServiceAction<ISharedOrganizationDirectoryPathProvider> sharedOrganizationDirectoryPathProviderAction)
        {
            services
                .AddSingleton<IOrganizationDirectoryPathProvider>((serviceProvider) =>
                {
                    var sharedOrganizationDirectoryPathProvider = serviceProvider.GetRequiredService<ISharedOrganizationDirectoryPathProvider>();
                    return sharedOrganizationDirectoryPathProvider;
                })
                .Run(sharedOrganizationDirectoryPathProviderAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IOrganizationDirectoryPathProvider"/> service as the <see cref="ISharedOrganizationDirectoryPathProvider"/> service as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IOrganizationDirectoryPathProvider> UseSharedOrganizationDirectoryPathProviderAction_Old(this IServiceCollection services,
            IServiceAction<ISharedOrganizationDirectoryPathProvider> sharedOrganizationDirectoryPathProviderAction)
        {
            var serviceAction = ServiceAction.New<IOrganizationDirectoryPathProvider>(() => services.UseSharedOrganizationDirectoryPathProvider_Old(
                sharedOrganizationDirectoryPathProviderAction));

            return serviceAction;
        }
    }
}
