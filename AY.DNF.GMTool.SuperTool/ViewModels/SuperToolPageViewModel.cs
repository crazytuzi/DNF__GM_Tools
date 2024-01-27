using AY.DNF.GMTool.Db.Services;
using AY.DNF.GMTool.SuperTool.Enums;
using HandyControl.Controls;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace AY.DNF.GMTool.SuperTool.ViewModels
{
    internal class SuperToolPageViewModel : BindableBase
    {
        private string? _operateMsg;

        public string? OperateMsg
        {
            get { return _operateMsg; }
            set { SetProperty(ref _operateMsg, value); }
        }

        private ObservableCollection<KeyValuePair<string, int>> _rechargeTypes = new ObservableCollection<KeyValuePair<string, int>>(EnumHelper.EnumToList<RechargeType>());

        public ObservableCollection<KeyValuePair<string, int>> RechargeTypes
        {
            get { return _rechargeTypes; }
            set { SetProperty(ref _rechargeTypes, value); }
        }

        private int _selectedRecharge;

        public int SelectedRecharge
        {
            get { return _selectedRecharge; }
            set { SetProperty(ref _selectedRecharge, value); }
        }

        private ObservableCollection<KeyValuePair<string, int>> _pvpGradeTypes = new ObservableCollection<KeyValuePair<string, int>>(EnumHelper.EnumToList<PVPGradeType>());

        public ObservableCollection<KeyValuePair<string, int>> PVPGradeTypes
        {
            get { return _pvpGradeTypes; }
            set { SetProperty(ref _pvpGradeTypes, value); }
        }

        private int _selectedPVPGrade;

        public int SelectedPVPGrade
        {
            get { return _selectedPVPGrade; }
            set { SetProperty(ref _selectedPVPGrade, value); }
        }


        private int _rechargeCount = 0;

        public int RechargeCount
        {
            get { return _rechargeCount; }
            set { SetProperty(ref _rechargeCount, value); }
        }

        private Visibility _inputCountVisibility = Visibility.Visible;

        public Visibility InputCountVisibility
        {
            get { return _inputCountVisibility; }
            set { SetProperty(ref _inputCountVisibility, value); }
        }

        private Visibility _pvpVisibility = Visibility.Hidden;

        public Visibility PVPVisibility
        {
            get { return _pvpVisibility; }
            set { SetProperty(ref _pvpVisibility, value); }
        }

        private ObservableCollection<KeyValuePair<string, int>> _jobTypes = new ObservableCollection<KeyValuePair<string, int>>(EnumHelper.EnumToList<JobType>());

        public ObservableCollection<KeyValuePair<string, int>> JobTypes
        {
            get { return _jobTypes; }
            set { SetProperty(ref _jobTypes, value); }
        }

        private JobType _selectedJob;

        public JobType SelectedJob
        {
            get { return _selectedJob; }
            set { SetProperty(ref _selectedJob, value); }
        }

        private ObservableCollection<KeyValuePair<string, int>> _growTypes = new ObservableCollection<KeyValuePair<string, int>>(EnumHelper.EnumToList<GrowJobType>());

        public ObservableCollection<KeyValuePair<string, int>> GrowTypes
        {
            get { return _growTypes; }
            set { SetProperty(ref _growTypes, value); }
        }

        private int _selectedGrowJob;

        public int SelectedGrowJob
        {
            get { return _selectedGrowJob; }
            set { SetProperty(ref _selectedGrowJob, value); }
        }

        #region 命令

        ICommand _clearBagCommand;
        ICommand _unlimitedWeightCommand;
        ICommand _openLeftAndRightCommand;
        ICommand _rechargeCommand;

        public ICommand RechargeCommand => _rechargeCommand ??= new DelegateCommand<string>(DoRechargeCommand);

        ICommand _changedJobCommand;

        public ICommand ChangedJobCommand => _changedJobCommand ??= new DelegateCommand<string>(DoChangedJobCommand);

        /// <summary>
        /// 清理背包
        /// </summary>
        public ICommand ClearBagCommand => _clearBagCommand ??= new DelegateCommand<string>(DoClearBagCommand);

        /// <summary>
        /// 无限负重
        /// </summary>
        public ICommand UnlimitedWeightCommand => _unlimitedWeightCommand ??= new DelegateCommand<string>(DoUnlimitedWeightCommand);

        /// <summary>
        /// 开左右槽
        /// </summary>
        public ICommand OpenLeftAndRightCommand => _openLeftAndRightCommand ??= new DelegateCommand<string>(DoOpenLeftAndRightCommand);

        ICommand _expertJobFullCommand;
        /// <summary>
        /// 副职满级
        /// </summary>
        public ICommand ExpertJobFullCommand => _expertJobFullCommand ??= new DelegateCommand<string>(DoExpertJobFullCommand);

        ICommand _maxEquipLevelCommand;
        /// <summary>
        /// 解除装备上限
        /// </summary>
        public ICommand MaxEquipLevelCommand => _maxEquipLevelCommand ??= new DelegateCommand<string>(DoMaxEquipLevelCommand);

        ICommand _setVIPCommand;

        public ICommand SetVIPCommand => _setVIPCommand ??= new DelegateCommand<string>(DoSetVIPCommand);

        ICommand _unsetVIPCommand;

        public ICommand UnsetVIPCommand => _unsetVIPCommand ??= new DelegateCommand<string>(DoUnsetVIPCommand);

        ICommand _unsetMemberVIPCommand;

        public ICommand UnsetMemberVIPCommand => _unsetMemberVIPCommand ??= new DelegateCommand<string>(DoUnsetMemberVIPCommand);

        ICommand _rechageChangedCommand;

        public ICommand RechargeChangedCommand => _rechageChangedCommand ??= new DelegateCommand(DoRechargeChangedCommand);

        ICommand _jobChangedCommand;

        public ICommand JobChangedCommand => _jobChangedCommand ??= new DelegateCommand(DoJobChangedCommand);

        ICommand _changeJobCommand;

        public ICommand ChangeJobCommand => _changeJobCommand ??= new DelegateCommand<string>(DoChangeJobCommand);

        ICommand _allHellCommand;

        public ICommand AllHellCommand => _allHellCommand ??= new DelegateCommand<string>(DoAllHellCommand);

        #endregion

        public SuperToolPageViewModel()
        {

        }


        async void DoRechargeCommand(string characNo)
        {
            if (string.IsNullOrWhiteSpace(characNo))
            {
                Growl.Error("请选择游戏角色");
                return;
            }

            var cn = int.Parse(characNo);
            var service = new RechargeService();
            var b = false;
            var msgTitle = string.Empty;

            if (SelectedRecharge == (int)RechargeType.段位)
            {
                msgTitle = "段位";
                b = await service.RechargePVPGrade(cn, (int)SelectedPVPGrade);
            }
            else
            {
                msgTitle = ((RechargeType)Enum.Parse(typeof(RechargeType), SelectedRecharge.ToString())).ToString();
                var sr = Enum.Parse(typeof(RechargeType), SelectedRecharge.ToString());
                switch (sr)
                {
                    case RechargeType.D币:
                        b = await service.RechargeD(cn, RechargeCount, 0);
                        break;
                    case RechargeType.D点:
                        b = await service.RechargeD(cn, RechargeCount, 1);
                        break;
                    case RechargeType.SP点:
                        b = await service.RechargeSP(cn, RechargeCount);
                        break;
                    case RechargeType.QP点:
                        b = await service.RechargeQP(cn, RechargeCount);
                        break;
                    case RechargeType.TP点:
                        b = await service.RechargeTP(cn, RechargeCount);
                        break;
                    case RechargeType.胜场:
                        b = await service.RechargePVPWin(cn, RechargeCount);
                        break;
                    case RechargeType.胜点:
                        b = await service.RechargePVPWinPoint(cn, RechargeCount);
                        break;
                }
            }

            OperateMsg = $"{msgTitle}充值操作{(b ? "成功" : "失败")}";
        }

        void DoChangedJobCommand(string characNo)
        {
            if (string.IsNullOrWhiteSpace(characNo))
            {
                Growl.Error("请选择游戏角色");
                return;
            }

            Growl.Warning("待开发");
        }

        async void DoClearBagCommand(string characNo)
        {
            if (string.IsNullOrWhiteSpace(characNo))
            {
                Growl.Error("请选择游戏角色");
                return;
            }

            var b = await new ClearService().ClearBag(int.Parse(characNo));
            OperateMsg = $"背包清理{(b ? "成功" : "失败")}";
        }


        async void DoUnlimitedWeightCommand(string characNo)
        {
            if (string.IsNullOrWhiteSpace(characNo))
            {
                Growl.Error("请选择游戏角色");
                return;
            }

            var b = await new MemberService().UnlimitedWeight(int.Parse(characNo));
            OperateMsg = $"无限负重设置{(b ? "成功" : "失败")}";
        }

        async void DoOpenLeftAndRightCommand(string characNo)
        {
            if (string.IsNullOrWhiteSpace(characNo))
            {
                Growl.Error("请选择游戏角色");
                return;
            }

            var b = await new MemberService().OpenLeftAndRight(int.Parse(characNo));
            OperateMsg = $"开左右槽{(b ? "成功" : "失败")}";
        }

        async void DoExpertJobFullCommand(string characNo)
        {
            if (string.IsNullOrWhiteSpace(characNo))
            {
                Growl.Error("请选择游戏角色");
                return;
            }

            var b = await new MemberService().ExpertJobFull(int.Parse(characNo));
            OperateMsg = $"副职满级{(b ? "成功" : "失败")}";
        }

        async void DoMaxEquipLevelCommand(string characNo)
        {
            if (string.IsNullOrWhiteSpace(characNo))
            {
                Growl.Error("请选择游戏角色");
                return;
            }

            var b = await new MemberService().MaxEquipLevel(int.Parse(characNo));
            OperateMsg = $"解除装备权限{(b ? "成功" : "失败")}";
        }

        void DoUnsetMemberVIPCommand(string characNo)
        {
            if (string.IsNullOrWhiteSpace(characNo))
            {
                Growl.Error("请选择游戏角色");
                return;
            }

            Growl.Warning("待开发");
        }

        void DoUnsetVIPCommand(string characNo)
        {
            if (string.IsNullOrWhiteSpace(characNo))
            {
                Growl.Error("请选择游戏角色");
                return;
            }

            Growl.Warning("待开发");
        }

        void DoSetVIPCommand(string characNo)
        {
            if (string.IsNullOrWhiteSpace(characNo))
            {
                Growl.Error("请选择游戏角色");
                return;
            }

            Growl.Warning("待开发");
        }

        void DoRechargeChangedCommand()
        {
            if (SelectedRecharge == (int)RechargeType.段位)
            {
                InputCountVisibility = Visibility.Hidden;
                PVPVisibility = Visibility.Visible;
            }
            else
            {
                InputCountVisibility = Visibility.Visible;
                PVPVisibility = Visibility.Hidden;
            }
        }

        /// <summary>
        /// 全图地狱
        /// </summary>
        async void DoAllHellCommand(string uid)
        {
            if (string.IsNullOrWhiteSpace(uid))
            {
                Growl.Error("请查询账号");
                return;
            }

            var b = await new MemberService().AllHell(int.Parse(uid));
            OperateMsg = $"全力地狱{(b ? "成功" : "失败")}";
        }


        void DoJobChangedCommand()
        {

        }

        void DoChangeJobCommand(string characNo)
        {
            if (string.IsNullOrWhiteSpace(characNo))
            {
                Growl.Error("请选择游戏角色");
                return;
            }

            Growl.Warning("待开发");
        }
    }
}
