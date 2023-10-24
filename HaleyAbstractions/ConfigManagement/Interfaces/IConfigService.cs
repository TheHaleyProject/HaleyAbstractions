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
        #region Properties
        ExceptionHandling ExceptionMode { get; }
        string FileExtension { get; set; }
        bool SaveWithFullName { get; set; }
        bool SendConfigCloneToConsumers { get; set; }
        bool UseCustomProcessors { get; set; } //Flag to pre process (may be to encrypt decrypt the data)
        bool UseCustomSerializers { get; set; } //The way how the object can be serialized and deserialized
        #endregion

        #region General registrations
        bool TryRegister<T>() where T : class, IConfig,new();
        bool TryRegister<T>(T config) where T : class, IConfig,new();
        bool TryRegister<T>(T config, IConfigProvider<T> provider, bool replaceProviderIfExists = false) where T : class, IConfig,new();
        bool TryRegister<T>(IConfigProvider<T> provider, bool replaceProviderIfExists = false) where T : class, IConfig,new();
        bool TryRegister<T>(T config, IConfigProvider<T> provider, List<IConfigConsumer<T>> consumers, bool replaceProviderIfExists = false, bool silentRegistration = true) where T : class, IConfig,new();
        bool TryRegister<T>(IConfigProvider<T> provider, List<IConfigConsumer<T>> consumers, bool replaceProviderIfExists = false, bool silentRegistration = true) where T : class, IConfig,new();
        #endregion

        #region Consumer
        bool TryRegisterConsumer<T>(IConfigConsumer<T> consumer, bool silentRegistration = true) where T : class, IConfig,new();
        bool TryRegisterConsumer<T>(Action<T> action_consumer, out int id, bool silentRegistration = true) where T :class, IConfig,new();
        bool TryRegisterConsumers<T>(List<IConfigConsumer<T>> consumers, bool silentRegistration = true) where T : class, IConfig,new();

        bool TryRemoveConsumer<T>(IConfigConsumer<T> consumer) where T :class, IConfig,new();
        bool TryRemoveConsumer<T>(int actionId) where T: IConfig;
        bool TryRemoveConsumers<T>(List<IConfigConsumer<T>> consumers) where T :class, IConfig,new();
        #endregion

        #region Provider
        bool TryRegisterOrUpdateProvider<T>(IConfigProvider<T> newProvider) where T : class, IConfig,new();

        #endregion

        #region Config
        IEnumerable<IConfig> GetAllConfig();

        T GetConfig<T>() where T : class, IConfig,new();
        T GetConfigCopy<T>() where T : class, IConfig,new();
        Task LoadAllConfig();

        Task LoadConfig<T>() where T : class, IConfig,new();

        /// <summary>
        /// Resets to default config.
        /// </summary>
        /// <param name="key"></param>
        Task ResetConfig<T>() where T : class, IConfig,new();

        bool Save<T>() where T : class, IConfig,new();

        void SaveAll();

        Task<bool> UpdateConfig<T>(T config) where T : class, IConfig,new(); //Based on the new data, update the information
        #endregion

        #region General Calls
        void DeletaAllFiles();

        bool DeleteFile<T>() where T : class, IConfig,new();

        string GetBasePath();

        string GetSavePath<T>() where T : class, IConfig,new();

        void SetBasePath(string base_path);

        //If not provided, it gets stored in the ex
        void SetProcessors(Func<Type, string, string> presave_processor, Func<Type, string, string> postload_processor);

        void SetSerializer(Func<IConfig, string> serializer, Func<string, IConfig> deserializer);

        IConfigService SetStorageDirectory<T>(string storageDirectory) where T : class, IConfig,new();

        IConfigService WithExceptionHandling(ExceptionHandling exceptionHandling);
        #endregion
    }
}
