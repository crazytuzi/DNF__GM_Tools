using AY.DNF.GMTool.Db.DbModels.GMTool;
using AY.DNF.GMTool.Db.Services;
using AY.DNF.GMTool.Pvf.Models;
using HandyControl.Controls;
using Microsoft.International.Converters.TraditionalChineseToSimplifiedConverter;
using Prism.Commands;
using Prism.Mvvm;
using pvfLoaderXinyu;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace AY.DNF.GMTool.Pvf.ViewModels
{
    class PvfPageViewModel : BindableBase
    {
        Encoding gb2312 = Encoding.GetEncoding("GB2312");
        Encoding big5 = Encoding.GetEncoding("big5");

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

        #endregion

        #region pvf解析日志

        private string _dungeonCount;

        public string DungeonCount
        {
            get { return _dungeonCount; }
            set { SetProperty(ref _dungeonCount, value); }
        }

        private ObservableCollection<string> _dungeonLogs = new ObservableCollection<string>();

        public ObservableCollection<string> DungeonLogs
        {
            get { return _dungeonLogs; }
            set { SetProperty(ref _dungeonLogs, value); }
        }

        private string _equipmentCount;

        public string EquipmentCount
        {
            get { return _equipmentCount; }
            set { SetProperty(ref _equipmentCount, value); }
        }

        private ObservableCollection<string> _equipmentLogs = new ObservableCollection<string>();

        public ObservableCollection<string> EquipmentLogs
        {
            get { return _equipmentLogs; }
            set { SetProperty(ref _equipmentLogs, value); }
        }

        private string _stackableCount;

        public string StackableCount
        {
            get { return _stackableCount; }
            set { SetProperty(ref _stackableCount, value); }
        }

        private ObservableCollection<string> _stackableLogs = new ObservableCollection<string>();

        public ObservableCollection<string> StackableLogs
        {
            get { return _stackableLogs; }
            set { SetProperty(ref _stackableLogs, value); }
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

            IsLoading = Visibility.Visible;
            LoadingText = string.Empty;

            Task.Run(() =>
            {
                using var pvf = new PvfFile(PvfPath);
                AnalysisDungeons(pvf);
                AnalysisEquipments(pvf);
                AnalysisStackables(pvf);
            });
        }

        void AnalysisDungeons(PvfFile pvf)
        {

            var dungeonContent = pvf.getPvfFileByPath("dungeon/dungeon.lst", Encoding.UTF8);

            DispatcherInfos(() => DungeonLogs.Insert(0, "准备加载数据..."));

            var arrDungeon = dungeonContent.Split("\n", System.StringSplitOptions.RemoveEmptyEntries);

            var total = arrDungeon.Length;

            DispatcherInfos(() => DungeonCount = $"0/{total}");

            var list = new List<Dungeons>();

            for (var i = 0; i < total; i++)
            {
                var dungeon = arrDungeon[i];
                if (dungeon.StartsWith("#")) continue;
                if (string.IsNullOrWhiteSpace(dungeon)) continue;
                var arr = dungeon.Replace("\r", "").Split("\t");

                list.Add(new Dungeons { ItemId = arr[0], ItemName = arr[1].Replace("`", "") });

                DispatcherInfos(() => DungeonCount = $"{(i + 1)}/{total}");
            }

            DispatcherInfos(() => DungeonLogs.Insert(0, "写入数据..."));

            new GMToolService().WriteDungeonData(list);

            DispatcherInfos(() => DungeonLogs.Insert(0, "完成..."));
        }

        void AnalysisEquipments(PvfFile pvf)
        {
            var itemDic = pvf.getPvfFileByPath("equipment/equipment.lst", Encoding.UTF8);

            DispatcherInfos(() => EquipmentLogs.Insert(0, "准备加载数据..."));

            var itemArr = itemDic.Split("\r\n", StringSplitOptions.RemoveEmptyEntries).Where(t => !t.StartsWith('#')).ToList();
            var total = itemArr.Count;

            DispatcherInfos(() => EquipmentCount = $"0/{total}");

            var list = new List<Equipments>();

            for (var i = 0; i < total; i++)
            {
                var item = itemArr[i];
                var arr = item.Split("\t", StringSplitOptions.RemoveEmptyEntries);
                if (arr.Length < 1) continue;
                var id = arr[0];
                var path = arr[1].Replace("`", "");
                var equipEdu = pvf.getPvfFileByPath($"equipment/{path}", Encoding.UTF8);
                var eduInfos = equipEdu.Split("\r\n", StringSplitOptions.RemoveEmptyEntries).Where(t => !t.StartsWith("#")).ToList();
                var index = eduInfos.IndexOf("[name]");
                var name = eduInfos[index + 1].Replace("`", "");

                list.Add(new Equipments { ItemId = id, ItemName = ChineseConverter.Convert(name,ChineseConversionDirection.TraditionalToSimplified)});

                DispatcherInfos(() => EquipmentCount = $"{(i + 1)}/{total}");
            }

            DispatcherInfos(() => EquipmentLogs.Insert(0, "写入数据..."));

            new GMToolService().WriteEquipData(list);

            DispatcherInfos(() => EquipmentLogs.Insert(0, "完成..."));
        }

        void AnalysisStackables(PvfFile pvf)
        {
            var itemDic = pvf.getPvfFileByPath("stackable/stackable.lst", Encoding.UTF8);

            DispatcherInfos(() => StackableLogs.Insert(0, "准备加载数据..."));

            var itemArr = itemDic.Split("\r\n", StringSplitOptions.RemoveEmptyEntries).Where(t => !t.StartsWith('#')).ToList();
            var total = itemArr.Count;

            DispatcherInfos(() => StackableCount = $"0/{total}");

            var list = new List<Stackables>();

            for (var i = 0; i < total; i++)
            {
                var item = itemArr[i];
                var arr = item.Split("\t", StringSplitOptions.RemoveEmptyEntries);
                if (arr.Length < 1) continue;
                var id = arr[0];
                var path = arr[1].Replace("`", "");
                var equipEdu = pvf.getPvfFileByPath($"stackable/{path}", Encoding.UTF8);
                var eduInfos = equipEdu.Split("\r\n", StringSplitOptions.RemoveEmptyEntries).Where(t => !t.StartsWith("#")).ToList();
                var index = eduInfos.IndexOf("[name]");
                var name = eduInfos[index + 1].Replace("`", "");

                list.Add(new Stackables { ItemId = id, ItemName = ChineseConverter.Convert(name, ChineseConversionDirection.TraditionalToSimplified) });

                DispatcherInfos(() => StackableCount = $"{(i + 1)}/{total}");
            }

            DispatcherInfos(() => StackableLogs.Insert(0, "写入数据..."));

            new GMToolService().WriteStackableData(list);

            DispatcherInfos(() => StackableLogs.Insert(0, "完成..."));
        }

        string ToSimple(string org)
        {
            return gb2312.GetString(big5.GetBytes(org));
        }

        void DispatcherInfos(Action act)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                act();
            });
        }
    }
}
