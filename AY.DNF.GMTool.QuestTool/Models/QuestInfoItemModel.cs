using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AY.DNF.GMTool.QuestTool.Models
{
    /// <summary>
    /// 任务信息
    /// </summary>
    public class QuestInfoItemModel : BindableBase
    {
        public int Slot { get; set; }
        public int QuestIndex { get; set; }
        public string Grade { get; set; }
        public string QuestType { get; set; }
        public string QuestName { get; set; }
        public string QuestDesc { get; set; }
        public List<QuestItemModel>? Items { get; set; } = new List<QuestItemModel>();

        private string _msg;

        public string Msg
        {
            get { return _msg; }
            set { SetProperty(ref _msg, value); }
        }

    }

    /// <summary>
    /// 任务物品
    /// </summary>
    public class QuestItemModel
    {
        public int ItemId { get; set; }
        public int ItemCount { get; set; }
    }
}
