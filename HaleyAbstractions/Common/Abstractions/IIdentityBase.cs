using System.Collections.Generic;

namespace Haley.Abstractions{
    public interface IIdentityBase {
        string Key { get; }
        string Guid { get; }
        int Id { get; set; }
        string Name { get; set; }
    }
}