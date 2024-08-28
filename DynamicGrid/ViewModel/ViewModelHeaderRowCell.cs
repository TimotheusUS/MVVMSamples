using System;
using System.Windows.Media;
using System.Xml.Serialization;
using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.DynamicGrid
{
    [Serializable]
    public class ViewModelHeaderRowCell : ViewModelBase, ICell
    {
        public string mappingId;
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
