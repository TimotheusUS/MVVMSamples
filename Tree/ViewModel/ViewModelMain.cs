using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.Tree
{
    public class ViewModelMain : ViewModelBase
    {
        public ViewModelProjectManager ViewModelProjectManager1
        {
            get;
        } = new ViewModelProjectManager();
        public ViewModel2 ViewModel2
        {
            get;
        } = new ViewModel2();
    }
}
