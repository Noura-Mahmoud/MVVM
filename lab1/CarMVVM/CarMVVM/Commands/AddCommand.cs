using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CarMVVM.Commands
{
    internal class AddCommand : ICommand
    {
        public Action<object> execute { get; }
        public Predicate<object> canExecute { get; }

        public event EventHandler? CanExecuteChanged;
        public AddCommand(Action<object> _execute, Predicate<object> _CanExecute)
        {
            execute = _execute;
            canExecute = _CanExecute;
        }
        public bool CanExecute(object? parameter)
        {
            return canExecute == null ? true : canExecute.Invoke(parameter);
        }

        public void Execute(object? parameter)
        {
            execute.Invoke(parameter);
        }
    }
}
