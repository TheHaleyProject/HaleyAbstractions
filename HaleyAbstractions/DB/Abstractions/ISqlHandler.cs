using Haley.Enums;
using Microsoft.Extensions.Logging;
using System;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace Haley.Abstractions
{
    public interface ISqlHandler<C> : ISqlHandler
        where C: IDbCommand {
        Task<object> ExecuteInternal(IDBInput input, Func<IDbCommand, Task<object>> processor, params (string key, object value)[] parameters);
    }

    public interface ISqlHandler  {
        Task<DataSet> ExecuteReader(IDBInput input, params (string key, object value)[] parameters);
        Task<object> ExecuteNonQuery(IDBInput input, params (string key, object value)[] parameters);
        Task<object> ExecuteScalar(IDBInput input, params (string key, object value)[] parameters);
    }
}
