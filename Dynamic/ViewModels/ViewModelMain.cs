using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.Dynamic
{
    public class ViewModelMain : ViewModelBase
    {
        private PhysicalDevicesViewModel _physicalDevicesViewModel;

        public ViewModelMain()
        {
            _physicalDevicesViewModel = new PhysicalDevicesViewModel();
        }

        public PhysicalDevicesViewModel _PhysicalDevicesViewModel
        {
            get { 
             return _physicalDevicesViewModel; }
            set
            {
                _physicalDevicesViewModel = value;
                OnPropertyChanged(nameof(_PhysicalDevicesViewModel));
            }
        }
    }
}
