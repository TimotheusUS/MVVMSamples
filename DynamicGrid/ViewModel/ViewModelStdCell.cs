using System.ComponentModel;
using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.DynamicGrid
{
    public class ViewModelStdCell : ViewModelBase, ICell
    {
        private string selectedChannel;

        public string Data
        { get; set; }

        public int SocketNo { get; set; }

        public string MappingId { get; set; }

        public string SelectedChannel
        {
            set
            {
                selectedChannel = value;
                OnPropertyChanged(nameof(SelectedChannel));
            }
            get
            {
                return selectedChannel;
            }
        }

        public void UpdateMappingId(object sender, PropertyChangedEventArgs e)
        {
            MappingId = (sender as ViewModelHeaderRowCell).MappingId;
        }
    }
}
