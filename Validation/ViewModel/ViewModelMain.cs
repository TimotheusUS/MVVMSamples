using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.Validation
{
    public class ViewModelMain : ViewModelBase
    {
        private ViewModel1 viewModel1;

        public ViewModelMain()
        {
            viewModel1 = new ViewModel1();
        }

        public ViewModel1 TheViewModel1
        {
            get { 
             return viewModel1; }
            set
            {
                viewModel1 = value;
                OnPropertyChanged(nameof(TheViewModel1));
            }
        }
       
    }
}
