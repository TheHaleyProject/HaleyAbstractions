using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Windows.Input;
using System.Reflection;
using System.Windows;

namespace Haley.Models
{
   public class RelayCommand : RelayCommand<object>
    {
        public RelayCommand(Action ActionMethod, Func<bool> ValidationFunction) :base((p)=>ActionMethod(), (p)=> ValidationFunction())
        {
            //For actions without the need for any parameters. 
        }

        public RelayCommand(Action ActionMethod) : base((p)=>ActionMethod())
        {
        }
    }

    
    public class RelayCommand<T> : ICommand
    {
        Action<T> _action; //actual action to handle
        Func<T, bool> _validation; // validate to check if this command can be executed.
        public virtual event EventHandler CanExecuteChanged;

        //public event EventHandler CanExecuteChanged
        //{
        //    add { CommandManager.RequerySuggested += value; }
        //    remove { CommandManager.RequerySuggested -= value; }
        //}

        public virtual bool CanExecute(object parameter)
        {
            try {
                if (_validation == null) return true;
                T _param = (parameter != null) ? (T)parameter : default(T);
                return _validation.Invoke(_param);
            } catch (Exception) {
                return false;
            }
        }

        public virtual void Execute(object parameter)
        {
            try {
                _action?.Invoke((T)parameter);
            } catch (Exception) {
            }
        }

        public RelayCommand(Action<T> ActionMethod, Func<T, bool> ValidationFunction)
        {
            _action = ActionMethod;
            _validation = ValidationFunction;
        }

        public RelayCommand(Action<T> ActionMethod)
        {
            _action = ActionMethod;
            _validation = null;
        }

        public virtual void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty); //When user decides to manually invoke and let know that can execute has been changed.
        }
    }
}
