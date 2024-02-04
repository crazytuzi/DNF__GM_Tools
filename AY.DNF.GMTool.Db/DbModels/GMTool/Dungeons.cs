using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace AY.DNF.GMTool.Db.DbModels.GMTool
{
    [SugarTable("Dungeons", TableDescription = "pvf解析的地下城数据")]
    public class Dungeons
    {
        [SugarColumn(IsPrimaryKey = true)]
        public string Id { get; set; } = Guid.NewGuid().ToString("n");
        public string ItemId { get; set; }
        public string ItemName { get; set; }
    }
}
