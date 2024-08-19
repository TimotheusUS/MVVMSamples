using System.Collections.ObjectModel;
using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.Dynamic
{
    public class PhysicalDevicesViewModel : ViewModelBase
    {
        private PhysicalDevicesModel model = new PhysicalDevicesModel();

        private ObservableCollection<VirtualDevicesViewModel> virtualDevices = new ObservableCollection<VirtualDevicesViewModel>();

        private VirtualDevicesViewModel exchangeableViewModel;

        public PhysicalDevicesViewModel()
        {
            foreach (PhysicalDevice item in model.BunchOfDevices)
            {
                VirtualDevicesViewModel virtualDevicesViewModel = new VirtualDevicesViewModel();
                virtualDevicesViewModel.SetPhysicalDevice(item);
                virtualDevicesViewModel.Name = item.Name;
                virtualDevicesViewModel.Moderate = SetExchangeableViewModel;
                VirtualDevices.Add(virtualDevicesViewModel);
            }
        }

        public ObservableCollection<VirtualDevicesViewModel> VirtualDevices
        {
            set
            {
                virtualDevices = value;
                OnPropertyChanged(nameof(VirtualDevices));
            }
            get
            {
                return virtualDevices;
            }
        }

        public VirtualDevicesViewModel ExchangeableViewModel
        {
            get
            {
                return exchangeableViewModel;
            }
            set
            {
                exchangeableViewModel = value;
                OnPropertyChanged(nameof(ExchangeableViewModel));
            }
        }

        private void SetExchangeableViewModel(VirtualDevicesViewModel virtualDevicesViewModel)
        {
            ExchangeableViewModel = virtualDevicesViewModel;
        }
    }
}
