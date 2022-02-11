using System;

namespace Haley.Abstractions
{
    public interface IContainerFactory
    {
        string Id { get; }
        IServiceProvider Services { get;  }
        IControlContainer Controls { get; } 
        IWindowContainer Windows { get; }
        bool RegisterSelf();
    }
}
