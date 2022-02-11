using Haley.Enums;
using System;

namespace Haley.Abstractions
{
    public interface IWindowContainer: IUIContainerBase<IHaleyVM>
    {
        #region ShowDialog Methods
        bool? ShowDialog<VMType>(VMType InputViewModel = null, ResolveMode resolve_mode = ResolveMode.AsRegistered) where VMType : class, IHaleyVM;
        bool? ShowDialog<ViewType>(ResolveMode resolve_mode = ResolveMode.AsRegistered) where ViewType : class;
        bool? ShowDialog(string key, object InputViewModel = null, ResolveMode resolve_mode = ResolveMode.AsRegistered);
        bool? ShowDialog(Enum key, object InputViewModel = null, ResolveMode resolve_mode = ResolveMode.AsRegistered);

        #endregion

        #region Show Methods
        void Show<VMType>(VMType InputViewModel = null, ResolveMode resolve_mode = ResolveMode.AsRegistered) where VMType : class, IHaleyVM;
        void Show<ViewType>(ResolveMode resolve_mode = ResolveMode.AsRegistered) where ViewType : class;
        void Show(string key, object InputViewModel = null, ResolveMode resolve_mode = ResolveMode.AsRegistered);
        void Show(Enum key, object InputViewModel = null, ResolveMode resolve_mode = ResolveMode.AsRegistered);
        #endregion
    }
}
