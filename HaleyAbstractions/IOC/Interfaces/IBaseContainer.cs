using Haley.Enums;
using System;
using System.Windows;
using System.Collections.Generic;
using System.Collections.Concurrent;
using Haley.Models;

namespace Haley.Abstractions
{
    public interface IBaseContainer : IServiceProvider,IDisposable
    {
        string Id { get; }
        string Name { get; }
        ExceptionHandling ErrorHandling { get; set; }
        IBaseContainer CreateChildContainer(string name = null);
        #region Validation Methods
        (bool status, string message,IRegisterLoad load) CheckIfRegistered(Type contract_type,string priority_key,bool checkInParents = false);
        (bool status, string message, IRegisterLoad load) CheckIfRegistered<TContract>(string priority_key, bool checkInParents = false);
        (bool status, string message, IRegisterLoad load) CheckIfRegistered(IKeyBase key, bool checkInParents = false);
        #endregion

        #region TryRegister Methods
        bool Register<TConcrete>(RegisterMode mode = RegisterMode.ContainerSingleton) where TConcrete : class;
        bool Register<TConcrete>(TConcrete instance,SingletonMode mode = SingletonMode.ContainerSingleton) where TConcrete : class;
        bool Register<TConcrete>(IMappingProvider dependencyProvider, MappingLevel mapping_level, SingletonMode mode = SingletonMode.ContainerSingleton) where TConcrete : class;
        bool Register<TContract, TConcrete>(RegisterMode mode = RegisterMode.ContainerSingleton) where TConcrete : class, TContract;  //TImplementation should either implement or inherit from TContract
        bool Register<TContract, TConcrete>(TConcrete instance, SingletonMode mode = SingletonMode.ContainerSingleton) where TConcrete : class, TContract;  //TImplementation should either implement or inherit from TContract
        bool Register<TContract, TConcrete>(IMappingProvider dependencyProvider, MappingLevel mapping_level, SingletonMode mode = SingletonMode.ContainerSingleton) where TConcrete : class, TContract;  //TImplementation should either implement or inherit from TContract
        #endregion

        #region RegisterWithKey Methods
        bool RegisterWithKey<TConcrete>(string priority_key, RegisterMode mode = RegisterMode.ContainerSingleton) where TConcrete : class;
        bool RegisterWithKey<TConcrete>(string priority_key, TConcrete instance, SingletonMode mode = SingletonMode.ContainerSingleton) where TConcrete : class;
        bool RegisterWithKey<TConcrete>(string priority_key, IMappingProvider dependencyProvider, MappingLevel mapping_level, SingletonMode mode = SingletonMode.ContainerSingleton) where TConcrete : class;
        bool RegisterWithKey<TContract, TConcrete>(string priority_key, RegisterMode mode = RegisterMode.ContainerSingleton) where TConcrete : class, TContract;  //TImplementation should either implement or inherit from TContract
        bool RegisterWithKey<TContract, TConcrete>(string priority_key, TConcrete instance, SingletonMode mode = SingletonMode.ContainerSingleton) where TConcrete : class, TContract;  //TImplementation should either implement or inherit from TContract
        bool RegisterWithKey<TContract, TConcrete>(string priority_key, IMappingProvider dependencyProvider, MappingLevel mapping_level, SingletonMode mode = SingletonMode.ContainerSingleton) where TConcrete : class, TContract;  //TImplementation should either implement or inherit from TContract
        #endregion

        #region Resolve Methods
        T Resolve<T>(ResolveMode mode = ResolveMode.AsRegistered);
        T Resolve<T>(string priority_key, ResolveMode mode = ResolveMode.AsRegistered);
        object Resolve(Type contract_type, ResolveMode mode = ResolveMode.AsRegistered);
        object Resolve(string priority_key, Type contract_type, ResolveMode mode = ResolveMode.AsRegistered);
        T Resolve<T>(IMappingProvider mapping_provider, ResolveMode mode = ResolveMode.AsRegistered, bool currentOnlyAsTransient = false);
        object Resolve(Type contract_type, IMappingProvider mapping_provider, ResolveMode mode = ResolveMode.AsRegistered, bool currentOnlyAsTransient = false);
        object Resolve(string priority_key, Type contract_type, IMappingProvider mapping_provider, ResolveMode mode = ResolveMode.AsRegistered, bool currentOnlyAsTransient = false);
        #endregion

        #region TryResolve Methods
        bool TryResolve(Type contract_type, out object concrete_instance, ResolveMode mode = ResolveMode.AsRegistered);
        bool TryResolve(string priority_key, Type contract_type, out object concrete_instance, ResolveMode mode = ResolveMode.AsRegistered);
        bool TryResolve(Type contract_type, IMappingProvider mapping_provider,out object concrete_instance, ResolveMode mode = ResolveMode.AsRegistered, bool currentOnlyAsTransient = false);
        bool TryResolve(string priority_key, Type contract_type, IMappingProvider mapping_provider,out object concrete_instance, ResolveMode mode = ResolveMode.AsRegistered, bool currentOnlyAsTransient = false);
        #endregion

        #region ResolveTransient Methods
        T ResolveTransient<T>(TransientCreationLevel transient_level);
        T ResolveTransient<T>(string priority_key, TransientCreationLevel transient_level);
        object ResolveTransient(Type contract_type, TransientCreationLevel transient_level);
        object ResolveTransient(string priority_key, Type contract_type,TransientCreationLevel transient_level);
        T ResolveTransient<T>(IMappingProvider mapping_provider, MappingLevel mapping_level = MappingLevel.CurrentWithDependencies);
        object ResolveTransient(Type contract_type, IMappingProvider mapping_provider, MappingLevel mapping_level = MappingLevel.CurrentWithDependencies);
        object ResolveTransient(string priority_key, Type contract_type,IMappingProvider mapping_provider, MappingLevel mapping_level = MappingLevel.CurrentWithDependencies);
        #endregion
    }
}
