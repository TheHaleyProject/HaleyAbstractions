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
    public class ConfigVault 
    {
        public IConfig Config { get; set; }
        public IConfigInfo Info { get; set; }
        public IConfigHandler Handler { get; set; }
        public ConfigVault() { }
    }
}
