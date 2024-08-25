using System.Collections.ObjectModel;
using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.Tree
{
    public class ViewModelProject : ViewModelBase
    {
        public string Name { get; set; }
        public ObservableCollection<ViewModelRequrirement> Requrirements { get; set; }
    }
}
