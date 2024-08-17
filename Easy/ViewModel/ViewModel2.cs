using System;
using System.Collections.ObjectModel;
using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.Easy
{
    public class ViewModel2 : ViewModelBase
    {        
        private readonly Model2 model2 = new Model2();
        public ViewModel2() => this.model2.NotiyCounterIncremented = AddToHistory;
        public ObservableCollection<string> History
        {
            get;
        } = new ObservableCollection<string>();
        public void AddToHistory(string item) => App.Current.Dispatcher.Invoke((Action)delegate { this.History.Add(item); });                    
        public void Stop() => this.model2.Stop();
    }
}
