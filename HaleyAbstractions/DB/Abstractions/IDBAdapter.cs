using System.Data;
using System.Threading.Tasks;

namespace Haley.Abstractions
{
    public interface IDBAdapter {
        IDBAdapterInfo Info { get; }  //Read only.
        Task<DataSet> ExecuteReader(IDBInput input, params (string key, object value)[] parameters);
        Task<object> ExecuteNonQuery(IDBInput input, params (string key, object value)[] parameters);
        Task<object> ExecuteScalar(IDBInput input, params (string key, object value)[] parameters);
        void UpdateDBEntry(IDBAdapterInfo newentry);
    }
}
