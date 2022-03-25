using System;

namespace Haley.Abstractions
{
    public interface IMicroContainerFactory :IContainerFactory
    {
        new IBaseServiceProvider Services { get; }
        IBaseContainer Container { get; }
    }
}
