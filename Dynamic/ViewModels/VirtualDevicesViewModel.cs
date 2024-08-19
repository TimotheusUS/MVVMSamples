using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.Dynamic
{
    public class VirtualDevicesViewModel : ViewModelBase
    {
        private ObservableCollection<ViewModelBase> virtualDevices = new ObservableCollection<ViewModelBase>();

        public Action<VirtualDevicesViewModel> Moderate;        

        public ObservableCollection<ViewModelBase> VirtualDevices
        {
            get
            {
                return virtualDevices;
            }
            set
            {
                virtualDevices = value;
                OnPropertyChanged(nameof(VirtualDevices));
            }
        }

        public ICommand LoadMVVMCommand
        {
            get
            {
                return new RelayCommand(() => Moderate(this));
            }
        }

        public void SetPhysicalDevice(PhysicalDevice physicalDevice)
        {
            if ((physicalDevice.AllDeviceTypes & DeviceType.Measure) == DeviceType.Measure)
            {
                VirtualDevices.Add(new MeasureViewModel());
            }

            if ((physicalDevice.AllDeviceTypes & DeviceType.Switch) == DeviceType.Switch)
            {
                VirtualDevices.Add(new SwitchViewModel());
            }

            if ((physicalDevice.AllDeviceTypes & DeviceType.Power) == DeviceType.Power)
            {
                VirtualDevices.Add(new SwitchViewModel());
            }
        }
    }
}
