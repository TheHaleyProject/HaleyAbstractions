using Haley.Enums;

namespace Haley.Abstractions
{
    public interface IControlContainer : IUIContainerBase<IHaleyVM> 
    {
        //Here we set use_vm_as_key = false;by default. Because, for controls, we might need to get them by view. 
        new string Register<VMType, ViewType>(VMType InputViewModel = null, bool use_vm_as_key = false, RegisterMode mode = RegisterMode.ContainerSingleton)
           where VMType : class, IHaleyVM
           where ViewType : class;
    }
}
