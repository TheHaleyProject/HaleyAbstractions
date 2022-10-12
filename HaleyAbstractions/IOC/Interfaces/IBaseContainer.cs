using Haley.Enums;
using System;
using System.Windows;
using System.Collections.Generic;
using System.Collections.Concurrent;
using Haley.Models;

namespace Haley.Abstractions
{
    public interface IBaseContainer : IBaseServiceProvider,IDisposable
    {
        event EventHandler<IBaseContainer> ChildCreated;
        event EventHandler<string> ContainerDisposed;
        bool ResolveOnlyOnDemand { get; }
        void SetResolveOnlyOnDemandMode(bool flag);
        ExceptionHandling ErrorHandling { get; set; }
        bool TrySetResolutionOverride(Func<ResolveLoad, string, object> overrideCallback); //Can be set only once.
        /// <summary>
        /// Create a child container
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ignoreParents">Will not ignore the UniversalSingleton Resolutions</param>
        /// <returns></returns>
        IBaseContainer CreateChildContainer(string name = null,bool stopCheckingParents = false);

        /// <summary>
        /// Gets the top level child container
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IBaseContainer GetChildContainer(string id);
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

        #region LazyRegister
        bool LazyRegister<TConcrete>(Func<TConcrete> del = null, SingletonMode mode = SingletonMode.ContainerSingleton) where TConcrete : class;
        bool LazyRegister<TContract, TConcrete>(Func<TConcrete> del =null, SingletonMode mode = SingletonMode.ContainerSingleton) where TConcrete : class, TContract;  //TImplementation should either implement or inherit from TContract
        bool LazyRegisterWithKey<TConcrete>(string priority_key, Func<TConcrete> del = null, SingletonMode mode = SingletonMode.ContainerSingleton) where TConcrete : class;
        bool LazyRegisterWithKey<TContract, TConcrete>(string priority_key, Func<TConcrete> del =null, SingletonMode mode = SingletonMode.ContainerSingleton) where TConcrete : class, TContract;  //TImplementation should either implement or inherit from TContract
        #endregion

        bool RegisterLoad(RegisterLoad load);  //Direct register
    }
}
