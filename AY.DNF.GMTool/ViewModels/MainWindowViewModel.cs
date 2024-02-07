using AY.DNF.GMTool.Db;
using AY.DNF.GMTool.Db.Models;
using AY.DNF.GMTool.Db.Services;
using AY.DNF.GMTool.Enums;
using AY.DNF.GMTool.Models;
using HandyControl.Controls;
using Newtonsoft.Json;
using Prism.Commands;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using TiaoTiaoCode.NLogger;

namespace AY.DNF.GMTool.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        readonly IModuleManager _moduleMng;
        readonly IRegionManager _regionMng;

        readonly Task _timeTask;
        readonly CancellationTokenSource _timeTaskCancelTokenSource;

        #region 属性

        private string _title = "DNF GM Tool";
        /// <summary>
        /// 工具栏标题
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _version = "0.0.20240207";
        /// <summary>
        /// 显示的自定义版本号
        /// </summary>
        public string Version
        {
            get { return _version; }
            set { SetProperty(ref _version, value); }
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

        private bool _openEnabled = true;
        /// <summary>
        /// 连接按钮可用性
        /// </summary>
        public bool OpenEnabled
        {
            get { return _openEnabled; }
            set { SetProperty(ref _openEnabled, value); }
        }

        #region 数据库连接相关

        private string _server = "";
        /// <summary>
        /// Server
        /// </summary>
        public string Server
        {
            get { return _server; }
            set { SetProperty(ref _server, value); }
        }

        private string _userName = "";
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

        private string _pwd = "";
        /// <summary>
        /// 数据库密码
        /// </summary>
        public string Pwd
        {
            get { return _pwd; }
            set { SetProperty(ref _pwd, value); }
        }

        #endregion

        private string _searchAccount = "";
        /// <summary>
        /// 查询账号
        /// </summary>
        public string SearchAccount
        {
            get { return _searchAccount; }
            set { SetProperty(ref _searchAccount, value); }
        }

        private LoginBindableModel? _loginInfo;
        /// <summary>
        /// 登录信息
        /// </summary>
        public LoginBindableModel? LoginInfo
        {
            get { return _loginInfo; }
            set { SetProperty(ref _loginInfo, value); }
        }

        private CurMemberInfoModel? _curMemberInfo;
        /// <summary>
        /// 当前选中角色信息
        /// </summary>
        public CurMemberInfoModel? CurMemberInfo
        {
            get { return _curMemberInfo; }
            set { SetProperty(ref _curMemberInfo, value); }
        }

        /// <summary>
        /// 角色列表
        /// </summary>
        public ObservableCollection<SimpleMemberInfoModel> MemberInfos { get; set; } = new ObservableCollection<SimpleMemberInfoModel>();

        #endregion

        #region 命令

        ICommand? _connectCommand;
        ICommand? _searchAccountCommand;
        ICommand? _disconnectCommand;
        ICommand? _gmToolCommand;

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

        /// <summary>
        /// GM工具菜单
        /// </summary>
        public ICommand GMToolCommand => _gmToolCommand ??= new DelegateCommand<string>(DoGMToolCommand);

        ICommand? _rowClickCommand;
        /// <summary>
        /// 角色列表点击事件
        /// </summary>
        public ICommand RowClickCommand => _rowClickCommand ??= new DelegateCommand<SimpleMemberInfoModel?>(DoRowClickCommand);

        ICommand? _changePwdCommand;
        /// <summary>
        /// 切换密码事件
        /// </summary>
        public ICommand ChangePwdCommand => _changePwdCommand ??= new DelegateCommand(DoChangePwdCommand);

        #endregion

        ICommand? _appCloseCommand;
        /// <summary>
        /// 应用程序关闭
        /// </summary>
        public ICommand AppCloseCommand => _appCloseCommand ??= new DelegateCommand(() =>
        {
            _timeTaskCancelTokenSource.Cancel();

            DbFrameworkScope.TaiwanCain2nd?.Close();
            DbFrameworkScope.TaiwanCain?.Close();
            DbFrameworkScope.DTaiwan?.Close();
            DbFrameworkScope.TaiwanBilling?.Close();

            Application.Current.Shutdown();
        });


        public MainWindowViewModel(IModuleManager moduleManager, IRegionManager regionManager)
        {
            _moduleMng = moduleManager;
            _regionMng = regionManager;

            LoadCfg();

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

            Task.Run(() =>
            {
                Task.Delay(5000);
                Growl.Info("首次使用，请先进行Script.pvf导入，以便生成基础数据\r\n若版本更换也需重新导入Script.pvf");
            });
        }

        /// <summary>
        /// 数据库连接
        /// </summary>
        void DoConnectCommand()
        {
            bool b;
            try
            {
                b = DbFrameworkScope.Init(Server, UserName, Pwd, Port);
            }
            catch (Exception ex)
            {
                Growl.Error(ex.Message);
                return;
            }
            if (!b)
            {
                OpenEnabled = true;
                ConnectedForEnabled = false;
                Growl.Error("数据库连接失败");
                return;
            }

            Growl.Success("连接成功");
            OpenEnabled = false;
            ConnectedForEnabled = true;

            WriteCfg();
        }

        /// <summary>
        /// 账号查询
        /// </summary>
        async void DoSearchAccountCommand()
        {
            MemberInfos.Clear();

            try
            {

                var loginInfo = await new LoginService().Login(SearchAccount);

                if (loginInfo == null)
                {
                    Growl.Error("未查询到信息");
                    return;
                }

                WriteCfg();

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
            catch (Exception ex)
            {
                TiaoTiaoNLogger.LogError(ex.Message, ex);
            }
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        void DoDisconnectCommand()
        {
            OpenEnabled = true;
            ConnectedForEnabled = false;
            _timeTaskCancelTokenSource.Cancel();
        }

        /// <summary>
        /// GM工具菜单
        /// </summary>
        void DoGMToolCommand(string menu)
        {
            var moudelName = $"{menu}Module";
            if (!_moduleMng.ModuleExists(moudelName) || _moduleMng.GetModuleState(moudelName) != ModuleState.Initialized)
                _moduleMng.LoadModule(moudelName);


            var module = _moduleMng.Modules.FirstOrDefault(t => t.ModuleName == moudelName);
            if (module == null) return;

            _regionMng.RequestNavigate("ContentRegion", module.ModuleName);
        }

        /// <summary>
        /// 角色列表点击事件
        /// </summary>
        async void DoRowClickCommand(SimpleMemberInfoModel? memberInfo)
        {
            if (memberInfo == null) return;

            var detailInfo = await new MemberService().GetDetailMemberInfo(memberInfo.CharacNo);
            if (detailInfo == null)
            {
                CurMemberInfo = null;
                return;
            }

            CurMemberInfo = new CurMemberInfoModel
            {
                CharacNo = detailInfo.CharacNo.ToString(),
                CharacName = detailInfo.CharacName!.ToString(),
                ExpertJob = ((ExpertJobType)Enum.Parse(typeof(ExpertJobType), detailInfo.ExpertJob.ToString())).ToString(),
                LastPlayTime = detailInfo.LastPlayTime,
                Level = detailInfo.Level,
                Money = detailInfo.Money,
                VIP = detailInfo.VIP
            };
            var jobArr = detailInfo.Job!.Split("_", StringSplitOptions.RemoveEmptyEntries);
            CurMemberInfo.Job = ((JobType)Enum.Parse(typeof(JobType), jobArr[0])).ToString();
            if (jobArr.Length > 1)
                CurMemberInfo.Job = jobArr[1];
        }

        /// <summary>
        /// 切换密码
        /// </summary>
        void DoChangePwdCommand()
        {
            if (string.IsNullOrWhiteSpace(Pwd))
                Pwd = "123456";
            else if (Pwd == "123456")
                Pwd = "uu5!^%jg";
            else
                Pwd = "123456";
        }

        #region 连接配置

        /// <summary>
        /// 读取连接相关信息
        /// </summary>
        void LoadCfg()
        {
            var path = "settings.dat";
            if (!File.Exists(path)) return;

            var str = File.ReadAllText(path);
            var cfg = JsonConvert.DeserializeObject<ConnectInfoModel>(str);
            if (cfg == null) return;

            Server = cfg.IP;
            Port = cfg.Port;
            UserName = cfg.UserName;
            Pwd = cfg.Pwd;
            SearchAccount = cfg.Account;
        }

        /// <summary>
        /// 连接相关信息写入本地文件
        /// </summary>
        void WriteCfg()
        {
            var path = "settings.dat";

            var cfg = new ConnectInfoModel
            {
                IP = Server,
                Port = Port,
                UserName = UserName,
                Pwd = Pwd,
                Account = SearchAccount
            };
            var str = JsonConvert.SerializeObject(cfg);

            File.WriteAllText(path, str);
        }

        #endregion    
    }
}

