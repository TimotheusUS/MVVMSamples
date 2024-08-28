using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.DynamicGrid
{
    [Serializable]
    public class ViewModelRow : ViewModelBase
    {
        private ObservableCollection<ICell> row;
       
        [XmlElement]
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
