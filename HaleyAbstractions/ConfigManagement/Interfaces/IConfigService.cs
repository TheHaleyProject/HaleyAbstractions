using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Haley.Enums;

namespace Haley.Abstractions
{
    public interface IConfigService
    {

        ExceptionHandling ExceptionMode { get; }
        bool UseCustomProcessors { get; set; } //Flag to pre process (may be to encrypt decrypt the data)
        bool UseCustomSerializers { get; set; } //The way how the object can be serialized and deserialized
        string FileExtension { get; set; }
        bool SaveWithFullName { get; set; }

        IConfigService WithExceptionHandling(ExceptionHandling exceptionHandling);
        T GetConfig<T>() where T: IConfig;
        Task<bool> UpdateConfig<T>(T config) where T : IConfig; //Based on the new data, update the information
        IEnumerable<IConfig> GetAllConfig();
        IConfigService SetStorageDirectory<T>(string storageDirectory) where T : IConfig;
        bool TryRegister<T>(T data, IConfigProvider<T> provider, bool replaceHandlerIfExists = false) where T: IConfig;
        bool TryRegister<T>(IConfigProvider<T> provider, bool replaceHandlerIfExists = false) where T:IConfig;
        bool TryUpdateProvider<T>(IConfigProvider<T> newProvider) where T: IConfig;
        bool TryRegisterConsumer<T>(IConfigConsumer<T> consumer) where T:IConfig;
        bool TryRemoveConsumer<T>(IConfigConsumer<T> consumer) where T:IConfig;
        void SaveAll();
        bool Save<T>() where T : IConfig; 
        void DeletaAllFiles();
        bool DeleteFile<T>() where T : IConfig;
        void SetBasePath(string base_path); //If not provided, it gets stored in the ex
        string GetBasePath();
        string GetSavePath<T>() where T : IConfig;

        void SetProcessors(Func<Type,string, string> presave_processor, Func<Type,string, string> postload_processor);
        void SetSerializer(Func<IConfig, string> serializer, Func<string, IConfig> deserializer);
        Task LoadAllConfig();
        Task LoadConfig<T>() where T : IConfig;
        /// <summary>
        /// Resets to default config.
        /// </summary>
        /// <param name="key"></param>
        Task ResetConfig<T>();
    }
}
