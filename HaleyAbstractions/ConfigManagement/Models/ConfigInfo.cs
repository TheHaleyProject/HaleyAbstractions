using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Haley.Abstractions;


namespace Haley.Models
{
    public class ConfigInfo : IConfigInfo
    {
        public string Name { get; }

        public string Id { get; }

        public string StorageDirectory { get; }

        public Type ConfigType { get; private set; }

        public IConfigInfo SetConfigType<T>() where T:IConfig
        {
            return SetConfigType(typeof(T));
        }

        public IConfigInfo SetConfigType(Type targetType) 
        {
            if (ConfigType != null) throw new ArgumentException("Config type is already set. Can initiate only once.");
            ConfigType = targetType;
            return this;
        }

        public ConfigInfo(string name) : this(name, null)
        {
        }

        public ConfigInfo (string name,string storageDir)
        {
            Name = name;
            Id = Guid.NewGuid().ToString();
            StorageDirectory = storageDir;
        }
    }
}
