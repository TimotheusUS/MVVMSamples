using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.PropertyChanged
{
    public class ViewModelMain : ViewModelBase
    {
        private ViewModelClassic viewModelClassic1;
        private ViewModelNew viewModelNew1;

        public ViewModelMain()
        {
            viewModelClassic1 = new ViewModelClassic();
            viewModelNew1 = new ViewModelNew();
        }

        public ViewModelClassic ViewModelClassic1
        {
            get
            {
                return viewModelClassic1;
            }
            set
            {
                viewModelClassic1 = value;
                OnPropertyChanged(nameof(ViewModelClassic1));
            }
        }

        public ViewModelNew ViewModelNew1
        {
            get
            {
                return viewModelNew1;
            }
            set
            {
                viewModelNew1 = value;
                OnPropertyChanged(nameof(ViewModelNew1));
            }
        }
    }
}
