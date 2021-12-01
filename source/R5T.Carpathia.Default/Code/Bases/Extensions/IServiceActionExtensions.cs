using System;

using R5T.T0062;
using R5T.T0063;


namespace R5T.Carpathia.Default
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="SharedDirectoryNameProvider"/> implementation of <see cref="ISharedDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ISharedDirectoryNameProvider> AddSharedDirectoryNameProviderAction(this IServiceAction _)
        {
            var serviceAction = _.New<ISharedDirectoryNameProvider>(services => services.AddSharedDirectoryNameProvider());
            return serviceAction;
        }
    }
}
