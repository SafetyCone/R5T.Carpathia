using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.Carpathia
{
    /// <summary>
    /// Base class for <see cref="IPrivateOrganizationDirectoryPathProvider"/> or <see cref="ISharedOrganizationDirectoryPathProvider"/> services.
    /// The organization directory should be either the private, or shared directory, and both are the "organization" directory for a given program.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IOrganizationDirectoryPathProvider : IServiceDefinition
    {
        Task<string> GetOrganizationDirectoryPath();
    }
}
