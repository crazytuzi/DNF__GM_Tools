using AY.DNF.GMTool.BubbleTimer.Models;
using AY.DNF.GMTool.Db.Services;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace AY.DNF.GMTool.BubbleTimer.ViewModels
{
    public class BubbleTimerPageViewModel : BindableBase
    {
        Task _intervalTask;
        CancellationTokenSource _cancellationTokenSource;


        #region 属性

        private bool _isUseDCoin;

        /// <summary>
        /// 是否启用D币
        /// </summary>
        public bool IsUseDCoin
        {
            get { return _isUseDCoin; }
            set { SetProperty(ref _isUseDCoin, value); }
        }

        private bool _isUseDPoint = true;
        /// <summary>
        /// 是否启用D点
        /// </summary>
        public bool IsUseDPoint
        {
            get { return _isUseDPoint; }
            set { SetProperty(ref _isUseDPoint, value); }
        }

        private int _dCoinInterval = 1;
        /// <summary>
        /// D币间隔
        /// </summary>
        public int DCoinInterval
        {
            get { return _dCoinInterval; }
            set { SetProperty(ref _dCoinInterval, value); }
        }

        private int _dPointInterval = 1;
        /// <summary>
        /// D点间隔
        /// </summary>
        public int DPointInterval
        {
            get { return _dPointInterval; }
            set { SetProperty(ref _dPointInterval, value); }
        }

        private int _dCoin = 0;
        /// <summary>
        /// 发放D币数量
        /// </summary>
        public int DCoin
        {
            get { return _dCoin; }
            set { SetProperty(ref _dCoin, value); }
        }

        private int _dPoint = 0;
        /// <summary>
        /// 发放D点数量
        /// </summary>
        public int DPoint
        {
            get { return _dPoint; }
            set { SetProperty(ref _dPoint, value); }
        }

        private string _runInfo = string.Empty;
        /// <summary>
        /// 运行状态
        /// </summary>
        public string RunInfo
        {
            get { return _runInfo; }
            set { SetProperty(ref _runInfo, value); }
        }


        private ObservableCollection<RunLogModel> _runLogs = new ObservableCollection<RunLogModel>();
        /// <summary>
        /// 运行日志
        /// </summary>
        public ObservableCollection<RunLogModel> RunLogs
        {
            get { return _runLogs; }
            set { SetProperty(ref _runLogs, value); }
        }


        #endregion

        #region 命令
        ICommand _startCommand;
        ICommand _stopCommand;

        public ICommand StartCommand => _startCommand ??= new DelegateCommand(DoStartCommand);

        public ICommand StopCommand => _stopCommand ??= new DelegateCommand(DoStopCommand);


        #endregion
        public BubbleTimerPageViewModel()
        {
        }

        void DoStartCommand()
        {
            if (!IsUseDCoin && !IsUseDPoint)
            {
                MessageBox.Show("未启用任何发放");
                return;
            }

            RunInfo = $"开始运行====={DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}";

            _cancellationTokenSource = new CancellationTokenSource();
            var ct = _cancellationTokenSource.Token;
            _intervalTask = new Task(() =>
            {
                var service = new BubbleService();
                DateTime? lastCoin = null, lastPoint = null;
                while (!ct.IsCancellationRequested)
                {
                    RunInfo = $"开始运行====={DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}";
                    if (IsUseDCoin)
                    {
                        if (lastCoin == null)
                            lastCoin = DateTime.Now;
                        else if ((DateTime.Now - (DateTime)lastCoin).TotalSeconds >= DCoinInterval * 60)
                        {
                            lastCoin = DateTime.Now;
                            var ri = service.SendDCoin(DCoin);
                            AddLog((DateTime)lastCoin, ri, $"已发放D币{DCoin}");
                        }
                    }

                    if (IsUseDPoint)
                    {
                        if (lastPoint == null)
                            lastPoint = DateTime.Now;
                        else if ((DateTime.Now - (DateTime)lastPoint).TotalSeconds >= DPointInterval * 60)
                        {
                            lastPoint = DateTime.Now;
                            var ri = service.SendDPoint(DPoint);
                            AddLog((DateTime)lastPoint, ri, $"已发放D点{DCoin}");
                        }
                    }

                    Task.Delay(1000);
                }
            }, ct);

            _intervalTask.Start();
        }

        void DoStopCommand()
        {
            RunInfo = string.Empty;
            _cancellationTokenSource.Cancel();
        }

        void AddLog(DateTime logTime, int rowCount, string info)
        {
            if (RunLogs.Count >= 100)
                RunLogs.RemoveAt(99);

            Application.Current.Dispatcher.Invoke(() =>
            {
                RunLogs.Insert(0, new RunLogModel { AccountCounts = rowCount, LogInfo = info, LogTime = logTime });
            });
        }
    }
}
