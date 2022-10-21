using System;

namespace Haley.Abstractions
{
    public interface IMicroContainerFactory :IContainerFactory
    {
        bool IsDisposed { get; }
        event EventHandler<IMicroContainerFactory> ChildFactoryCreated;
        event EventHandler<string> FactoryDisposed;
        IMicroContainerFactory Parent { get;  }
        IMicroContainerFactory Root { get;  }
        new IBaseServiceProvider Services { get; }
        IMicroContainer Container { get; }
        IMicroContainerFactory GetChild(string id, bool search_all_children = false);
        IMicroContainerFactory this[string key] { get; }
        IMicroContainerFactory CreateChild(Guid id, string name, bool ignore_parentcontainer);
        IMicroContainerFactory CreateChild(Guid id = default(Guid), bool ignore_parentcontainer = false);
        IMicroContainerFactory CreateChild(string name, bool ignore_parentcontainer = false);
        IMicroContainerFactory CreateChild();
    }
}
