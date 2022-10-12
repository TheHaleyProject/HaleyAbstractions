using Haley.Enums;
using System;

namespace Haley.Abstractions
{
    public interface IRegisterLoad : IPayLoad
    {
        object ConcreteInstance { get; }
        RegisterMode Mode { get; }
        Func<object> InstanceCreator { get; }
        bool IsLazyRegister { get; }
    }
}
