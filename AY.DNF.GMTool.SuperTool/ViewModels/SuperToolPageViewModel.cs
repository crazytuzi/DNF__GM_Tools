using AY.DNF.GMTool.Db.Services;
using Prism.Commands;
using Prism.Mvvm;
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


        #region 命令

        ICommand _clearBagCommand;
        ICommand _unlimitedWeightCommand;
        ICommand _openLeftAndRightCommand;

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

        #endregion

        public SuperToolPageViewModel()
        {

        }

        async void DoClearBagCommand(string characNo)
        {
            var b = await new ClearService().ClearBag(int.Parse(characNo));
            OperateMsg = $"背包清理{(b ? "成功" : "失败")}";
        }


        async void DoUnlimitedWeightCommand(string characNo)
        {
            var b = await new MemberService().UnlimitedWeight(int.Parse(characNo));
            OperateMsg = $"无限负重设置{(b ? "成功" : "失败")}";
        }

        async void DoOpenLeftAndRightCommand(string characNo)
        {
            var b = await new MemberService().OpenLeftAndRight(int.Parse(characNo));
            OperateMsg = $"开左右槽{(b ? "成功" : "失败")}";
        }

        async void DoExpertJobFullCommand(string characNo)
        {
            var b = await new MemberService().ExpertJobFull(int.Parse(characNo));
            OperateMsg = $"副职满级{(b ? "成功" : "失败")}";
        }

        async void DoMaxEquipLevelCommand(string characNo)
        {
            var b = await new MemberService().MaxEquipLevel(int.Parse(characNo));
            OperateMsg = $"解除装备权限{(b ? "成功" : "失败")}";
        }
    }
}
