﻿using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Lombardy;

using R5T.T0063;

using IOrganizationalDirectoryPathProvider = R5T.Costobocia.IOrganizationDirectoryPathProvider;


namespace R5T.Carpathia.Costobocia
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Forwards the <see cref="ISharedOrganizationDirectoryPathProvider"/> service to <see cref="IOrganizationDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection ForwardToIOrganizationDirectoryPathProvider(this IServiceCollection services,
            IServiceAction<ISharedOrganizationDirectoryPathProvider> sharedOrganizationDirectoryPathProviderAction)
        {
            services
                .Run(sharedOrganizationDirectoryPathProviderAction)
                .AddSingleton<IOrganizationDirectoryPathProvider>(sp => sp.GetRequiredService<ISharedOrganizationDirectoryPathProvider>());

            return services;
        }

        /// <summary>
        /// Forwards the <see cref="IPrivateOrganizationDirectoryPathProvider"/> service to <see cref="IOrganizationDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection ForwardToIOrganizationDirectoryPathProvider(this IServiceCollection services,
            IServiceAction<IPrivateOrganizationDirectoryPathProvider> privateOrganizationDirectoryPathProviderAction)
        {
            services
                .Run(privateOrganizationDirectoryPathProviderAction)
                .AddSingleton<IOrganizationDirectoryPathProvider>(sp => sp.GetRequiredService<IPrivateOrganizationDirectoryPathProvider>());

            return services;
        }

        /// <summary>
        /// Adds the <see cref="SharedOrganizationDirectoryPathProvider"/> implementation of <see cref="ISharedOrganizationDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddSharedOrganizationDirectoryPathProvider(this IServiceCollection services,
            IServiceAction<IOrganizationalDirectoryPathProvider> organizationalDirectoryPathProviderAction,
            IServiceAction<ISharedDirectoryNameProvider> sharedDirectoryNameProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            services
                .Run(organizationalDirectoryPathProviderAction)
                .Run(sharedDirectoryNameProviderAction)
                .Run(stringlyTypedPathOperatorAction)
                .AddSingleton<ISharedOrganizationDirectoryPathProvider, SharedOrganizationDirectoryPathProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="PrivateOrganizationDirectoryPathProvider"/> implementation of <see cref="IPrivateOrganizationDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddPrivateOrganizationDirectoryPathProvider(this IServiceCollection services,
            IServiceAction<IOrganizationalDirectoryPathProvider> organizationalDirectoryPathProviderAction)
        {
            services
                .Run(organizationalDirectoryPathProviderAction)
                .AddSingleton<IPrivateOrganizationDirectoryPathProvider, PrivateOrganizationDirectoryPathProvider>();

            return services;
        }
    }
}
