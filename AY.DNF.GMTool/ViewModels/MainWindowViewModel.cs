using AY.DNF.GMTool.Db;
using AY.DNF.GMTool.Db.Models;
using AY.DNF.GMTool.Db.Services;
using AY.DNF.GMTool.Models;
using HandyControl.Controls;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Threading;

namespace AY.DNF.GMTool.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        Task _timeTask;
        CancellationTokenSource _timeTaskCancelTokenSource;

        #region 属性

        private string _title = "DNF GM Tool";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private DateTime _sysTime;
        /// <summary>
        /// 系统时间
        /// </summary>
        public DateTime SysTime
        {
            get { return _sysTime; }
            set { SetProperty(ref _sysTime, value); }
        }


        private bool _connectedForEnabled = false;
        /// <summary>
        /// 是否成功连接数据库启用功能
        /// </summary>
        public bool ConnectedForEnabled
        {
            get { return _connectedForEnabled; }
            set { SetProperty(ref _connectedForEnabled, value); }
        }

        #region 数据库连接相关

        private string _server = "192.168.200.131";
        /// <summary>
        /// Server
        /// </summary>
        public string Server
        {
            get { return _server; }
            set { SetProperty(ref _server, value); }
        }

        private string _userName = "game";
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            get { return _userName; }
            set { SetProperty(ref _userName, value); }
        }

        private int _port = 3306;
        /// <summary>
        /// 连接端口
        /// </summary>
        public int Port
        {
            get { return _port; }
            set { SetProperty(ref _port, value); }
        }

        private string _pwd = "123456";
        /// <summary>
        /// 数据库密码
        /// </summary>
        public string Pwd
        {
            get { return _pwd; }
            set { SetProperty(ref _pwd, value); }
        }

        #endregion

        private string _searchAccount = "elva159753";
        /// <summary>
        /// 查询账号
        /// </summary>
        public string SearchAccount
        {
            get { return _searchAccount; }
            set { SetProperty(ref _searchAccount, value); }
        }

        private LoginBindableModel _loginInfo;
        /// <summary>
        /// 登录信息
        /// </summary>
        public LoginBindableModel LoginInfo
        {
            get { return _loginInfo; }
            set { SetProperty(ref _loginInfo, value); }
        }

        public ObservableCollection<SimpleMemberInfoModel> MemberInfos { get; set; } = new ObservableCollection<SimpleMemberInfoModel>();

        #endregion

        #region 命令

        ICommand _connectCommand;
        ICommand _searchAccountCommand;
        ICommand _disconnectCommand;

        /// <summary>
        /// 连接命令
        /// </summary>

        public ICommand ConnectCommand => _connectCommand ??= new DelegateCommand(DoConnectCommand);

        /// <summary>
        /// 查询命令
        /// </summary>
        public ICommand SearchAccountCommand => _searchAccountCommand ??= new DelegateCommand(DoSearchAccountCommand);

        /// <summary>
        /// 断开连接命令
        /// </summary>
        public ICommand DisconnectCommand => _disconnectCommand ??= new DelegateCommand(DoDisconnectCommand);

        #endregion

        public MainWindowViewModel()
        {
            _timeTaskCancelTokenSource = new CancellationTokenSource();
            var ct = _timeTaskCancelTokenSource.Token;

            _timeTask = new Task(() =>
            {
                Dispatcher.CurrentDispatcher.Invoke(() =>
                {
                    while (true)
                    {
                        if (ct.IsCancellationRequested) return;

                        SysTime = DateTime.Now;
                        Thread.Sleep(1000);
                    }
                });
            }, ct);
            _timeTask.Start();
        }

        /// <summary>
        /// 数据库连接
        /// </summary>
        void DoConnectCommand()
        {
            DbFrameworkScope.Init(Server, UserName, Pwd, Port);
            Growl.Success("连接成功");

            ConnectedForEnabled = true;
        }

        /// <summary>
        /// 账号查询
        /// </summary>
        async void DoSearchAccountCommand()
        {
            MemberInfos.Clear();

            var loginInfo = await new LoginService().Login(SearchAccount);

            if (loginInfo == null)
            {
                Growl.Error("未查询到信息");
                return;
            }

            LoginInfo = new LoginBindableModel
            {
                AccountName = loginInfo.AccountName,
                DCoin = loginInfo.DCoin,
                DPoint = loginInfo.DPoint,
                Status = loginInfo.Status,
                Uid = loginInfo.Uid,
                VIP = loginInfo.VIP
            };

            MemberInfos.AddRange(loginInfo.MemberInfos);
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        void DoDisconnectCommand()
        {
            ConnectedForEnabled = false;
            _timeTaskCancelTokenSource.Cancel();
        }

    }
}
