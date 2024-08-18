using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.RelativeSource
{
    public class ViewModelItem : ViewModelBase
    {
        private double value;
        public double Value
        {
            get => value; 
            set { this.value = value; OnPropertyChanged(nameof(this.Value)); }
        }
    }
}
