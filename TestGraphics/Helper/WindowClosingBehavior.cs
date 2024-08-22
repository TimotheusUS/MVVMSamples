using System;
using System.Windows;
using System.Windows.Input;

namespace TimotheusUS.MVVMsamples.TestGraphics
{
    public class WindowClosingBehavior : DependencyObject
    {
        public static readonly DependencyProperty ClosedProperty = DependencyProperty.RegisterAttached("Closed", typeof(ICommand), typeof(WindowClosingBehavior), new UIPropertyMetadata(new PropertyChangedCallback(WindowClosingBehavior.ClosedChanged)));
        public static ICommand GetClosed(DependencyObject dependencyObject) => dependencyObject.GetValue(WindowClosingBehavior.ClosedProperty) as ICommand;
        public static void SetClosed(DependencyObject dependencyObject, ICommand value) => dependencyObject.SetValue(WindowClosingBehavior.ClosedProperty, value);
        private static void ClosedChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            if (dependencyObject is Window window)
            {
                if (e.NewValue != null)
                    window.Closed += window_Closed;
                else
                    window.Closed -= window_Closed;
            }
        }
        private static void window_Closed(object sender, EventArgs e)
        {
            ICommand closed = WindowClosingBehavior.GetClosed(sender as DependencyObject);
            closed?.Execute(null);
        }
    }
}
