using System;

namespace Haley.Abstractions
{
    public interface IContainerFactory
    {
        string Id { get; }
        bool Initiate();
        IServiceProvider Services { get;  }
        IControlContainer Controls { get; } 
        IWindowContainer Windows { get; }
        IBaseContainer GetDI();
    }
}
