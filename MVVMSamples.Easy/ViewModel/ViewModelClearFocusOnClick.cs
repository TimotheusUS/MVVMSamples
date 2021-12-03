using MVVMSamples.Tools;

namespace MVVMSamples.Easy
{
    public class ViewModelClearFocusOnClick : ViewModelBase
    {
        private string someText1;
        private string someText2;
        private string someText3;
        public string SomeText1
        {
            get => this.someText1;
            set
            {
                this.someText1 = value;
                base.OnPropertyChanged(nameof(this.SomeText1));
            }
        }
        public string SomeText2
        {
            get => this.someText2;
            set
            {
                this.someText2 = value;
                base.OnPropertyChanged(nameof(this.SomeText2));
            }
        }
        public string SomeText3
        {
            get => this.someText3;
            set
            {
                this.someText3 = value;
                base.OnPropertyChanged(nameof(this.SomeText3));
            }
        }
    }
}
