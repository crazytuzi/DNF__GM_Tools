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
        #region 属性

        private string? _pvfPath;
        /// <summary>
        /// PVF 文件路径
        /// </summary>
        public string? PvfPath
        {
            get { return _pvfPath; }
            set { SetProperty(ref _pvfPath, value); }
        }

        #endregion

        #region pvf解析日志

        private string _dungeonCount = string.Empty;
        /// <summary>
        /// 地下城数量
        /// </summary>
        public string DungeonCount
        {
            get { return _dungeonCount; }
            set { SetProperty(ref _dungeonCount, value); }
        }

        private ObservableCollection<string> _dungeonLogs = new();
        /// <summary>
        /// 地下城解析日志
        /// </summary>
        public ObservableCollection<string> DungeonLogs
        {
            get { return _dungeonLogs; }
            set { SetProperty(ref _dungeonLogs, value); }
        }

        private string _equipmentCount = string.Empty;
        /// <summary>
        /// 装备数量
        /// </summary>
        public string EquipmentCount
        {
            get { return _equipmentCount; }
            set { SetProperty(ref _equipmentCount, value); }
        }

        private ObservableCollection<string> _equipmentLogs = new();
        /// <summary>
        /// 装备解析日志
        /// </summary>
        public ObservableCollection<string> EquipmentLogs
        {
            get { return _equipmentLogs; }
            set { SetProperty(ref _equipmentLogs, value); }
        }

        private string _stackableCount = string.Empty;
        /// <summary>
        /// 道具数量
        /// </summary>
        public string StackableCount
        {
            get { return _stackableCount; }
            set { SetProperty(ref _stackableCount, value); }
        }

        private ObservableCollection<string> _stackableLogs = new();
        /// <summary>
        /// 道具解析日志
        /// </summary>
        public ObservableCollection<string> StackableLogs
        {
            get { return _stackableLogs; }
            set { SetProperty(ref _stackableLogs, value); }
        }

        #endregion

        #region 命令

        ICommand? _pvfParseCommand;
        /// <summary>
        /// PVF解析
        /// </summary>
        public ICommand PvfParseCommand => _pvfParseCommand ??= new DelegateCommand(DoPvfParseCommand);

        #endregion

        public PvfPageViewModel()
        {

        }

        /// <summary>
        /// PVF解析
        /// </summary>
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

            Task.Run(() =>
            {
                using var pvf = new PvfFile(PvfPath);
                AnalysisDungeons(pvf);
                AnalysisEquipments(pvf);
                AnalysisStackables(pvf);
            });
        }

        /// <summary>
        /// 解析PVF地下城数据
        /// </summary>
        /// <param name="pvf"></param>
        void AnalysisDungeons(PvfFile pvf)
        {
            var dungeonContent = pvf.GetPvfFileByPath("dungeon/dungeon.lst", Encoding.UTF8);
            if (dungeonContent == null)
            {
                DispatcherInfos(() => DungeonLogs.Insert(0, "未解析出地下城信息"));
                return;
            }

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

        /// <summary>
        /// 解析PVF装备数据
        /// </summary>
        /// <param name="pvf"></param>
        void AnalysisEquipments(PvfFile pvf)
        {
            var itemDic = pvf.GetPvfFileByPath("equipment/equipment.lst", Encoding.UTF8);
            if (itemDic == null)
            {
                DispatcherInfos(() => EquipmentLogs.Insert(0, "未解析出装备信息"));
                return;
            }

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
                var equipEdu = pvf.GetPvfFileByPath($"equipment/{path}", Encoding.UTF8);
                if (string.IsNullOrWhiteSpace(equipEdu)) continue;
                var eduInfos = equipEdu.Split("\r\n", StringSplitOptions.RemoveEmptyEntries).Where(t => !t.StartsWith("#")).ToList();
                var index = eduInfos.IndexOf("[name]");
                var name = eduInfos[index + 1].Replace("`", "");

                list.Add(new Equipments { ItemId = id, ItemName = ChineseConverter.Convert(name, ChineseConversionDirection.TraditionalToSimplified) });

                DispatcherInfos(() => EquipmentCount = $"{(i + 1)}/{total}");
            }

            DispatcherInfos(() => EquipmentLogs.Insert(0, "写入数据..."));

            new GMToolService().WriteEquipData(list);

            DispatcherInfos(() => EquipmentLogs.Insert(0, "完成..."));
        }

        /// <summary>
        /// 解析PVF道具数据
        /// </summary>
        /// <param name="pvf"></param>
        void AnalysisStackables(PvfFile pvf)
        {
            var itemDic = pvf.GetPvfFileByPath("stackable/stackable.lst", Encoding.UTF8);
            if (itemDic == null)
            {
                DispatcherInfos(()=> StackableLogs.Insert(0,"未解析出道具信息"));
                return;
            }

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
                var stackableEdu = pvf.GetPvfFileByPath($"stackable/{path}", Encoding.UTF8);
                if (string.IsNullOrWhiteSpace(stackableEdu)) continue;
                var eduInfos = stackableEdu.Split("\r\n", StringSplitOptions.RemoveEmptyEntries).Where(t => !t.StartsWith("#")).ToList();
                var index = eduInfos.IndexOf("[name]");
                var name = eduInfos[index + 1].Replace("`", "");

                list.Add(new Stackables { ItemId = id, ItemName = ChineseConverter.Convert(name, ChineseConversionDirection.TraditionalToSimplified) });

                DispatcherInfos(() => StackableCount = $"{(i + 1)}/{total}");
            }

            DispatcherInfos(() => StackableLogs.Insert(0, "写入数据..."));

            new GMToolService().WriteStackableData(list);

            DispatcherInfos(() => StackableLogs.Insert(0, "完成..."));
        }

        static void DispatcherInfos(Action act)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                act();
            });
        }
    }
}
