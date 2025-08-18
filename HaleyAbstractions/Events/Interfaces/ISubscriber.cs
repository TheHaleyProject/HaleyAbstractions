using Haley.Enums;
using System;

namespace Haley.Abstractions {
    public interface ISubscriber {
        string Id { get; set; }
        Type DeclaringType { get; }
        string GroupId { get; }
        string ListenerMethod { get; set; }
        InvokeOption InvokeOption { get; }
        void SendMessage(params object[] args);
    }
}
