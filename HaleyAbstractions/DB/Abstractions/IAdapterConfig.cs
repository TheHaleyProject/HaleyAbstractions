using Haley.Enums;
using Haley.Models;
using System;

namespace Haley.Abstractions {
    public interface IAdapterConfig : ICloneable{
        string AdapterKey { get; set; }
        string ConnectionKey { get; set; }
        string ConnectionString { get; set; }
        string DBAString { get; set; }
        string DBName { get; set; }
        TargetDB DBType { get; set; }
        ConInfo ConnectionInfo { get; set; }
        string SchemaName { get; set; }
        string Sha { get; set; }
        IAdapterConfig Update(IAdapterConfig entry);
    }
}
