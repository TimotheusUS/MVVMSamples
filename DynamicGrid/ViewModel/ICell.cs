using System.Windows.Media;
using System.Xml.Serialization;

namespace TimotheusUS.MVVMsamples.DynamicGrid
{
    public interface ICell
    {
        [XmlElement]
        string MappingId { get; set; }
        [XmlElement]
        int Width { get; set; }
        [XmlElement]
        Brush Color { get; set; }
    }
}
