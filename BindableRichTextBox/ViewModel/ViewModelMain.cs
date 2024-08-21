using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.BindableRichTextBox
{
    public class ViewModelMain : ViewModelBase
    {
        private ViewModel1 viewModel1;

        public ViewModelMain()
        {
            viewModel1 = new ViewModel1();
        }

        public ViewModel1 ViewModel1
        {
            get
            {
                return viewModel1;
            }
            set
            {
                viewModel1 = value;
                OnPropertyChanged(nameof(this.ViewModel1));
            }
        }
    }
}
