using System;

namespace Haley.Abstractions
{
    public interface IDBAdapter : IAdapterCrudHandler {
        Guid Id { get; }
        IDBAdapterInfo Info { get; }  //Read only.
        void UpdateDBEntry(IDBAdapterInfo newentry);
    }
}
