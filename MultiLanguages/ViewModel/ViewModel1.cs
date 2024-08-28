using System.Windows.Input;
using System.Collections.ObjectModel;
using TimotheusUS.MVVMsamples.Utilities;
using System.Resources;

namespace TimotheusUS.MVVMsamples.MultiLanguages
{
    public class ViewModel1 : ViewModelBase
    {
        private static ResourceManager resourceManager = TimotheusUS.MVVMsamples.MultiLanguages.Resources.ResourceInfo.ResourceManager;
        private readonly Model1 model1 = new Model1();
        private string someText;
        private ICommand showText;
        private readonly ObservableCollection<string> history = new ObservableCollection<string>();        
        public ViewModel1() => this.showText = new RelayCommand(this.ShowText);
        public string SomeText
        {
            get => this.someText;
            set
            {
                this.someText = value;
                OnPropertyChanged(nameof(this.SomeText));
            }
        }  
        public ICommand ShowTextCommand
        {
            get => this.showText;
        }
        private void ShowText()
        {
            // this.SomeText = resourceManager.GetString("textToConvertTag");
            this.SomeText = TimotheusUS.MVVMsamples.MultiLanguages.Resources.ResourceInfo.Info1;
        }
    }
}
