using SqlSugar;

namespace AY.DNF.GMTool.Db.DbModels.GMTool
{
    [SugarTable("EquipDictionary", TableDescription = "Sript.pvf解析装备名称表")]
    public class EquipDictionary
    {
        [SugarColumn(IsPrimaryKey = true)]
        public string Id { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
    }
}
