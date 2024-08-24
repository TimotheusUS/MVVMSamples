using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.Validation
{
    public class ViewModel1 : ViewModelBase
    {
        
        private int age;

        public int Age
        {
            set
            {
                    age = value;
                    OnPropertyChanged(nameof(Age));
            }
            get
            {
                return age;
            }
        }
    }
}
