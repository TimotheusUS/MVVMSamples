using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Documents;
using System.Windows.Input;
using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.RelativeSource
{
    public class ViewModelPreviousData : ViewModelBase
    {
        private ObservableCollection<ViewModelItem> items = new ObservableCollection<ViewModelItem>();
        private ICommand deleteLastCommand;
        public ViewModelPreviousData() => deleteLastCommand = new RelayCommand(this.DeleteLast);
        private void DeleteLast()
        {
            if (items.Count > 0)
                this.Items.RemoveAt(this.items.Count - 1);
        }
        public ObservableCollection<ViewModelItem> Items
        {
            get => this.items;
            set
            {
                this.items = value;
                OnPropertyChanged(nameof(this.Items));
            }
        }
        public ICommand DeleteLastCommand
        {
            get => this.deleteLastCommand;
        }
    }
}
