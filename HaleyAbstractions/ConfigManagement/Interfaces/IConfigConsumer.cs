using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haley.Abstractions
{
    public interface IConfigConsumer<T> where T: IConfig
    {
        Guid UniqueId { get; set; }
        Task<bool> OnConfigLoaded(T config);
    }
}
