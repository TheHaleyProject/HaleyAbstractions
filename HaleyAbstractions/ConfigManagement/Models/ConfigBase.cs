using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Haley.Abstractions;
using System.Reflection;


namespace Haley.Models
{
    public class ConfigBase : IConfig {
        public string Id { get; }

        public string FileName { get; set; }

        public ConfigBase()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
