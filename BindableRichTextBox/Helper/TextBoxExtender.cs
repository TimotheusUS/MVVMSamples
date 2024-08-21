using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TestMVVM.BindableRichTextBox
{
    public class TextBoxExtender
    {
        public static readonly DependencyProperty FrameSpecialProperty = DependencyProperty.RegisterAttached("FrameSpecial", typeof(bool), typeof(TextBoxExtender), new UIPropertyMetadata(default(bool), OnTextChanged));

        public static bool GetFrameSpecial(DependencyObject obj) => (bool)obj.GetValue(FrameSpecialProperty);        

        public static void SetFrameSpecial(DependencyObject obj, bool value) =>  obj.SetValue(FrameSpecialProperty, value);

        public static void OnTextChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            var textBox = o as TextBox;
            textBox.Foreground = (Convert.ToBoolean(e.NewValue) ? Brushes.Green : Brushes.Red);
        }
    }
}

