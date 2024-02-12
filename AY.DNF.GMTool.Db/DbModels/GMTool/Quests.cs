using SqlSugar;
using System;

namespace AY.DNF.GMTool.Db.DbModels.GMTool
{
    [SugarTable("Quests", TableDescription = "PVF解析的任务表")]
    public class Quests
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("n");

        /// <summary>
        /// 任务索引
        /// </summary>
        public int QuestIndex { get; set; }

        /// <summary>
        /// 任务名
        /// </summary>
        public string? QuestName { get; set; }

        /// <summary>
        /// 任务类型 如需要物品/击杀怪物等
        /// </summary>
        public string? QuestType { get; set; }

        /// <summary>
        /// 需要物品型任务所需物品信息
        /// </summary>
        public string? QuestItems { get; set; }

        /// <summary>
        /// 需要任务道具描述
        /// </summary>
        public string? QuestItemsDescription { get; set; }
    }
}
