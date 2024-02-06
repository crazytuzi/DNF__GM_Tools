using System;

namespace AY.DNF.GMTool.BubbleTimer.Models
{
    /// <summary>
    /// 运行日志Model
    /// </summary>
    public class RunLogModel
    {
        /// <summary>
        /// 日志时间
        /// </summary>
        public DateTime LogTime { get; set; }

        /// <summary>
        /// 账号数量
        /// </summary>
        public int AccountCounts { get; set; }

        /// <summary>
        /// 日志内容
        /// </summary>
        public string LogInfo { get; set; } = string.Empty;
    }
}
