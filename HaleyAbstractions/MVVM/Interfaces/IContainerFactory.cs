using System;

namespace Haley.Abstractions
{
    public interface IContainerFactory : IDisposable
    {
        string Id { get; }
        IServiceProvider Services { get;  }
        IControlContainer Controls { get; } 
        IWindowContainer Windows { get; }
    }
}
