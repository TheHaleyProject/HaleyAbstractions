using Haley.Enums;
using System;

namespace Haley.Abstractions
{
    public interface IUIContainerBase<BaseVMType> 
    {
        string Id { get;}

        #region registration methods
        string Register<VMType, ViewType>(VMType InputViewModel=null, bool use_vm_as_key = true, RegisterMode mode = RegisterMode.ContainerSingleton)
            where VMType : class, BaseVMType
            where ViewType : class;
        string Register<VMType, ViewType>(object key, VMType InputViewModel = null, RegisterMode mode = RegisterMode.ContainerSingleton)
            where VMType : class, BaseVMType
            where ViewType : class;

        string DelegateRegister<VMType, ViewType>(Func<VMType> creator, bool use_vm_as_key = true, RegisterMode mode = RegisterMode.ContainerSingleton)
            where VMType : class, BaseVMType
            where ViewType : class;
        string DelegateRegister<VMType, ViewType>(object key, Func<VMType> creator, RegisterMode mode = RegisterMode.ContainerSingleton)
            where VMType : class, BaseVMType
            where ViewType : class;
        #endregion

        #region View Generation Methods
        object GenerateView<viewmodelType>(viewmodelType InputViewModel = null, ResolveMode mode = ResolveMode.AsRegistered)
            where viewmodelType : class, BaseVMType;
        viewType GenerateView<viewType>(object InputViewModel = null, ResolveMode mode = ResolveMode.AsRegistered)
            where viewType : class;
        object GenerateViewFromKey(object key, object InputViewModel = null, ResolveMode mode = ResolveMode.AsRegistered);

        #endregion

        #region ViewModel Generation methods
        BaseVMType GenerateViewModelFromKey(object key, ResolveMode mode = ResolveMode.AsRegistered);
        (Type viewmodel_type, Type view_type, RegisterMode registered_mode) GetMappingValue(Enum @enum);
        (Type viewmodel_type, Type view_type, RegisterMode registered_mode) GetMappingValue(string key);
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
