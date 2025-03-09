using Haley.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System;

namespace Haley.Abstractions {
    public interface IDBTransaction: IDisposable {
        Task<IDBTransaction> Begin();
        Task Commit();
        Task Rollback();
    }
}
