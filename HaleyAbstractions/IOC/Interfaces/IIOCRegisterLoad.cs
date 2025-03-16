using Haley.Enums;
using System;

namespace Haley.Abstractions {
    public interface IIOCRegisterLoad : IIOCPayLoad {
        object ConcreteInstance { get; }
        IOCRegisterMode Mode { get; }
        Func<object> InstanceCreator { get; }
        bool IsLazyRegister { get; }
    }
}
