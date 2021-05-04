using System;
using System.Threading.Tasks;


namespace R5T.Carpathia
{
    public interface ISharedDirectoryNameProvider
    {
        Task<string> GetSharedDirectoryName();
    }
}
