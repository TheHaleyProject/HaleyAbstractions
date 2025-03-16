using Haley.Enums;

namespace Haley.Abstractions {
    public interface IWindowContainer : IUIContainerBase<IHaleyVM> {
        #region ShowDialog Methods
        bool? ShowDialog<ViewType>(object InputViewModel, IOCResolveMode resolve_mode = IOCResolveMode.AsRegistered) where ViewType : class;
        bool? ShowDialog<ViewOrVMType>(IOCResolveMode resolve_mode = IOCResolveMode.AsRegistered) where ViewOrVMType : class;
        bool? ShowDialog(object key, object InputViewModel = null, IOCResolveMode resolve_mode = IOCResolveMode.AsRegistered);

        #endregion

        #region Show Methods
        void Show<ViewType>(object InputViewModel, IOCResolveMode resolve_mode = IOCResolveMode.AsRegistered) where ViewType : class;
        void Show<ViewOrVMType>(IOCResolveMode resolve_mode = IOCResolveMode.AsRegistered) where ViewOrVMType : class;
        void Show(object key, object InputViewModel = null, IOCResolveMode resolve_mode = IOCResolveMode.AsRegistered);
        #endregion
    }
}
