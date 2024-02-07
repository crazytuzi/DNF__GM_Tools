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
using System.Windows.Documents;
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

        private ObservableCollection<string> _otherLogs = new();
        /// <summary>
        /// 其他解析日志
        /// </summary>
        public ObservableCollection<string> OtherLogs
        {
            get { return _otherLogs; }
            set { SetProperty(ref _otherLogs, value); }
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
                AnalysisJob(pvf);
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
                DispatcherInfos(() => StackableLogs.Insert(0, "未解析出道具信息"));
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

        /// <summary>
        /// 解析职业树
        /// </summary>
        /// <param name="pvf"></param>
        void AnalysisJob(PvfFile pvf)
        {
            var characLst = pvf.GetPvfFileByPath("character/character.lst", Encoding.UTF8);
            if (characLst == null)
            {
                DispatcherInfos(() => OtherLogs.Insert(0, "未解析出职业信息"));
                return;
            }

            DispatcherInfos(() => OtherLogs.Insert(0, "准备加载职业数据..."));

            var characArr = characLst.Split("\r\n", StringSplitOptions.RemoveEmptyEntries)
                   .Where(t => !t.StartsWith("#"))
                   .ToList();
            var baseJob = characArr.Select(t =>
            {
                var arr = t.Split("\t", StringSplitOptions.RemoveEmptyEntries);
                return new JobTree
                {
                    JobId = int.Parse(arr[0]),
                    JobName = arr[1].Replace("`", ""),
                    GrowJobs = new List<JobTree>(),
                    ParentId = "root"
                };
            }).ToList();

            var jobTreeData = new List<JobTree>();

            foreach (var job in baseJob)
            {
                var jobInfo = pvf.GetPvfFileByPath($"character/{job.JobName}", Encoding.UTF8);
                var jobs = jobInfo.Split("\r\n", StringSplitOptions.RemoveEmptyEntries)
                                .Where(t => !t.StartsWith("#"))
                                .ToList();

                var startIndex = jobs.IndexOf("[job]");
                var enJob = jobs[startIndex + 1].Replace("`", "").Replace("[", "").Replace("]", "");

                var exJobName = "";

                if (enJob.Contains("fighter"))
                    if (enJob.StartsWith("at"))
                        exJobName = "(男)";
                    else
                        exJobName = "(女)";
                else if (enJob.Contains("gunner"))
                    if (enJob.StartsWith("at"))
                        exJobName = "(女)";
                    else
                        exJobName = "(男)";
                else if (enJob.Contains("mage"))
                    if (enJob.StartsWith("at"))
                        exJobName = "(男)";
                    else
                        exJobName = "(女)";

                startIndex = jobs.IndexOf("[growtype name]");
                var i = startIndex + 1;
                // 职业数量
                var jobCount = 0;
                while (jobs[i].StartsWith("`"))
                {
                    i++;
                    jobCount++;
                }

                // 基础职业名
                job.JobName = ChineseConverter.Convert(jobs[startIndex + 1], ChineseConversionDirection.TraditionalToSimplified).Replace("`", "");

                // 一转职业 二进制串
                var jobBin = "";
                for (i = 0; i < jobCount; i++)
                    jobBin += "0";

                // 一转职业
                i = 1;
                while (i < jobCount)
                {
                    var tmp = jobBin!.ToArray();
                    tmp[tmp.Length - 1 - i] = '1';
                    var jobId = string.Join("", tmp);
                    var growJob = new JobTree
                    {
                        JobId = Convert.ToInt32(jobId, 2),
                        JobName = ChineseConverter.Convert(jobs[startIndex + 1 + i].Replace("`", ""), ChineseConversionDirection.TraditionalToSimplified),
                        GrowJobs = new List<JobTree>(),
                        ParentId = job.Id
                    };

                    jobTreeData.Add(growJob);

                    var growTypeIndex = jobs.IndexOf($"[growtype {(i + 1)}]");
                    if (growTypeIndex <= 0) break;
                    // 觉醒职业
                    for (var j = 0; j < jobs.Count; j++)
                    {
                        var index = j + growTypeIndex;
                        if (jobs[index] != "[awakening name]") continue;
                        var tjn1 = ChineseConverter.Convert(jobs[index + 1].Replace("`", ""), ChineseConversionDirection.TraditionalToSimplified);
                        var tjn2 = ChineseConverter.Convert(jobs[index + 2].Replace("`", ""), ChineseConversionDirection.TraditionalToSimplified);
                        var tjn3 = ChineseConverter.Convert(jobs[index + 3].Replace("`", ""), ChineseConversionDirection.TraditionalToSimplified);

                        var tjnTree = new JobTree { JobId = 1, JobName = tjn1, ParentId = growJob.Id };
                        growJob.GrowJobs.Add(tjnTree);
                        jobTreeData.Add(tjnTree);

                        if (!tjn2.StartsWith("["))
                        {
                            tjnTree = new JobTree { JobId = 2, JobName = tjn2, ParentId = growJob.Id };
                            growJob.GrowJobs.Add(tjnTree);
                            jobTreeData.Add(tjnTree);
                        }
                        else
                            // 没有二转职业 就不看后面了
                            continue;

                        if (!tjn3.StartsWith("["))
                        {
                            tjnTree = new JobTree { JobId = 3, JobName = tjn3, ParentId = growJob.Id };
                            growJob.GrowJobs.Add(tjnTree);
                            jobTreeData.Add(tjnTree);
                        }

                        break;
                    }

                    i++;
                }

                job.JobName += exJobName;

                jobTreeData.Add(job);
            }

            DispatcherInfos(() => OtherLogs.Insert(0, "职业数据解析完毕..."));

            DispatcherInfos(() => OtherLogs.Insert(0, "写入职业数据..."));

            new GMToolService().WriteJobData(jobTreeData);

            DispatcherInfos(() => OtherLogs.Insert(0, "职业数据写入完成..."));
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
