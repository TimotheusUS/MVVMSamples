using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.FlexibleGUI
{
    public class ViewModelMain : ViewModelBase
    {
        private ViewModel1 viewModel1 = new ViewModel1();
        private ViewModel2 viewModel2 = new ViewModel2();
        private ViewModel3 viewModel3 = new ViewModel3();

        public ViewModelMain() { }
        public ViewModel1 ViewModel1
        {
            get
            {
                return this.viewModel1;
            }
            set
            {
                this.viewModel1 = value;
                OnPropertyChanged(nameof(this.ViewModel1));
            }
        }
        public ViewModel2 ViewModel2
        {
            get { return this.viewModel2; }
            set
            {
                this.viewModel2 = value;
                OnPropertyChanged(nameof(this.ViewModel2));
            }
        }
        public ViewModel3 ViewModel3
        {
            get { return this.viewModel3; }
            set
            {
                this.viewModel3 = value;
                OnPropertyChanged(nameof(this.ViewModel3));
            }
        }
    }
}
