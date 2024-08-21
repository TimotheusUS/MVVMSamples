using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.FlexibleGUI
{
    public class ViewModel3 : ViewModelBase
    {
        private readonly Model3 model3 = new Model3();
        public string Header
        {
            get => this.model3.Name;
        }
    }
}