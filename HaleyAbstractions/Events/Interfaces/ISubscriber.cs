using System;

namespace Haley.Abstractions
{
    public interface ISubscriber
    {
        string Id { get; set; }
        Type DeclaringType { get; }
        string GroupId { get; }
        string ListenerMethod { get; set; }
        void SendMessage(params object[] args);
    }
}
