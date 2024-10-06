using Hemuppgift_WPFtemplate.Windows;
using System.Windows;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //HEJ
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenGridWindow(object sender, RoutedEventArgs e)
        {
            new GridWindow().Show();
        }

        private void OpenStackPanelWindow(object sender, RoutedEventArgs e)
        {
            new StackPanelWindow().Show();

        }

        private void OpenWrapPanelWindow(object sender, RoutedEventArgs e)
        {
            new WrapPanelWindow().Show();
        }

        private void OpenDockPanelWindow(object sender, RoutedEventArgs e)
        {
            new DockPanelWindow().Show();

        }

    }
}