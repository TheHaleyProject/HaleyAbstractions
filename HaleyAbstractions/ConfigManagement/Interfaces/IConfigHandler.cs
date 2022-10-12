using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haley.Abstractions
{
    public interface IConfigHandler
    {
        Guid UniqueId { get; set; }
        /// <summary>
        /// Config is loaded from file. Do some process internally if needed
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        Task OnConfigLoaded(IConfig config);
        IConfig PrepareDefaultConfig();
        /// <summary>
        /// The configuration is about to be saved. return the updated config to be saved.
        /// </summary>
        /// <returns></returns>
        IConfig OnConfigSaving();
    }
}
