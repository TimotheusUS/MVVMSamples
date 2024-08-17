using System.Windows.Input;
using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.Easy
{
    public class ViewModelMain : ViewModelBase
    {
        private ViewModel1 viewModel1 = new ViewModel1();
        private ViewModel2 viewModel2 = new ViewModel2();
        private RelayCommand closedCommand;
        public ViewModelMain() => this.closedCommand = new RelayCommand(ViewModel2.Stop);

        public ViewModel1 ViewModel1
        {
            get => this.viewModel1;
            set
            {
                this.viewModel1 = value;
                base.OnPropertyChanged(nameof(this.ViewModel1));
            }
        }
        public ViewModel2 ViewModel2
        {
            get => this.viewModel2;
            set
            {
                this.viewModel2 = value;
                base.OnPropertyChanged(nameof(this.ViewModel2));
            }
        }
        public ICommand ClosedCommand
        {
            get => this.closedCommand;
        }
    }
}