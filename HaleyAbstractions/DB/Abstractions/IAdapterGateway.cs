using Haley.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System;

namespace Haley.Abstractions {
    public interface IAdapterGateway: IDictionary<string, IDBAdapter>, IAdapterCrudHandler, IDBCrudHandler, IAdapterCrudHandlerEx {
        //This should be stateless as every controller might call this concurrently.
        bool ThrowCRUDExceptions { get; }
        bool LogQueryInConsole { get; set; }
        bool IsDevelopment { get; }
        Guid Id { get; }
        void SetServiceUtil(IGatewayUtil util);
        Task<object> GetFirst(object input, ResultFilter filter = ResultFilter.None);
        IConfigurationRoot GetConfigurationRoot(bool reload = false, bool force_reload = false);
        void SetDefaultAdapterKey(string adapterKey);
        IAdapterGateway Add(IAdapterConfig entry, bool replace = true);
        IAdapterGateway UpdateAdapter();
        IAdapterGateway Configure();
        ITransactionHandler GetTransactionHandler();
        ITransactionHandler GetTransactionHandler(string adapterKey);
        string GetSchemaName(string adapterKey);
        IFeedback DuplicateAdapter(string existingAdapterKey, string newAdapterKey, params (string key,string value)[]connectionStringReplacements);
    }
}
