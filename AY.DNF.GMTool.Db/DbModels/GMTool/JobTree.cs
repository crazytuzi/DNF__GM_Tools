using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.GMTool
{
    [SugarTable("JobTree", TableDescription = "解析PVF得到的职业树")]
    public class JobTree
    {
        [SugarColumn(IsPrimaryKey = true)]
        public string Id { get; set; } = Guid.NewGuid().ToString("n");

        /// <summary>
        /// 职业编号
        /// </summary>
        public int JobId { get; set; }

        /// <summary>
        /// 职业名
        /// </summary>
        public string? JobName { get; set; }

        /// <summary>
        /// 父级Id
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public string? ParentId { get; set; }

        /// <summary>
        /// 子级
        /// </summary>
        [SugarColumn(IsIgnore = true)]
        public List<JobTree>? GrowJobs { get; set; }
    }
}
