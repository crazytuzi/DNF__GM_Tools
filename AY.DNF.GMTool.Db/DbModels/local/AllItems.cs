using SqlSugar;
using System;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Text;

namespace AY.DNF.GMTool.Db.DbModels.local
{
    [SugarTable("AllItems")]
    public class AllItems
    {
        public string ItemName { get; set; }
        public string ItemId { get; set; }
        public int Sort { get; set; }
    }
}
