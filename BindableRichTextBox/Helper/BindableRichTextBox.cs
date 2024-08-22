using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace TimotheusUS.MVVMsamples.BindableRichTextBox
{
    public sealed class BindableRichTextBox : RichTextBox
    {
        //public static readonly DependencyProperty SourceProperty =
        //    DependencyProperty.Register("Source", typeof(List<Paragraph>), typeof(BindableRichTextBox),
        //        new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnSourceChanged));
        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(List<Paragraph>), typeof(BindableRichTextBox), new PropertyMetadata(OnSourceChanged));

        public List<Paragraph> Source
        {
            get { return (List<Paragraph>)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        private static void OnSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var rtf = d as BindableRichTextBox;
            var newParagraphs = e.NewValue as List<Paragraph>;

            rtf.TextChanged -= Rtf_TextChanged;
            rtf.Document.Blocks.Clear();

            foreach (var paragraph in newParagraphs)
            {
                rtf.Document.Blocks.Add(paragraph);
            }

            rtf.TextChanged += Rtf_TextChanged;
        }

        private static void Rtf_TextChanged(object sender, TextChangedEventArgs e)
        {
            var rtf = sender as BindableRichTextBox;
            var updatedSource = new List<Paragraph>();

            foreach (var block in rtf.Document.Blocks)
            {
                if (block is Paragraph paragraph)
                {
                    updatedSource.Add(paragraph);
                }
            }

            rtf.SetCurrentValue(SourceProperty, updatedSource);
        }
    }
}
