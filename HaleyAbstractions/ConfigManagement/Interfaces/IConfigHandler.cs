using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haley.Abstractions
{
    public interface IConfigHandler
    {
        void OnConfigSaving(ref IConfig config);
        void OnConfigLoaded(IConfig config);
        IConfig PrepareDefaultConfig();
    }
}
