using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls.Primitives;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Playground
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            page.DataContext = new MainViewModel();
        }

        private void TextBlock_RightTapped(object sender, Microsoft.UI.Xaml.Input.RightTappedRoutedEventArgs e)
        {
            var owner = sender as FrameworkElement;
            if (owner != null)
            {
                var flyoutBase = FlyoutBase.GetAttachedFlyout(owner);
                flyoutBase.ShowAt(owner, new FlyoutShowOptions
                {
                    Position = e.GetPosition(owner),
                });
            }
        }
    }
}
