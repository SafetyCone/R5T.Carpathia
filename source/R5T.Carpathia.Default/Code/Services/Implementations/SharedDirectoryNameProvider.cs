using System;
using System.Threading.Tasks;


namespace R5T.Carpathia.Default
{
    public class SharedDirectoryNameProvider : ISharedDirectoryNameProvider
    {
        public Task<string> GetSharedDirectoryName()
        {
            return Task.FromResult(SharedDirectory.Name);
        }
    }
}
