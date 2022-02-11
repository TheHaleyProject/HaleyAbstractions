using System;

namespace Haley.Abstractions
{
    public interface IEventService
    {
        T GetEvent<T>() where T :class, IEventBase, new();
        void ClearAll();
        void ClearAll<TParent>(bool include_all_groups = false) where TParent : class;
        void ClearAll(Type parent, bool include_all_groups = false);
        void ClearAll(string subscription_key);
        void ClearGroup(string group_id);
    }
}
