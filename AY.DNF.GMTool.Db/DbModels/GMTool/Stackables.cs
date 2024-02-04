using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace AY.DNF.GMTool.Db.DbModels.GMTool
{
    [SugarTable("Stackables", TableDescription = "pvf解析的道具信息")]
    public class Stackables
    {
        [SugarColumn(IsPrimaryKey = true)]
        public string Id { get; set; } = Guid.NewGuid().ToString("n");
        public string ItemId { get; set; }
        public string ItemName { get; set; }
    }
}
