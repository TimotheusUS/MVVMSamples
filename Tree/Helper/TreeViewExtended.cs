using System.Windows;
using System.Windows.Controls;
using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.Tree
{
    public class TreeViewExtended : TreeView
    {
        public static readonly DependencyProperty SelectedItemExProperty = DependencyProperty.Register(
            "SelectedItemEx",
            typeof(ViewModelBase),
            typeof(TreeViewExtended),
            new FrameworkPropertyMetadata(default(ViewModelBase), FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
        );

        public ViewModelBase SelectedItemEx
        {
            get => (ViewModelBase)GetValue(SelectedItemExProperty);
            set => SetValue(SelectedItemExProperty, value);
        }

        protected override void OnSelectedItemChanged(RoutedPropertyChangedEventArgs<object> e)
        {
            base.OnSelectedItemChanged(e);
            SelectedItemEx = e.NewValue as ViewModelBase;
        }
    }
}