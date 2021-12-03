using System.Windows;
using Microsoft.Xaml.Behaviors;

namespace MVVMSamples.Tools
{
    public class BehaviorWindow : Behavior<Window>
    {
        protected override void OnAttached()
        {
            base.AssociatedObject.SizeToContent = SizeToContent.WidthAndHeight;
            base.OnAttached();
        }
    }
}
