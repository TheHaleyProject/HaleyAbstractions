using System.Data;
using System.Threading.Tasks;

namespace Haley.Abstractions
{
    public interface IDBAdapter : IDBCaller {
        IDBAdapterInfo Info { get; }  //Read only.
        void UpdateDBEntry(IDBAdapterInfo newentry);
    }
}
