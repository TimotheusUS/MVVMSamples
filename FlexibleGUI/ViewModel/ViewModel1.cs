using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.FlexibleGUI
{
    public class ViewModel1 : ViewModelBase
    {
        private readonly Model1 model1 = new Model1();       
        public string Header
        {
            get => this.model1.Name;
        }
    }
}
