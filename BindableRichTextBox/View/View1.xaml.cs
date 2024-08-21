using System.Windows.Controls;

namespace TimotheusUS.MVVMsamples.BindableRichTextBox
{
    public partial class View1 : UserControl
    {
        public View1()
        {
            InitializeComponent();
            myRtf.TextChanged += MyRtf_TextChanged;
        }

        private void MyRtf_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
