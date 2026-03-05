using Haley.Abstractions;
using System.Threading.Tasks;

namespace Haley.Models {
    public abstract class MariaDALBase {
        protected readonly IDALUtilBase Db;
        protected MariaDALBase(IDALUtilBase db) => Db = db;
        protected async Task<bool> ExistsAsync(string existsSql, DbExecutionLoad load, params DbArg[] args)
            => (await Db.ScalarAsync<int>(existsSql, load, args)) == 1;
    }
}
