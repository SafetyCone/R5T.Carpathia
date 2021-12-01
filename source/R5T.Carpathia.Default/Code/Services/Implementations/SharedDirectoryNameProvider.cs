using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.Carpathia.Default
{
    [ServiceImplementationMarker]
    public class SharedDirectoryNameProvider : ISharedDirectoryNameProvider, IServiceImplementation
    {
        public Task<string> GetSharedDirectoryName()
        {
            return Task.FromResult(SharedDirectory.Name);
        }
    }
}
