﻿using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.Carpathia
{
    [ServiceDefinitionMarker]
    public interface ISharedDirectoryNameProvider : IServiceDefinition
    {
        Task<string> GetSharedDirectoryName();
    }
}
