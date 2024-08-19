using System.Collections.Generic;

namespace TimotheusUS.MVVMsamples.Dynamic
{
    public class PhysicalDevicesModel
    {
        public List<PhysicalDevice> BunchOfDevices { get; } = new List<PhysicalDevice>()
        {
            new PhysicalDevice() { Name = "Compact SCU", AllDeviceTypes = DeviceType.Measure | DeviceType.Switch },
            new PhysicalDevice() { Name = "ESNG 600", AllDeviceTypes = DeviceType.Power }
        };
    }
}