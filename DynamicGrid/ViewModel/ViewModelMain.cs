using System;
using System.ComponentModel;
using System.Windows.Input;
using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.DynamicGrid
{
    public class ViewModelMain : ViewModelBase
    {
        private ViewModelTable viewModelTable = new ViewModelTable();
        private int selectedColumnsRowsCount = 0;

        public ViewModelMain() => this.PropertyChanged += ViewModelMain_PropertyChanged;

        public int SelectedColumnsRowsCount
        {
            get => selectedColumnsRowsCount;
            set
            {
                selectedColumnsRowsCount = value;
                OnPropertyChanged(nameof(SelectedColumnsRowsCount));
            }
        }

        public ICommand AddCommand
        {
            get => new RelayCommand(this.viewModelTable.AddRow);
        }

        public ViewModelTable ViewModelTable
        {
            get => this.viewModelTable;
            set
            {
                this.viewModelTable = value;
                base.OnPropertyChanged(nameof(this.ViewModelTable));
            }
        }

        private void ViewModelMain_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(this.SelectedColumnsRowsCount))
                this.viewModelTable.Initialize(Convert.ToBoolean(this.selectedColumnsRowsCount));
        }
    }
}