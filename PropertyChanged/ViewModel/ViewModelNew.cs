using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.PropertyChanged
{
    public class ViewModelNew : ViewModelBase
    {
        private string text1;
        private string text2;
        private string summery = "A";

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
    }
}
