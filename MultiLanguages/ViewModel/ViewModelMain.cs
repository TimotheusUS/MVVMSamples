using System.Globalization;
using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.MultiLanguages
{
    public class ViewModelMain : ViewModelBase
    {
        private ViewModel1 viewModel1 = new ViewModel1();
        public ViewModelMain()
        {
            // VORSICHT: bie benutzung des Resx Managers werden alle Methoden d. class ResourceInfo auf "publice" gesetzt, muss aber "public" sein. 

            //string culture = "en-US";
            string culture = "af-NA";
            //string culture = "de-DE";
            //System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            //System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);
            TimotheusUS.MVVMsamples.MultiLanguages.Resources.ResourceInfo.Culture = new CultureInfo(culture);
        }
        public ViewModel1 ViewModel1
        {
            get => this.viewModel1;
            set
            {
                this.viewModel1 = value;
                base.OnPropertyChanged(nameof(this.ViewModel1));
            }
        }
    }
}