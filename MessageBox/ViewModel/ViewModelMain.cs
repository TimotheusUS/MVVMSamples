using System.Windows.Input;
using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.MessageBox
{
    public class ViewModelMain : ViewModelBase
    {
        private ViewModel1 viewModel1; 
        private static ViewModelMessageBox viewModelMessageBox1 = new ViewModelMessageBox();
        private RelayCommand openPopupCommand;
        public ViewModelMain()
        {
            this.openPopupCommand = new RelayCommand(this.OpenPopup);
            this.viewModel1 = new ViewModel1(new Model1());
        }
        private void OpenPopup()
        {
            viewModelMessageBox1.IsEnabled = true;
            viewModelMessageBox1.Message = "Hello";
        }
        public ViewModel1 ViewModel1
        {
            get => this.viewModel1;
            set
            {
                this.viewModel1 = value;
                base.OnPropertyChanged(nameof(this.ViewModel1));
            }
        }
        public ViewModelMessageBox ViewModelMessageBox1
        {
            get => viewModelMessageBox1;
            set
            {
                viewModelMessageBox1 = value;
                base.OnPropertyChanged(nameof(this.ViewModelMessageBox1));
            }
        }
        public ICommand OpenPopupCommand
        {
            get => this.openPopupCommand;
        }
        public static void Show(string message)
        {
            viewModelMessageBox1.IsEnabled = true;
            viewModelMessageBox1.Message = message;
        }
    }
}