using System.Windows;
using System.Windows.Controls;

namespace TimotheusUS.MVVMsamples.Tree
{
    public class TreeViewExtended : TreeView
    {
        public static readonly DependencyProperty SelectedItemExProperty = DependencyProperty.Register("SelectedItemEx", typeof(object), typeof(TreeViewExtended), new FrameworkPropertyMetadata(default(object))
        {
            BindsTwoWayByDefault = true // Required in order to avoid setting the "BindingMode" from the XAML
        });
        public object SelectedItemEx
        {
            get
            {
                return GetValue(SelectedItemExProperty);
            }
            set
            {
                SetValue(SelectedItemExProperty, value);
            }
        }
        protected override void OnSelectedItemChanged(RoutedPropertyChangedEventArgs<object> e)
        {
            SelectedItemEx = e.NewValue;
        }
    }
}
