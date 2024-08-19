using System;

namespace TimotheusUS.MVVMsamples.Dynamic
{
    [Flags]
    public enum DeviceType { NONE = 0, Measure = 1, Switch = 2, Power = 4 };
    public class PhysicalDevice
    {
        public string Name { get; set; }
        public DeviceType AllDeviceTypes { get; set; }
    }
}
