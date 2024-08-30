using System.Windows.Media;
using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.DynamicGrid
{
    public class ViewModelHeaderRowCell : ViewModelBase, ICell
    {
        public string mappingId;

        public string Data
        { get; set; }

        public string MappingId
        {
            set
            {
                mappingId = value;
                OnPropertyChanged(nameof(MappingId));
            }
            get
            {
                return mappingId;
            }
        }
    }
}
