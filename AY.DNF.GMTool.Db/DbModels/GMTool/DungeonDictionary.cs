using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace AY.DNF.GMTool.Db.DbModels.GMTool
{
    [SugarTable("DungeonDictionary",TableDescription ="Scrip.pvf地下城信息")]
    public class DungeonDictionary
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
