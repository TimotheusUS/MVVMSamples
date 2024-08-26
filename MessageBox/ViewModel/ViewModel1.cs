using System.Windows.Input;
using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.MessageBox
{
    public class ViewModel1 : ViewModelBase
    {
        private readonly Model1 model1;
        private string someText = "a";
        private ICommand convertTextCommand;
        public ViewModel1(Model1 model1)
        {
            this.model1 = model1;
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
        public ICommand ConvertTextCommand
        {
            get => this.convertTextCommand;
        }
        private void ConvertText()
        {
            if (this.model1.IsTextInUpperCaseLetters(this.someText))
            {
                ViewModelMain.Show(string.Format("The text \"{0} is already in upper case letters. Please chose lower case letters for your text.", this.someText));                
            }
            else
            {
                this.SomeText = this.model1.ConvertText(this.someText);
            }
        }
    }
}
