using AY.DNF.GMTool.Db.Services;
using AY.DNF.GMTool.Postal.Models;
using HandyControl.Controls;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AY.DNF.GMTool.Postal.ViewModels
{
    class PostalPageViewModel : BindableBase
    {
        int? _lastLetterId;

        #region 属性

        private string? _msg = string.Empty;
        /// <summary>
        /// 操作消息
        /// </summary>
        public string? Msg
        {
            get { return _msg; }
            set
            {
                SetProperty(ref _msg, value);
                if (!string.IsNullOrWhiteSpace(value))
                    Task.Run(() =>
                    {
                        Task.Delay(2000).Wait();
                        Msg = null;
                    });
            }
        }

        private string? _searchText;
        /// <summary>
        /// 查询关键字
        /// </summary>
        public string? SearchText
        {
            get { return _searchText; }
            set { SetProperty(ref _searchText, value); }
        }

        private string? _letterContent = "非常感谢您的支持，GM工具的功能会越来越强大的！有什么BUG或建议请您及时反馈";
        /// <summary>
        /// 邮件默认内容
        /// </summary>
        public string? LetterContent
        {
            get { return _letterContent; }
            set
            {
                SetProperty(ref _letterContent, value);
                WriteLetterData();
            }
        }

        private ItemModel? _selectedItem;
        /// <summary>
        /// 选中的物品
        /// </summary>
        public ItemModel? SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                SetProperty(ref _selectedItem, value);
                if (value == null)
                    SelectedItemId = null;
                else
                    SelectedItemId = int.Parse(value.ItemId!);
            }
        }

        private int? _selectedItemId;
        /// <summary>
        /// 选中的物品ID
        /// </summary>
        public int? SelectedItemId
        {
            get { return _selectedItemId; }
            set { SetProperty(ref _selectedItemId, value); }
        }

        private int _count = 1;
        /// <summary>
        /// 数量
        /// </summary>
        public int Count
        {
            get { return _count; }
            set { SetProperty(ref _count, value); }
        }

        private int _strengthen = 0;
        /// <summary>
        /// 强化
        /// </summary>
        public int Strengthen
        {
            get { return _strengthen; }
            set { SetProperty(ref _strengthen, value); }
        }

        private int _forge = 0;
        /// <summary>
        /// 锻造
        /// </summary>
        public int Forge
        {
            get { return _forge; }
            set { SetProperty(ref _forge, value); }
        }

        private bool _isRed = false;
        /// <summary>
        /// 是否红字
        /// </summary>
        public bool IsRed
        {
            get { return _isRed; }
            set { SetProperty(ref _isRed, value); }
        }

        private int _selectedRed = 3;
        /// <summary>
        /// 选中的红字类型
        /// </summary>
        public int SelectedRed
        {
            get { return _selectedRed; }
            set { SetProperty(ref _selectedRed, value); }
        }

        private int _redValue = 0;
        /// <summary>
        /// 红字值
        /// </summary>
        public int RedValue
        {
            get { return _redValue; }
            set { SetProperty(ref _redValue, value); }
        }

        private bool _isPackaged = false;
        /// <summary>
        /// 是否封装
        /// </summary>
        public bool IsPackaged
        {
            get { return _isPackaged; }
            set { SetProperty(ref _isPackaged, value); }
        }

        private ObservableCollection<KeyValuePair<string, int>> _reds = new()
        {
            new KeyValuePair<string, int>("力量",3),
            new KeyValuePair<string, int>("智力",4),
            new KeyValuePair<string, int>("体力",1),
            new KeyValuePair<string, int>("精神",2),
        };
        /// <summary>
        /// 红字类型列表
        /// </summary>
        public ObservableCollection<KeyValuePair<string, int>> Reds
        {
            get { return _reds; }
            set { SetProperty(ref _reds, value); }
        }

        #endregion

        private ObservableCollection<ItemModel> _items = new();
        /// <summary>
        /// 物品查询结果
        /// </summary>
        public ObservableCollection<ItemModel> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        #region 命令

        ICommand? _sendCommand;
        ICommand? _sendAllCommand;
        ICommand? _deleteCommand;
        ICommand? _deleteAllCommand;
        ICommand? _searchStackableCommand;
        ICommand? _searchEquipmentCommand;

        /// <summary>
        /// 查询道具
        /// </summary>
        public ICommand SearchStackableCommand => _searchStackableCommand ??= new DelegateCommand(DoSearchStackableCommand);

        /// <summary>
        /// 查询装备
        /// </summary>
        public ICommand SearchEquipmentCommand => _searchEquipmentCommand ??= new DelegateCommand(DoSearchEquipmentCommand);

        /// <summary>
        /// 发送邮件
        /// </summary>
        public ICommand SendCommand => _sendCommand ??= new DelegateCommand<string>(DoSendCommand);

        /// <summary>
        /// 全服发送邮件
        /// </summary>
        public ICommand SendAllCommand => _sendAllCommand ??= new DelegateCommand<string>(DoSendAllCommand);

        /// <summary>
        /// 删除邮件
        /// </summary>
        public ICommand DeleteCommand => _deleteCommand ??= new DelegateCommand(DoDeleteCommand);

        /// <summary>
        /// 删除全服邮件
        /// </summary>
        public ICommand DeleteAllCommand => _deleteAllCommand ??= new DelegateCommand(DoDeleteAllCommand);

        #endregion

        public PostalPageViewModel()
        {
            ReadLetterData();
        }

        #region 信件内容

        void ReadLetterData()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "letter.dat");
            if (!File.Exists(path)) return;

            LetterContent = File.ReadAllText(path);
        }

        void WriteLetterData()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "letter.dat");
            File.WriteAllText(path, LetterContent);
        }

        #endregion

        /// <summary>
        /// 查询道具
        /// </summary>
        async void DoSearchStackableCommand()
        {
            Msg = string.Empty;
            Items.Clear();

            if (string.IsNullOrWhiteSpace(SearchText))
                return;

            var b = await new GMToolService().StackablesHasData();
            if (!b)
            {
                Growl.Warning("请先导入Script.pvf");
                return;
            }

            var list = await new GMToolService().SearchStackables(SearchText);
            Items.AddRange(list.Select(t => new ItemModel
            {
                ItemId = t.ItemId,
                ItemName = t.ItemName
            }));
        }

        /// <summary>
        /// 查询装备
        /// </summary>
        async void DoSearchEquipmentCommand()
        {
            Msg = string.Empty;
            Items.Clear();

            if (string.IsNullOrWhiteSpace(SearchText))
                return;

            var b = await new GMToolService().EquipmentsHasData();
            if (!b)
            {
                Growl.Warning("请先导入Script.pvf");
                return;
            }

            var list = await new GMToolService().SearchEquipments(SearchText);
            Items.AddRange(list.Select(t => new ItemModel
            {
                ItemId = t.ItemId,
                ItemName = t.ItemName
            }));
        }

        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="characNo"></param>
        async void DoSendCommand(string characNo)
        {
            Msg = string.Empty;

            if (string.IsNullOrWhiteSpace(characNo))
            {
                Growl.Error("请选择游戏角色");
                return;
            }

            if (SelectedItemId == null)
            {
                Growl.Error("请选择物品");
                return;
            }

            var redValue = 0;
            if (IsRed)
            {
                redValue = RedValue;
            }
            var (b, i) = await new PostalService().SendPostal(int.Parse(characNo), LetterContent!, (int)SelectedItemId, Count, Forge, Strengthen, SelectedRed, redValue, IsPackaged);
            _lastLetterId = i;
            Msg = $"发送邮件{(b ? "成功" : "失败")}";
        }

        /// <summary>
        /// 全服发送
        /// </summary>
        /// <param name="characNo"></param>
        void DoSendAllCommand(string characNo)
        {
            if (string.IsNullOrWhiteSpace(characNo))
            {
                Growl.Error("请选择游戏角色");
                return;
            }
        }

        /// <summary>
        /// 删除邮件
        /// </summary>
        /// <param name="characNo"></param>
        async void DoDeleteCommand()
        {
            if (_lastLetterId == null)
            {
                Msg = "没有最近发送的邮件可删除";
                return;
            }

            var b = await new PostalService().Delete((int)_lastLetterId);
            Msg = $"删除邮件{(b ? "成功" : "失败")}";
        }

        /// <summary>
        /// 删除全服邮件
        /// </summary>
        /// <param name="characNo"></param>
        async void DoDeleteAllCommand()
        {
            var b = await new PostalService().DeleteAll();
            Msg = $"删除全服邮件{(b ? "成功" : "失败")}";
        }
    }
}
