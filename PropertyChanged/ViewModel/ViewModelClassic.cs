using System.Windows.Controls;
using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.PropertyChanged
{
    public class ViewModelClassic : ViewModelBase
    {
        private string text1;
        private string text2;
        private string summery;

        public ViewModelClassic()
        {
            this.PropertyChanged += ViewModel1_PropertyChanged;
        }

        public string Text1
        {
            get
            {
                return text1;
            }
            set
            {
                text1 = value;
                OnPropertyChanged(nameof(Text1));
            }
        }

        public string Text2
        {
            get
            {
                return text2;
            }
            set
            {
                text2 = value;
                OnPropertyChanged(nameof(Text2));
            }
        }

        public string Summery
        {
            get
            {
                return summery;
            }
            set
            {
                summery = value;
                OnPropertyChanged(nameof(Summery));
            }
        }

        private void ViewModel1_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {            
            
            if(e.PropertyName == nameof(Text1) || e.PropertyName == nameof(Text2))
            {
                var textBox = sender as TextBox;

                Summery = "From: " + e.PropertyName + ", value: " + (e.PropertyName == nameof(Text2) ? text2 : text1);
            }
        }

    }
}
