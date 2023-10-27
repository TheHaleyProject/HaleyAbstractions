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
        #region Events
        EventHandler<Type> ConfigLoaded { get; set; }
        EventHandler<Type> ConfigSaved { get; set; }
        #endregion

        #region Properties
        ExceptionHandling ExceptionMode { get; }
        string FileExtension { get; set; }
        bool SaveWithFullName { get; set; }
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
        bool TryRegisterConsumers<T>(List<IConfigConsumer<T>> consumers, bool silentRegistration = true) where T : class, IConfig,new();
        bool TryRemoveConsumer<T>(IConfigConsumer<T> consumer) where T :class, IConfig,new();
        bool TryRemoveConsumers<T>(List<IConfigConsumer<T>> consumers) where T :class, IConfig,new();
        #endregion

        #region Provider
        bool TryRegisterOrUpdateProvider<T>(IConfigProvider<T> newProvider) where T : class, IConfig,new();

        #endregion

        #region Config
        IEnumerable<IConfig> GetAllConfig(bool copy = true);
        T GetConfig<T>(bool copy = true) where T : class, IConfig,new(); //return a copy
        Task LoadAllConfig(bool notifyConsumers = true, bool loadParallely = true);
        Task LoadConfig<T>(bool notifyConsumers = true) where T : class, IConfig,new(); //need to inform consumers for sure.

        /// <summary>
        /// Resets to default config.
        /// </summary>
        /// <param name="key"></param>
        Task ResetConfig<T>(bool notifyConsumers = true) where T : class, IConfig,new();
        Task ResetAllConfig(bool notifyConsumers = true);

        Task<bool> Save<T>(bool notifyConsumers = true,bool writeToDirectory = true, bool askProvider = true) where T : class, IConfig,new();
        Task SaveAll(bool notifyConsumers = true,bool writeToDirectory = true, bool askProvider = true);

        Task<bool> UpdateConfig<T>(T config,bool notifyConsumers = false) where T : class, IConfig,new(); //Based on the new data, update the information
        Task NotifyConsumers<T>() where T: class, IConfig,new();
        Task NotifyAllConsumers();
        #endregion

            #region General Calls
        void DeleteAllFiles();

        bool DeleteFile<T>() where T : class, IConfig,new();

        string GetBasePath();

        string GetSavePath<T>() where T : class, IConfig,new();

        void SetBasePath(string base_path);

        //If not provided, it gets stored in the ex
        void SetProcessors(Func<Type, string, string> presave_processor, Func<Type, string, string> postload_processor);

        void SetSerializer(Func<Type,IConfig, string> serializer, Func<Type,string, IConfig> deserializer);

        IConfigService SetStorageDirectory<T>(string storageDirectory) where T : class, IConfig,new();

        IConfigService WithExceptionHandling(ExceptionHandling exceptionHandling);
        #endregion
    }
}
