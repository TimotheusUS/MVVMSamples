using System;
using System.Windows.Input;

public class RelayCommand : ICommand
{
    private readonly Action<object> execute;
    private readonly Func<object, bool> canExecute;

    public RelayCommand(Action execute)
    {
        this.execute = ConvertToActionWithParameter(execute) ?? throw new ArgumentNullException(nameof(execute));
        this.canExecute = canExecute ?? (x => true);
    }

    public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
    {
        this.execute = execute ?? throw new ArgumentNullException(nameof(execute));
        this.canExecute = canExecute ?? (x => true);
    }

    public bool CanExecute(object parameter) => canExecute(parameter);
    
    public void Execute(object parameter) => execute(parameter);

    public event EventHandler CanExecuteChanged;

    public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);

    private Action<object> ConvertToActionWithParameter(Action actionWithoutParameter) => _ => actionWithoutParameter();
}
