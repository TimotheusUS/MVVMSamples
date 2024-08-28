using System;
using System.ComponentModel;
using System.Windows.Media;
using System.Xml.Serialization;
using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.DynamicGrid
{
    [Serializable]
    public class ViewModelStdCell : ViewModelBase, ICell
    {
        private string selectedChannel;

        [XmlElement]
        public string Data
        { get; set; }

        [XmlElement]
        public int Width
        { get; set; } = 150;

        [XmlElement]
        public Brush Color
        { get; set; } = Brushes.Blue;

        [XmlElement]
        public int SocketNo { get; set; }

        [XmlElement]
        public string MappingId { get; set; }

        [XmlElement]
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
