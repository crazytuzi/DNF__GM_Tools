using System;
using System.Collections.Generic;
using System.Text;

namespace AY.DNF.GMTool.Db.Models
{
    /// <summary>
    /// 任务信息
    /// </summary>
    public class QuestModel
    {
        /// <summary>
        /// 任务槽位
        /// </summary>
        public int Slot { get; set; }

        /// <summary>
        /// 任务Id
        /// </summary>
        public int QuestIndex { get; set; }
    }
}
