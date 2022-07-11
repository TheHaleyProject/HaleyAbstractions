using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haley.Abstractions
{
    public interface IConfigInfo
    {
        /// <summary>
        /// Name should be unique.
        /// </summary>
        string Name { get; }
        string Id { get; }
        IConfigInfo SetConfigType<T>() where T : IConfig;
        IConfigInfo SetConfigType(Type targetType);
        Type ConfigType { get; }
        /// <summary>
        /// Give relative or absolute path (For relative, ConfigManager base path will be used.)
        /// </summary>
        string StorageDirectory { get; } 
        
    }
}
