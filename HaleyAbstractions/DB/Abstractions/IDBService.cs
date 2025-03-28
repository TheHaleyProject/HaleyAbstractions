﻿using Haley.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System;

namespace Haley.Abstractions {
    public interface IDBService: IDictionary<string, IDBAdapter>, IDBCrudHandler{
        //This should be stateless as every controller might call this concurrently.
        bool ThrowCRUDExceptions { get; }
        Guid Id { get; }
        void SetServiceUtil(IDBServiceUtil util);
        Task<object> GetFirst(object input, ResultFilter filter = ResultFilter.None);
        IConfigurationRoot GetConfigurationRoot(bool reload = false, bool force_reload = false);
        IDBService Add(IDBAdapterInfo entry, bool replace = true);
        IDBService UpdateAdapter();
        IDBService Configure();
        ITransactionHandler GetTransactionHandler(string adapterKey);
        string GetSchemaName(string adapterKey);
    }
}
