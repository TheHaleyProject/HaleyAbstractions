﻿using Haley.Abstractions;
using Haley.Events;
using System;

namespace Haley.Models {
    public class BaseVM : ChangeNotifier, IHaleyVM {
        public event EventHandler<FrameClosingEventArgs> ViewModelClosed;
        public event EventHandler<EventArgs> ViewLoaded;
        public virtual void OnViewLoaded(object sender) {
            //Send event.
            ViewLoaded?.Invoke(sender, null);
        }

        protected void InvokeVMClosed(object sender, FrameClosingEventArgs e) {
            ViewModelClosed?.Invoke(sender, e);
        }

        protected void InvokeVMClosed(object sender, bool result) {
            ViewModelClosed?.Invoke(sender, new FrameClosingEventArgs(result, null));
        }
        public BaseVM() { }
    }
}
