using System;

namespace Haley.Abstractions
{
    public interface IDBAdapter : IAdapterCrudHandler {
        Guid Id { get; }
        IAdapterConfig Info { get; }  //Read only.
        void UpdateDBEntry(IAdapterConfig newentry);
    }
}
