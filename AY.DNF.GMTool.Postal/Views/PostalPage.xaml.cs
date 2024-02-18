using AY.DNF.GMTool.Postal.ViewModels;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AY.DNF.GMTool.Postal.Views
{
    /// <summary>
    /// PostalPage.xaml 的交互逻辑
    /// </summary>
    public partial class PostalPage : System.Windows.Controls.UserControl
    {
        public PostalPage()
        {
            InitializeComponent();
        }

        private void OnImagePacksPathClick(object sender, RoutedEventArgs e)
        {
            var ofd = new FolderBrowserDialog();
            var b = ofd.ShowDialog();
            if (b != DialogResult.OK) return;

            (DataContext as PostalPageViewModel)!.ImagePacksPath = ofd.SelectedPath;
        }
    }
}
