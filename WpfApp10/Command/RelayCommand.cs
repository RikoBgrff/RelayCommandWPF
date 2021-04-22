using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp10.Command
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }

        }

        private Action<object> _execute;
        private Predicate<object> __canExecute;
        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            if(execute == null)
            {
                throw new NullReferenceException();
            }
            _execute = execute;
            __canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return __canExecute == null ? true : __canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute.Invoke(parameter);
        }
    }
        
    }

