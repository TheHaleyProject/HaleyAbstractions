using Haley.Enums;
using Haley.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Haley.Abstractions {
    public interface IAdapterGateway: IDictionary<string, IDBAdapter>, IDBCrudHandler, IGatewayCrudHandler {
        //This should be stateless as every controller might call this concurrently.
        bool ThrowCRUDExceptions { get; }
        bool LogQueryInConsole { get; set; }
        bool IsDevelopment { get; }
        Guid Id { get; }
        void SetServiceUtil(IGatewayUtil util);
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
