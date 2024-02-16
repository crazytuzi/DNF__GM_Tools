using AY.DNF.GMTool.Db.Services;
using AY.DNF.GMTool.QuestTool.Models;
using HandyControl.Controls;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace AY.DNF.GMTool.QuestTool.ViewModels
{
    class QuestToolPageViewModel : BindableBase
    {
        int? _curCharacNo;

        #region 属性

        private ObservableCollection<QuestInfoItemModel> _questInfos = new ObservableCollection<QuestInfoItemModel>();

        public ObservableCollection<QuestInfoItemModel> QuestInfos
        {
            get { return _questInfos; }
            set { SetProperty(ref _questInfos, value); }
        }


        #endregion

        #region 命令

        ICommand? _refreshCommand;

        /// <summary>
        /// 刷新
        /// </summary>
        public ICommand RefreshCommand => _refreshCommand ??= new DelegateCommand<string>(DoRefreshCommand);

        ICommand? _finishQuestCommand;
        /// <summary>
        /// 完成任务
        /// </summary>
        public ICommand FinishQuestCommand => _finishQuestCommand ??= new DelegateCommand<QuestInfoItemModel>(DoFinishQuestCommand);

        #endregion

        public QuestToolPageViewModel()
        {

        }

        /// <summary>
        /// 刷新任务信息
        /// </summary>
        void DoRefreshCommand(string characNo)
        {
            if (string.IsNullOrWhiteSpace(characNo))
            {
                _curCharacNo = null;
                Growl.Warning("请先选择游戏角色");
                return;
            }

            _curCharacNo = int.Parse(characNo);

            LoadQuest((int)_curCharacNo);
        }

        /// <summary>
        /// 完成任务
        /// </summary>
        /// <param name="quest"></param>
        async void DoFinishQuestCommand(QuestInfoItemModel quest)
        {
            if (_curCharacNo == null)
            {
                Growl.Error("请先选择游戏角色");
                return;
            }

            var b = true;
            var ser = new PostalService();
            if (quest.QuestType == "需要道具")
            {
                if (quest.Items == null || quest.Items.Count <= 0) return;

                foreach (var item in quest.Items)
                {
                    var (bb, i) = await ser.SendPostal((int)_curCharacNo, "任务道具发放", item.ItemId, item.ItemCount, 0, 0, 0, 0, true);
                    b &= bb;
                }

                quest.Msg = $"任务道具发放{(b ? "成功" : "失败")},登录游戏收取邮件后完成任务";
            }
            else
            {
                b = await new MemberService().FinishQuest((int)_curCharacNo, quest.Slot);
                quest.Msg = $"触发任务完成{(b ? "成功" : "失败")}";
            }
        }

        /// <summary>
        /// 从数据库加载任务
        /// </summary>
        async void LoadQuest(int characNo)
        {
            QuestInfos.Clear();

            var questList = await new MemberService().GetCharacQuests(characNo);
            if (questList.Count <= 0) return;

            var quests = await new GMToolService().GetQuests(questList.Select(t => t.QuestIndex).ToArray());

            for (var i = 0; i < questList.Count; i++)
            {
                var qm = questList[i];
                var q = quests.FirstOrDefault(t => t.QuestIndex == qm.QuestIndex);

                var questInfo = new QuestInfoItemModel
                {
                    Slot = qm.Slot,
                    QuestIndex = qm.QuestIndex,
                    QuestName = q?.QuestName,
                    QuestType = q?.QuestType,
                    QuestDesc = q?.QuestItemsDescription,
                    Grade = q?.Grade
                };
                questInfo.QuestDesc = string.IsNullOrWhiteSpace(questInfo.QuestDesc) ? "-" : questInfo.QuestDesc;

                if (q != null && !string.IsNullOrWhiteSpace(q.QuestItems))
                {
                    questInfo.Items = new List<QuestItemModel>();
                    var items = q.QuestItems.Split("@", StringSplitOptions.RemoveEmptyEntries);
                    foreach (var item in items)
                    {
                        var arr = item.Split("-", StringSplitOptions.RemoveEmptyEntries);
                        if (arr.Length < 2) continue;

                        questInfo.Items.Add(new QuestItemModel { ItemId = int.Parse(arr[0]), ItemCount = int.Parse(arr[1]) });
                    }
                }

                if (questInfo.QuestName.Contains("副职业") && questInfo.Grade == "普通")
                {
                    questInfo.Grade = "副职业";
                    questInfo.QuestName = questInfo.QuestName.Replace("副职业", "").Replace("-", "").Trim();
                }
                QuestInfos.Add(questInfo);
            }
        }
    }
}
