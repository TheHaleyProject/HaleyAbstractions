using Haley.Enums;

namespace Haley.Abstractions {
    public interface IWindowContainer : IUIContainerBase<IHaleyVM> {
        #region ShowDialog Methods
        bool? ShowDialog<ViewType>(object InputViewModel, ResolveMode resolve_mode = ResolveMode.AsRegistered) where ViewType : class;
        bool? ShowDialog<ViewOrVMType>(ResolveMode resolve_mode = ResolveMode.AsRegistered) where ViewOrVMType : class;
        bool? ShowDialog(object key, object InputViewModel = null, ResolveMode resolve_mode = ResolveMode.AsRegistered);

        #endregion

        #region Show Methods
        void Show<ViewType>(object InputViewModel, ResolveMode resolve_mode = ResolveMode.AsRegistered) where ViewType : class;
        void Show<ViewOrVMType>(ResolveMode resolve_mode = ResolveMode.AsRegistered) where ViewOrVMType : class;
        void Show(object key, object InputViewModel = null, ResolveMode resolve_mode = ResolveMode.AsRegistered);
        #endregion
    }
}
