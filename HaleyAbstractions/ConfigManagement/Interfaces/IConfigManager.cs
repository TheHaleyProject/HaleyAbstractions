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
        ExceptionHandling ExceptionMode { get; }
        bool UseCustomProcessors { get; set; }
        bool UseCustomSerializers { get; set; }
        bool ReloadConfigOnHandlerUpdate { get; set; }
        string FileExtension { get; set; }

        IConfigManager WithExceptionHandling(ExceptionHandling exceptionHandling);
        IConfig GetConfig(string key);
        Task<bool> UpdateConfig(string key, IConfig config);
        IEnumerable<IConfig> GetAllConfig();
        bool TryRegister(IConfigInfo info, IConfig data, IConfigHandler handler, bool updateHandlerOnFailure);
        bool TryRegister(string key, IConfig data, IConfigHandler handler, out IConfigInfo resultInfo, bool updateHandlerOnFailure = false);
        bool TryRegister(string key, IConfig data, IConfigHandler handler, bool updateHandlerOnFailure = false);
        bool TryRegister(IConfig data, IConfigHandler handler, out IConfigInfo resultInfo, bool updateHandlerOnFailure = false);
        bool TryRegister(IConfig data, IConfigHandler handler,  bool updateHandlerOnFailure = false);
        bool TryRegister<ConfigType>(string key, IConfigHandler handler, out IConfigInfo resultInfo, bool updateHandlerOnFailure = false) where ConfigType:IConfig;
        bool TryRegister<ConfigType>(string key, IConfigHandler handler,  bool updateHandlerOnFailure = false) where ConfigType : IConfig;
        bool TryRegister<ConfigType>(IConfigHandler handler, out IConfigInfo resultInfo, bool updateHandlerOnFailure = false) where ConfigType : IConfig;
        bool TryRegister<ConfigType>(IConfigHandler handler, bool updateHandlerOnFailure = false) where ConfigType : IConfig;
        bool TryUpdateHandler(string key, IConfigHandler handler);
        void SaveAll();
        bool Save(string key); 
        void DeletaAllFiles();
        bool DeleteFile(string key);
        void SetBasePath(string base_path); //If not provided, it gets stored in the ex
        string GetBasePath();
        string GetSavePath(IConfigInfo info);
        void SetProcessors(Func<IConfigInfo,string, string> presave_processor, Func<IConfigInfo,string, string> postload_processor);
        void SetSerializer(Func<IConfig, string> serializer, Func<string, IConfig> deserializer);
        Task LoadAllConfig();
        Task<bool> LoadConfig(string key);
        /// <summary>
        /// Resets to default config.
        /// </summary>
        /// <param name="key"></param>
        Task ResetConfig(string key);
    }
}
