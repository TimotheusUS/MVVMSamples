using System;
using System.Collections.Generic;
using System.Windows.Documents;
using System.Windows.Input;
using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.BindableRichTextBox
{
    public class ViewModel1 : ViewModelBase
    {
        private readonly Model1 model1 = new Model1();
        private List<Paragraph> bocks;
        private bool esng1000WIsChecked;
        private bool hfe1600IsChecked;
        private bool lockCheckMechanism = false;

        public ViewModel1()
        {
            this.PropertyChanged += ViewModel1_PropertyChanged;
            this.InitializeCheckBoxes();
        }

        public List<Paragraph> Blocks
        {
            get
            {
                return bocks;
            }
            set
            {
                bocks = value;
                OnPropertyChanged(nameof(Blocks));
            }
        }

        public bool ESNG1000WIsChecked
        {
            get
            {
                return esng1000WIsChecked;
            }
            set
            {
                esng1000WIsChecked = value;
                OnPropertyChanged(nameof(ESNG1000WIsChecked));
            }
        }

        public bool HFE1600IsChecked
        {
            get
            {
                return hfe1600IsChecked;
            }
            set
            {
                hfe1600IsChecked = value;
                OnPropertyChanged(nameof(HFE1600IsChecked));
            }
        }

        private void InitializeCheckBoxes()
        {
            this.Blocks = this.model1.GetESNG1000WDocumentation();
            this.esng1000WIsChecked = true;
        }

        private void ViewModel1_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(this.ESNG1000WIsChecked) || e.PropertyName == nameof(this.HFE1600IsChecked))
            {
                if (!this.lockCheckMechanism)
                {
                    this.lockCheckMechanism = true;

                    if (e.PropertyName == nameof(this.ESNG1000WIsChecked))
                    {
                        this.Blocks = this.model1.GetESNG1000WDocumentation();
                    }
                    else if (e.PropertyName == nameof(this.HFE1600IsChecked))
                    {
                        this.Blocks = this.model1.GetHFE1600Documentation();
                    }
                }
                else
                {
                    this.lockCheckMechanism = false;
                }
            }
        }
    }
}
