using Haley.Enums;
using Haley.Models;
using System;

namespace Haley.Abstractions {
    public interface IUIContainerBase<BaseVMType> {
        string Id { get; }

        #region Registration methods
        string Register<VMType, ViewType>(VMType InputViewModel = null, bool use_vm_as_key = true, IOCRegisterMode mode = IOCRegisterMode.ContainerSingleton)
            where VMType : class, BaseVMType
            where ViewType : class;
        string RegisterWithKey<VMType, ViewType>(object key, VMType InputViewModel = null, IOCRegisterMode mode = IOCRegisterMode.ContainerSingleton, bool groupByKey = false)
            where VMType : class, BaseVMType
            where ViewType : class;

        string LazyRegister<VMType, ViewType>(Func<VMType> creator = null, bool use_vm_as_key = true, IOCRegisterMode mode = IOCRegisterMode.ContainerSingleton)
            where VMType : class, BaseVMType
            where ViewType : class;
        string LazyRegisterWithKey<VMType, ViewType>(object key, Func<VMType> creator = null, IOCRegisterMode mode = IOCRegisterMode.ContainerSingleton, bool groupByKey = false)
            where VMType : class, BaseVMType
            where ViewType : class;
        #endregion

        #region View Generation Methods
        object GenerateView<viewmodelType>(viewmodelType InputViewModel = null, IOCResolveMode mode = IOCResolveMode.AsRegistered)
            where viewmodelType : class, BaseVMType;
        viewType GenerateView<viewType>(object InputViewModel = null, IOCResolveMode mode = IOCResolveMode.AsRegistered)
            where viewType : class;
        object GenerateViewFromKey(object key, object InputViewModel = null, IOCResolveMode mode = IOCResolveMode.AsRegistered);

        #endregion

        #region ViewModel Generation methods
        BaseVMType GenerateViewModelFromKey(object key, IOCResolveMode mode = IOCResolveMode.AsRegistered);
        UIGroupInfo GetMappingValue(Enum @enum);
        UIGroupInfo GetMappingValue(string key);
        string FindKey(Type target_type);

        /// <summary>
        /// Check if this key is already registered.
        /// </summary>
        /// <param name="key">Should either be string or Enum</param>
        /// <returns></returns>
        bool? ContainsKey(object key);
        #endregion
    }
}
