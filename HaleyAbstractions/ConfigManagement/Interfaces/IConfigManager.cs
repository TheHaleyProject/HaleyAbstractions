using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Haley.Enums;

namespace Haley.Abstractions
{
    public interface IConfigManager
    {
        bool UseCustomProcessors { get; set; }
        bool UseCustomSerializers { get; set; }
        string FileExtension { get; set; }

        IConfig GetConfig(string key);
        bool UpdateConfig(string key, IConfig config);
        IEnumerable<IConfig> GetAllConfig();
        bool TryRegister(IConfigInfo info, IConfig data, IConfigHandler handler, out IConfigInfo resultInfo);
        bool TryRegister(string key, Type configurationType, IConfig data, IConfigHandler handler, out IConfigInfo resultInfo);

        void SaveAll();
        bool Save(string key);
        void SetBasePath(string base_path); //If not provided, it gets stored in the ex
        string GetBasePath();
        string GetSavePath(IConfigInfo info);
        void SetProcessors(Func<IConfigInfo,string, string> presave_processor, Func<IConfigInfo,string, string> postload_processor);
        void SetSerializer(Func<IConfig, string> serializer, Func<string, IConfig> deserializer);
        void LoadAllConfig();
        void LoadConfig(string key);
        /// <summary>
        /// Resets to default config.
        /// </summary>
        /// <param name="key"></param>
        void ResetConfig(string key);
    }
}
