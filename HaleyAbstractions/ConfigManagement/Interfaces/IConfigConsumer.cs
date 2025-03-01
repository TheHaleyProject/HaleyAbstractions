using System;
using System.Threading.Tasks;

namespace Haley.Abstractions {
    public interface IConfigConsumer<T> where T : class, IConfig {
        Guid UniqueId { get; set; }
        Task<bool> OnConfigChanged(T config);
    }
}
