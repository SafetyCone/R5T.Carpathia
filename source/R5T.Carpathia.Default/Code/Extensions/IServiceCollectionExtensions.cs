using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0063;


namespace R5T.Carpathia.Default
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="SharedDirectoryNameProvider"/> implementation of <see cref="ISharedDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddSharedDirectoryNameProvider(this IServiceCollection services)
        {
            services.AddSingleton<ISharedDirectoryNameProvider, SharedDirectoryNameProvider>();

            return services;
        }
    }
}
