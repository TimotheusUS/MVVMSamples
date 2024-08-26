using System.Windows.Input;
using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.MessageBox
{
    public class ViewModelMessageBox : ViewModelBase
    {
        private ICommand closeCommand;
        private bool isEnabled = false;
        private string message;
        public ViewModelMessageBox() => this.closeCommand = new RelayCommand(this.Close);
        public string Message
        {
            get => this.message;
            set
            {
                this.message = value;
                base.OnPropertyChanged(nameof(this.Message));
            }
        }
        public ICommand CloseCommand
        {
            get => this.closeCommand;
        }
        public bool IsEnabled
        {
            get => this.isEnabled;
            set
            {
                this.isEnabled = value;
                base.OnPropertyChanged(nameof(this.IsEnabled));
            }
        }
        private void Close()
        {
            this.IsEnabled = false;
        }
    }
}
