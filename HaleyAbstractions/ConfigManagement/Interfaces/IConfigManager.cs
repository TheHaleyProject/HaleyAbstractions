using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haley.Abstractions
{
    public interface IConfigManager
    {
        IConfig GetConfig(string key);
        IEnumerable<IConfig> GetAllConfig();
        bool TryRegister(IConfigInfo info, IConfig data,out IConfigInfo resultInfo);
        bool TryRegister(string key,Type configurationType, IConfig data, IConfigHandler handler, out IConfigInfo resultInfo);
        IConfigInfo Register(IConfigInfo info,IConfig data);
        IConfigInfo Register(string key, Type configurationType, IConfig data, IConfigHandler handler);
        void SaveAll();
        void Save(string key);
        void SetBasePath(string base_path); //If not provided, it gets stored in the ex
        string GetBasePath();
        string GetSavePath(IConfigInfo info);
        void SetProcessors(Func<IConfigInfo,string, string> presave_processor, Func<IConfigInfo,string, string> postload_processor);
        void LoadAllConfig();
        void LoadConfig(string key);
        /// <summary>
        /// Resets to default config.
        /// </summary>
        /// <param name="key"></param>
        void ResetConfig(string key);
    }
}
