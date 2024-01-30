using SqlSugar;

namespace AY.DNF.GMTool.Db.DbModels.GMTool
{
    [SugarTable("LocalAllItems", TableDescription = "所有物品表")]
    public class LocalAllItems
    {
        [SugarColumn(IsPrimaryKey = true)]
        public string Id { get; set; }
        [SugarColumn(IsNullable =true)]
        public string ItemName { get; set; }

        [SugarColumn(IsNullable = true)]
        public string ItemId { get; set; }
                
        public int Sort { get; set; }
    }
}
