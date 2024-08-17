using System.Windows;
using System.Windows.Input;
using Microsoft.Xaml.Behaviors;

namespace TimotheusUS.MVVMsamples.Easy.Helper
{
    public class BehaviorClearFocusOnClick : Behavior<FrameworkElement>
    {
        protected override void OnAttached()
        {
            base.AssociatedObject.MouseDown += this.AssociatedObject_MouseDown;
            base.OnAttached();
        }
        private void AssociatedObject_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => Keyboard.ClearFocus();
        protected override void OnDetaching()
        {
            base.AssociatedObject.MouseDown -= this.AssociatedObject_MouseDown;
            base.OnDetaching();
        }
    }
}
