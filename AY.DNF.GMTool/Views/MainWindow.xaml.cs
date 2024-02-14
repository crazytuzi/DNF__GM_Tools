using AY.DNF.GMTool.ViewModels;
using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace AY.DNF.GMTool.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MaxClick(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
                WindowState = WindowState.Normal;
            else
                WindowState = WindowState.Maximized;
        }

        private void MinClick(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void OnSelectExeClick(object sender, RoutedEventArgs e)
        {
            var ofd = new OpenFileDialog();
            var b = ofd.ShowDialog();
            if (b == null || !(bool)b) return;

            (DataContext as MainWindowViewModel)!.ExeFilePath = ofd.FileName;
        }
    }
}
