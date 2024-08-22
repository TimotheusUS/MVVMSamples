using System;
using System.Collections.Generic;
using System.Windows.Input;
using System.Collections.ObjectModel;
using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.TestGraphics
{
    public class ViewModel1 : ViewModelBase
    {
        private readonly Model1 model1 = new Model1();
        private string someText;
        private ICommand convertTextCommand;
        private readonly ObservableCollection<ViewModelItem> history = new ObservableCollection<ViewModelItem>();
        public ViewModel1()
        {
            this.convertTextCommand = new RelayCommand(this.ConvertText);
        }

        public string SomeText
        {
            get => this.someText;
            set
            {
                this.someText = value;
                OnPropertyChanged(nameof(this.SomeText));
            }
        }
        public string SomeNewText
        {
            get => this.someText; 
            set
            {
                this.someText = value;
              //  OnPropertyChanged(nameof(SomeNewText));
            }
        }        
        public IEnumerable<ViewModelItem> History
        {
            get => this.history; 
        }
        public ICommand ConvertTextCommand
        {
            get => this.convertTextCommand;
        }
        private void ConvertText()
        {
            AddToHistory(this.model1.ConvertText(this.SomeText));
            this.SomeText = String.Empty; 
        }
        private void AddToHistory(string item)
        {
            this.history.Add(new ViewModelItem() { ItemValue = item, DateOfGeneration = DateTime.Now });
           // var resource =  App.Current.FindResource("ItemValueDateTemplateBlueViolet");
        }
    }
}
