using System.Collections.Generic;

namespace Haley.Abstractions{
    public interface IIdentityBase {
        string Key { get; }
        string Id { get; }
    }
}