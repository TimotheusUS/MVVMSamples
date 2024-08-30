using System.Collections.ObjectModel;
using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.DynamicGrid
{
    public class ViewModelRow : ViewModelBase
    {
        private ObservableCollection<ICell> row;
       
        public ObservableCollection<ICell> Row
        {
            get
            {
                return row;
            }
            set
            {
                row = value;
                OnPropertyChanged(nameof(row));
            }
        }
    }
}
