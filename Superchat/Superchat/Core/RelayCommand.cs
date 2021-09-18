using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Superchat.Core
{
    // https://youtu.be/PzP8mw7JUzI?t=200   <<< Erklärung
    class RelayCommand : ICommand
    {
        private Action<object> execute;
        private Func<object, bool> canExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<object> execute , Func<object,bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object par)
        {
            return this.canExecute == null || this.canExecute(par);
        }

        public void Execute(object par)
        {
            this.execute(par);
        }


    }
}
