using Haley.Enums;
using Microsoft.Extensions.Logging;
using System;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace Haley.Abstractions
{
    public interface ISqlHandler<C> where C: IDbCommand {
        Task<DataSet> ExecuteReader(IDBInput input, params (string key, object value)[] parameters);
        Task<object> ExecuteNonQuery(IDBInput input, params (string key, object value)[] parameters);
        Task<object> ExecuteScalar(IDBInput input, params (string key, object value)[] parameters);
        Task<object> ExecuteInternal(IDBInput input, Func<C, Task<object>> processor, params (string key, object value)[] parameters);
    }
}
