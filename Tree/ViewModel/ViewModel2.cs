using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.Tree
{
    public class ViewModel2 : ViewModelBase
    {
        private readonly Model2 model2 = new Model2();
        public string Header
        {
            get => this.model2.Name;
        }
    }
}
