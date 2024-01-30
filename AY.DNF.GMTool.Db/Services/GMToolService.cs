using AY.DNF.GMTool.Db.DbModels.GMTool;
using AY.DNF.GMTool.Db.DbModels.local;
using AY.DNF.GMTool.Db.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AY.DNF.GMTool.Db.Services
{
    public class GMToolService
    {
        public async void WriteEquipData(List<EquipDictionary> items)
        {
            await DbFrameworkScope.GMToolDb.Ado.ExecuteCommandAsync("delete from equipdictionary");
            await DbFrameworkScope.GMToolDb.Fastest<EquipDictionary>().PageSize(5000).BulkCopyAsync(items);
        }

        public async void WriteDungeonData(List<DungeonDictionary> items)
        {
            await DbFrameworkScope.GMToolDb.Ado.ExecuteCommandAsync("delete from dungeondictionary");
            await DbFrameworkScope.GMToolDb.Fastest<DungeonDictionary>().PageSize(5000).BulkCopyAsync(items);
        }

        public async Task<List<LocalDbItemModel>> SearchItems(string keyword)
        {
            return await DbFrameworkScope.GMToolDb.Queryable<LocalAllItems>()
                          .Where(t => t.ItemId.Contains(keyword) || t.ItemName.Contains(keyword))
                          .Select(t => new LocalDbItemModel
                          {
                              ItemId = t.ItemId,
                              ItemName = t.ItemName,
                              Sort = t.Sort,
                          }).ToListAsync();
        }
    }
}
