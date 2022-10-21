using System;

namespace Haley.Abstractions
{
    public interface IContainerFactory : IDisposable
    {
        string Id { get; }
        string Name { get; }
        IServiceProvider Services { get;  }
        IControlContainer Controls { get; } 
        IWindowContainer Windows { get; }
    }
}
