using Haley.Events;
using System;

namespace Haley.Abstractions {
    public interface IHaleyVM {
        event EventHandler<FrameClosingEventArgs> ViewModelClosed;

        void OnViewLoaded(object sender);
    }
}
