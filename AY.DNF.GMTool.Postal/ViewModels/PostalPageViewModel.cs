using AY.DNF.GMTool.Db.Services;
using AY.DNF.GMTool.Postal.Models;
using HandyControl.Controls;
using Prism.Commands;
using Prism.Mvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace AY.DNF.GMTool.Postal.ViewModels
{
    class PostalPageViewModel : BindableBase
    {
        #region 属性

        private string? _msg;

        public string? Msg
        {
            get { return _msg; }
            set { SetProperty(ref _msg, value); }
        }


        private string? _searchText;

        public string? SearchText
        {
            get { return _searchText; }
            set { SetProperty(ref _searchText, value); }
        }

        private string? _letterContent = "非常感谢您的支持，GM工具的功能会越来越强大的！有什么BUG或建议请您及时反馈";

        public string? LetterContent
        {
            get { return _letterContent; }
            set { SetProperty(ref _letterContent, value); }
        }

        private ItemModel _selectedItem;

        public ItemModel SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                SetProperty(ref _selectedItem, value);
                SelectedItemId = int.Parse(value.ItemId!);
            }
        }


        private int _selectedItemId;

        public int SelectedItemId
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

        public bool IsRed
        {
            get { return _isRed; }
            set { SetProperty(ref _isRed, value); }
        }

        private int _selectedRed = 3;

        public int SelectedRed
        {
            get { return _selectedRed; }
            set { SetProperty(ref _selectedRed, value); }
        }
        private int _redValue = 0;

        public int RedValue
        {
            get { return _redValue; }
            set { SetProperty(ref _redValue, value); }
        }


        private bool _isPackaged = false;

        public bool IsPackaged
        {
            get { return _isPackaged; }
            set { SetProperty(ref _isPackaged, value); }
        }

        private ObservableCollection<KeyValuePair<string, int>> _reds = new ObservableCollection<KeyValuePair<string, int>>
        {
            new KeyValuePair<string, int>("力量",3),
            new KeyValuePair<string, int>("智力",4),
            new KeyValuePair<string, int>("体力",1),
            new KeyValuePair<string, int>("精神",2),
        };

        public ObservableCollection<KeyValuePair<string, int>> Reds
        {
            get { return _reds; }
            set { SetProperty(ref _reds, value); }
        }

        #endregion

        private ObservableCollection<ItemModel> _items = new ObservableCollection<ItemModel>();

        public ObservableCollection<ItemModel> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        #region 命令
        ICommand _sendCommand;
        ICommand _sendAllCommand;
        ICommand _deleteCommand;
        ICommand _deleteAllCommand;
        ICommand _searchCommand;

        public ICommand SearchCommand => _searchCommand ??= new DelegateCommand(DoSearchCommand);

        public ICommand SendCommand => _sendCommand ??= new DelegateCommand<string>(DoSendCommand);

        public ICommand SendAllCommand => _sendAllCommand ??= new DelegateCommand<string>(DoSendAllCommand);

        public ICommand DeleteCommand => _deleteCommand ??= new DelegateCommand<string>(DoDeleteCommand);

        public ICommand DeleteAllCommand => _deleteAllCommand ??= new DelegateCommand<string>(DoDeleteAllCommand);

        #endregion

        public PostalPageViewModel()
        {

        }

        async void DoSearchCommand()
        {
            if (string.IsNullOrWhiteSpace(SearchText))
            {
                Items.Clear();
                return;
            }
            var list = await new LocalItemsService().SearchItems(SearchText);
            Items.AddRange(list.Select(t => new ItemModel
            {
                ItemId = t.ItemId,
                ItemName = t.ItemName
            }));
        }

        async void DoSendCommand(string characNo)
        {
            if (string.IsNullOrWhiteSpace(characNo))
            {
                Growl.Error("请选择游戏角色");
                return;
            }

            var redValue = 0;
            if (IsRed)
            {
                redValue = RedValue;
            }
            var b = await new PostalService().SendPostal(int.Parse(characNo), LetterContent!, SelectedItemId, Count, Forge, Strengthen, SelectedRed, redValue, IsPackaged);
            Msg = $"发送邮件{(b ? "成功" : "失败")}";
        }


        void DoSendAllCommand(string characNo)
        {
            if (string.IsNullOrWhiteSpace(characNo))
            {
                Growl.Error("请选择游戏角色");
                return;
            }
        }

        void DoDeleteCommand(string characNo)
        {
            if (string.IsNullOrWhiteSpace(characNo))
            {
                Growl.Error("请选择游戏角色");
                return;
            }
        }

        void DoDeleteAllCommand(string characNo)
        {
            if (string.IsNullOrWhiteSpace(characNo))
            {
                Growl.Error("请选择游戏角色");
                return;
            }
        }
    }
}
