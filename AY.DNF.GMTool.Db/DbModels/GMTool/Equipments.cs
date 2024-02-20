using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace AY.DNF.GMTool.Db.DbModels.GMTool
{
    [SugarTable("Equipments", TableDescription = "pvf解析的装备表")]
    public class Equipments
    {
        [SugarColumn(IsPrimaryKey = true)]
        public string Id { get; set; } = Guid.NewGuid().ToString("n");
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string NpkPath { get; set; }
        public uint FrameNo { get; set; }

        /// <summary>
        /// 装备描述
        /// </summary>
        public string Description { get; set; }
    }
}
