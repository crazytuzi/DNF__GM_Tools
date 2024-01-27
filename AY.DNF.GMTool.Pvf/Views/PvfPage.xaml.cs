using AY.DNF.GMTool.Pvf.ViewModels;
using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;

namespace AY.DNF.GMTool.Pvf.Views
{
    /// <summary>
    /// PvfPage.xaml 的交互逻辑
    /// </summary>
    public partial class PvfPage : UserControl
    {
        public PvfPage()
        {
            InitializeComponent();
        }

        private void PvfFileSelectClick(object sender, RoutedEventArgs e)
        {
            var ofd = new OpenFileDialog();
            var b = ofd.ShowDialog();
            if (b == null || !(bool)b) return;

            txtPvfPath.Text = ofd.FileName;

            (this.DataContext as PvfPageViewModel).PvfPath= ofd.FileName;
        }
    }
}
