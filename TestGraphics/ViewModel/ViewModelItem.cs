using System;
using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.TestGraphics
{
    public class ViewModelItem : ViewModelBase
    {
        private string itemValue;
        private DateTime dateOfGeneration;
        public string ItemValue
        {
            get => this.itemValue;
            set
            {
                this.itemValue = value;
                this.OnPropertyChanged(nameof(this.ItemValue));
            }
        }
        public DateTime DateOfGeneration
        {
            get => this.dateOfGeneration;
            set
            {
                this.dateOfGeneration = value;
                this.OnPropertyChanged(nameof(DateOfGeneration));
            }
        }
    }
}
