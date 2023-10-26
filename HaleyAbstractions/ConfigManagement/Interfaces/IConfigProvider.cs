using Haley.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haley.Abstractions
{
    public interface IConfigProvider<T> where T : class,IConfig,new()
    {
        Guid UniqueId { get; set; }

        Task<T> PrepareDefaultConfig();
        /// <summary>
        /// The configuration is about to be saved. return the updated config to be saved.
        /// </summary>
        /// <returns></returns>
        Task<T> GetLatestConfig();

        //void DummyMethod();
    }
}
