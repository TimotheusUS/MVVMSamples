using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Media;
using System.Xml.Serialization;
using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.DynamicGrid
{
    [Serializable]
    public class ViewModelTable : ViewModelBase
    {
        private ObservableCollection<ViewModelRow> tableData = new ObservableCollection<ViewModelRow>();
        private ObservableCollection<ViewModelStdCell> headerColumns = new ObservableCollection<ViewModelStdCell>();
        [XmlElement]
        public ObservableCollection<ViewModelRow> TableData
        {
            get => this.tableData;
            set
            {
                this.tableData = value;
                base.OnPropertyChanged(nameof(this.TableData));
            }        
        }
        [XmlIgnore]
        public ObservableCollection<ViewModelStdCell> HeaderColumns
        {
            get => this.headerColumns;
            set
            {
                this.headerColumns = value;
                base.OnPropertyChanged(nameof(this.HeaderColumns));
            }           
        }
        public void Initialize(bool isA)
        {
            if (!isA)
                Cfg1.Instance.InitializeA();
            else
                Cfg1.Instance.InitializeB();

            HeaderColumns.Clear();
            TableData.Clear();

            int collumnCount = Cfg1.Instance.Table[0].AllFeatures.Count;

            HeaderColumns.Add(new ViewModelStdCell()
            {
                Data = "-",
                Color = Brushes.Red
            });

            for (int k = 1; k < collumnCount; ++k)
            {
                HeaderColumns.Add(new ViewModelStdCell()
                {
                    Data = "Socket " + k,
                    Color = Brushes.Red
                });
            }

            for (int i = 0; i < Cfg1.Instance.Table.Count; ++i)
            {
                List<string> allFeatures = Cfg1.Instance.Table[i].AllFeatures;
                ObservableCollection<ICell> rowData = new ObservableCollection<ICell>();
                string mappingId = string.Empty;

                for (int j = 0; j < collumnCount; ++j)
                {
                    if (j == 0)
                    {
                        mappingId = allFeatures[0];
                        rowData.Add(new ViewModelHeaderRowCell() { Data = allFeatures[0], MappingId = mappingId });
                    }
                    else
                    {
                        rowData.Add(new ViewModelStdCell() { Data = allFeatures[j], MappingId = mappingId, SocketNo = j });
                    }
                }

                TableData.Add(new ViewModelRow() { Row = rowData });
                 this.Save();
               //this.Read();
            }
        }
        public void Add()
        {
            int collumnCount = Cfg1.Instance.Table[0].AllFeatures.Count;
            ObservableCollection<ICell> row = new ObservableCollection<ICell>();

            ViewModelHeaderRowCell viewModelHeaderRowCell = new ViewModelHeaderRowCell();

            row.Add(viewModelHeaderRowCell);

            for (int j = 1; j < collumnCount; ++j)
            {
                ViewModelStdCell viewModelStdCell = new ViewModelStdCell() { SocketNo = j };
                viewModelHeaderRowCell.PropertyChanged += viewModelStdCell.UpdateMappingId;

                row.Add(viewModelStdCell);
            }

            TableData.Add(new ViewModelRow()
            {
                Row = row
            });
        }
        public void Save()
        {
            //ViewModelTest viewModelTest = new ViewModelTest();

            // see note below
            //DataContractSerializer _dcs = new DataContractSerializer(typeof(IMyCell), new List<Type> { typeof(MyCell) });

            //using (FileStream fs = new FileStream("out.xml", FileMode.Create))
            //{
            //    _dcs.WriteObject(fs, viewModelTest);
            //}


            //XmlSerializer serializer = new XmlSerializer(viewModelTest.GetType());
            //TextWriter writer = new StreamWriter("out.xml");
            //serializer.Serialize(writer, this);
            //writer.Close();
        }
        public void Read()
        {
            //Stream stream = new FileStream("out.xml", FileMode.Open, FileAccess.Read);
            //XmlSerializer serializer = new XmlSerializer(typeof(ViewModelTest));
            //// TextReader reader = new StreamReader("out.xml");
            //ViewModelTest file;
            //file = (ViewModelTest)serializer.Deserialize(stream);
            //stream.Close();
        }
    }
}
