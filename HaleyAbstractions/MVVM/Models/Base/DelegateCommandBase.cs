using System;
using System.Windows.Input;

namespace Haley.Models {
    public class DelegateCommandBase : DelegateCommandBase<object> {
        public DelegateCommandBase(Action ActionMethod, Func<bool> ValidationFunction) : base((p) => ActionMethod(), (p) => ValidationFunction()) {
            //For actions without the need for any parameters. 
        }

        public DelegateCommandBase(Action ActionMethod) : base((p) => ActionMethod()) {
        }
    }


    public class DelegateCommandBase<T> : ICommand {
        //public string ID { get; }
        Action<T> _action; //actual action to handle
        Func<T, bool> _validation; // validate to check if this command can be executed.
        //public virtual event EventHandler CanExecuteChanged;

        public virtual bool CanExecute(object parameter) {
            try {
                if (_validation == null) return true;
                T _param = (parameter != null) ? (T)parameter : default(T);
                return _validation.Invoke(_param);
            } catch (Exception) {
                return false;
            }
        }

        public virtual void Execute(object parameter) {
            try {
                _action?.Invoke((T)parameter);
            } catch (Exception) {
            }
        }

        public DelegateCommandBase(Action<T> ActionMethod, Func<T, bool> ValidationFunction) {
            _action = ActionMethod;
            _validation = ValidationFunction;
            //ID = Guid.NewGuid().ToString();
        }

        public DelegateCommandBase(Action<T> ActionMethod) : this(ActionMethod, null) {

        }

        EventHandler _internalCanExecute;

        public virtual event EventHandler CanExecuteChanged {
            add { _internalCanExecute += value; }
            remove { _internalCanExecute -= value; }
        }

        [Obsolete("Replace with Invalidate()", true)]
        public void RaiseCanExecuteChanged() { }

        public virtual void Invalidate() {
            var handler = this._internalCanExecute;
            if (handler == null) return;
            handler(this, EventArgs.Empty);
        }
    }
}
