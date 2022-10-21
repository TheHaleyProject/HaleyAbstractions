using Haley.Enums;
using System;
using System.Windows;
using System.Collections.Generic;
using System.Collections.Concurrent;
using Haley.Models;

namespace Haley.Abstractions
{
    //User should not be able to write to a service provider (it just provides)
    public interface IBaseServiceProvider : IServiceProvider
    {
        bool IsDisposed { get; }
        string Id { get; }
        string Name { get; }
        /// <summary>
        /// Doesn't work for UniversalSingleton.
        /// </summary>
        bool IgnoreParentContainer { get; }
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
