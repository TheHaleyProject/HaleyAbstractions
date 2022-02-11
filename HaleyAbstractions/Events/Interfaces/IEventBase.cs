using System;

namespace Haley.Abstractions
{
    public interface IEventBase
    {
        bool UnSubscribe(string subscription_key);
        bool UnSubscribeGroup(string group_id);
        bool UnSubscribe(Type declaring_parent, bool include_all_groups = false);
        bool UnSubscribe<TParent>(bool include_all_groups = false) where TParent:class;
    }
}
