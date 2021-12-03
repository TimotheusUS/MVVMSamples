using System.Windows.Input;
using MVVMSamples.Tools;

namespace MVVMSamples.Easy
{
    public class ViewModelMain : ViewModelBase
    {
        private ViewModelClearFocusOnClick viewModelClearFocusOnClick = new ();
        public ViewModelClearFocusOnClick ViewModelClearFocusOnClick1
        {
            get => this.viewModelClearFocusOnClick;
            set
            {
                this.viewModelClearFocusOnClick = value;
                base.OnPropertyChanged(nameof(this.ViewModelClearFocusOnClick1));
            }
        }
    }
}