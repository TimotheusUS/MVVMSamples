using System;
using System.Windows.Input;

namespace MVVMSamples.Tools
{
    public class RelayCommand : ICommand
    {
        private readonly Action action;
        public RelayCommand(Action action) => this.action = action;        
        public void Execute(object parameter) => this.action();        
        public bool CanExecute(object parameter) => true;        
#pragma warning disable 67
        public event EventHandler CanExecuteChanged;
#pragma warning restore 67
    }
}