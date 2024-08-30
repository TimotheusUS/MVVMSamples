using System.Collections.ObjectModel;
using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.DynamicGrid
{
    public class ViewModelTable : ViewModelBase
    {
        private ObservableCollection<ViewModelRow> tableData = new ObservableCollection<ViewModelRow>();
        private ObservableCollection<ViewModelStdCell> headerRows = new ObservableCollection<ViewModelStdCell>();
        private ObservableCollection<ViewModelHeaderColumnCell> headerColumns = new ObservableCollection<ViewModelHeaderColumnCell>();

        public ObservableCollection<ViewModelRow> TableData
        {
            get => tableData;
            set
            {
                tableData = value;
                OnPropertyChanged(nameof(TableData));
            }
        }

        public ObservableCollection<ViewModelStdCell> HeaderRows
        {
            get => headerRows;
            set
            {
                headerRows = value;
                OnPropertyChanged(nameof(HeaderRows));
            }
        }

        public ObservableCollection<ViewModelHeaderColumnCell> HeaderColumns
        {
            get => headerColumns;
            set
            {
                headerColumns = value;
                OnPropertyChanged(nameof(HeaderColumns));
            }
        }

        public void Initialize(bool isA)
        {
            InitializeConfiguration(isA);
            ClearCollections();

            int columnCount = Cfg1.Instance.Table[0].AllFeatures.Count;

            InitializeHeaderColumns(columnCount);
            InitializeHeaderRows(columnCount);
            PopulateTableData(columnCount);
        }

        public void AddRow()
        {
            int columnCount = Cfg1.Instance.Table[0].AllFeatures.Count;
            var row = new ObservableCollection<ICell>();

            var headerRowCell = new ViewModelHeaderRowCell();
            row.Add(headerRowCell);

            for (int j = 1; j < columnCount; j++)
            {
                var stdCell = new ViewModelStdCell { SocketNo = j };
                headerRowCell.PropertyChanged += stdCell.UpdateMappingId;
                row.Add(stdCell);
            }

            TableData.Add(new ViewModelRow { Row = row });
        }

        private void InitializeConfiguration(bool isA)
        {
            if (isA)
            {
                Cfg1.Instance.InitializeB();
            }
            else
            {
                Cfg1.Instance.InitializeA();
            }
        }

        private void ClearCollections()
        {
            HeaderRows.Clear();
            TableData.Clear();
        }

        private void InitializeHeaderColumns(int columnCount)
        {
            HeaderColumns.Clear();

            for (int k = 0; k < columnCount; k++)
            {
                HeaderColumns.Add(new ViewModelHeaderColumnCell { Name = k.ToString() });
            }
        }

        private void InitializeHeaderRows(int columnCount)
        {
            HeaderRows.Clear();
            HeaderRows.Add(new ViewModelStdCell { Data = "-" });

            for (int k = 1; k < columnCount; k++)
            {
                HeaderRows.Add(new ViewModelStdCell { Data = $"Socket {k}" });
            }
        }

        private void PopulateTableData(int columnCount)
        {
            foreach (var tableEntry in Cfg1.Instance.Table)
            {
                var allFeatures = tableEntry.AllFeatures;
                var rowData = new ObservableCollection<ICell>();
                string mappingId = allFeatures[0];

                rowData.Add(new ViewModelHeaderRowCell { Data = mappingId, MappingId = mappingId });

                for (int j = 1; j < columnCount; j++)
                {
                    rowData.Add(new ViewModelStdCell
                    {
                        Data = allFeatures[j],
                        MappingId = mappingId,
                        SocketNo = j
                    });
                }

                TableData.Add(new ViewModelRow { Row = rowData });
            }
        }
    }
}
