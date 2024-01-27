using AY.DNF.GMTool.Db.Services;
using AY.DNF.GMTool.Pvf.Models;
using HandyControl.Controls;
using Prism.Commands;
using Prism.Mvvm;
using pvfLoaderXinyu;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace AY.DNF.GMTool.Pvf.ViewModels
{
    class PvfPageViewModel : BindableBase
    {
        #region 属性

        private Visibility _isLoading = Visibility.Hidden;

        public Visibility IsLoading
        {
            get { return _isLoading; }
            set { SetProperty(ref _isLoading, value); }
        }
        private string _loadingText;

        public string LoadingText
        {
            get { return _loadingText; }
            set { SetProperty(ref _loadingText, value); }
        }


        private string? _pvfPath;

        public string? PvfPath
        {
            get { return _pvfPath; }
            set { SetProperty(ref _pvfPath, value); }
        }

        private ObservableCollection<DungeonItemModel> _dungeonItems = new ObservableCollection<DungeonItemModel>();

        public ObservableCollection<DungeonItemModel> DungeonItems
        {
            get { return _dungeonItems; }
            set { SetProperty(ref _dungeonItems, value); }
        }

        private ObservableCollection<EquipItemModel> _equipItems = new ObservableCollection<EquipItemModel>();

        public ObservableCollection<EquipItemModel> EquipItems
        {
            get { return _equipItems; }
            set { SetProperty(ref _equipItems, value); }
        }

        #endregion

        #region 命令

        ICommand _pvfParseCommand;

        public ICommand PvfParseCommand => _pvfParseCommand ??= new DelegateCommand(DoPvfParseCommand);

        #endregion

        public PvfPageViewModel()
        {

        }

        void DoPvfParseCommand()
        {
            if (string.IsNullOrWhiteSpace(PvfPath))
            {
                Growl.Error("请选择PVF文件");
                return;
            }

            if (!File.Exists(PvfPath))
            {
                Growl.Error("文件不存在");
                return;
            }

            DungeonItems.Clear();
            EquipItems.Clear();

            IsLoading = Visibility.Visible;
            LoadingText = string.Empty;

            Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() => LoadingText = "正在加载PVF文件");

                using var pvf = new PvfFile(PvfPath);

                #region 地下城

                var dungeonContent = pvf.getPvfFileByPath("dungeon/dungeon.lst", Encoding.UTF8);
                Application.Current.Dispatcher.Invoke(() => LoadingText = "解析地下城成功,准备加载数据...");
                var arrDungeon = dungeonContent.Split("\n", System.StringSplitOptions.RemoveEmptyEntries);
                foreach (var dungeon in arrDungeon)
                {
                    if (dungeon.StartsWith("#")) continue;
                    if (string.IsNullOrWhiteSpace(dungeon)) continue;
                    var arr = dungeon.Replace("\r", "").Split("\t");

                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        DungeonItems.Add(new DungeonItemModel { Id = arr[0], Name = arr[1].Replace("`", "") });
                    });
                }

                Application.Current.Dispatcher.Invoke(() => LoadingText = "地下城数据导入数据库");
                new GMToolService().WriteEquipData(EquipItems.Select(t => new Db.DbModels.GMTool.EquipDictionary
                {
                    Id = Guid.NewGuid().ToString("n"),
                    ItemId = t.ItemId,
                    ItemName = t.ItemName
                }).ToList());

                Application.Current.Dispatcher.Invoke(() => LoadingText = "地下城数据加载完成,准备解析准备...");

                #endregion

                #region 装备辞典

                var itemDic = pvf.getPvfFileByPath("etc/itemdictionary/(r)itemdictionary.etc", Encoding.UTF8);
                Application.Current.Dispatcher.Invoke(() => LoadingText = "装备数据解析完成,准备加载数据...");
                var itemArr = itemDic.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in itemArr)
                {
                    if (item.StartsWith("#")) continue;
                    if (string.IsNullOrWhiteSpace(item)) continue;
                    var arr = item.Split("\t", StringSplitOptions.RemoveEmptyEntries);
                    if (arr.Length < 13) continue;

                    var id = arr[0];
                    var name = arr[12];
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        EquipItems.Add(new EquipItemModel { ItemId = id, ItemName = name.Replace("`", "") });
                    });
                }

                #endregion

                Application.Current.Dispatcher.Invoke(() => LoadingText = "装备数据导入数据库");
                new GMToolService().WriteEquipData(EquipItems.Select(t => new Db.DbModels.GMTool.EquipDictionary
                {
                    Id = Guid.NewGuid().ToString("n"),
                    ItemId = t.ItemId,
                    ItemName = t.ItemName
                }).ToList());

                IsLoading = Visibility.Hidden;
            });

        }
    }
}
