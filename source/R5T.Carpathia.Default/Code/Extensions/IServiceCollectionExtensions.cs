using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Carpathia.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="SharedDirectoryNameProvider"/> implementation of <see cref="ISharedDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddSharedDirectoryNameProvider(this IServiceCollection services)
        {
            services.AddSingleton<ISharedDirectoryNameProvider, SharedDirectoryNameProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="SharedDirectoryNameProvider"/> implementation of <see cref="ISharedDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ISharedDirectoryNameProvider> AddSharedDirectoryNameProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<ISharedDirectoryNameProvider>(() => services.AddSharedDirectoryNameProvider());
            return serviceAction;
        }
    }
}
