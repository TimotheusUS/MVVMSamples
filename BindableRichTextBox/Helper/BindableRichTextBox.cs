using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace TimotheusUS.MVVMsamples.BindableRichTextBox
{
    public sealed class BindableRichTextBox : RichTextBox
    {
        public static readonly DependencyProperty SourceProperty = DependencyProperty.Register("Source", typeof(List<Paragraph>), typeof(BindableRichTextBox), new PropertyMetadata(OnSourceChanged));
        //public static readonly DependencyProperty MyTextProperty = DependencyProperty.Register("MyText", typeof(string), typeof(BindableRichTextBox), new UIPropertyMetadata(new PropertyChangedCallback(BindableRichTextBox.MyTextLoads)));

        //BindableRichTextBox() : base()
        //{ 
        
        //}

        public List<Paragraph> Source
        {
            get
            {
                return GetValue(SourceProperty) as List<Paragraph>;
            }
            set
            {
                SetValue(SourceProperty, value);
            }
        }

        public string MyText
        {
            get
            {
                return GetValue(SourceProperty) as string;
            }
            set
            {
                SetValue(SourceProperty, value);
            }
        }

        private static void OnSourceChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            var rtf = (BindableRichTextBox)obj;

            rtf.Document.Blocks.Clear();

            if (rtf.Source != null)
            {
                foreach (var item in rtf.Source)
                {
                    rtf.Document.Blocks.Add(item);
                }
            }
        }

        private static void MyTextLoads(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            if (dependencyObject is BindableRichTextBox brtf)
            {
                if (e.NewValue != null)
                    brtf.TextChanged += Brtf_TextChanged;
                else
                    brtf.TextChanged -= Brtf_TextChanged;
            }
        }

        private static void Brtf_TextChanged(object sender, TextChangedEventArgs e)
        {
            //var brtb = sender as BindableRichTextBox;

            //brtb.ch
        }
    }
}
