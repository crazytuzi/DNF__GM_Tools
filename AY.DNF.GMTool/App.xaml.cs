using AY.DNF.GMTool.Views;
using Prism.Ioc;
using Prism.Modularity;
using System;
using System.Text;
using System.Threading;
using System.Windows;
using TiaoTiaoCode.NLogger;

namespace AY.DNF.GMTool
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new ConfigurationModuleCatalog();
        }


        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        private static Mutex? _mutex;

        protected override void OnStartup(StartupEventArgs e)
        {
            _mutex = new Mutex(true, "AY.DNF.GMTool", out bool createNew);
            if (createNew)
            {
                TiaoTiaoNLogger.FastNoDatabaseInit();
                base.OnStartup(e);
            }
            else
                Shutdown();
        }

        private void PrismApplication_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            e.Handled = true;

            if (e.Exception is DivideByZeroException dex)
            {
                TiaoTiaoNLogger.LogError($"发生异常，但可继续运行\r\n{dex.Message}", dex);
                MessageBox.Show($"发生异常，但可继续运行\r\n{dex.Message}");
            }
            else
            {
                TiaoTiaoNLogger.LogError($"程序异常\r\n{e.Exception.Message}", e.Exception);
                MessageBox.Show($"程序异常：{e.Exception.Message}");
            }
        }
    }
}
