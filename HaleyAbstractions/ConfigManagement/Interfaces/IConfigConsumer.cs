using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haley.Abstractions
{
    public interface IConfigConsumer<T> where T : class, IConfig
    {
        Guid UniqueId { get; set; }
        Task<bool> OnConfigChanged(T config);
    }
}
