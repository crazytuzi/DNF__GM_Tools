using AY.DNF.GMTool.Db.DbModels.GMTool;
using AY.DNF.GMTool.Db.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AY.DNF.GMTool.Db.Services
{
    public class GMToolService
    {
        public async void WriteEquipData(List<Equipments> items)
        {
            await DbFrameworkScope.GMToolDb.Ado.ExecuteCommandAsync("delete from equipments");
            await DbFrameworkScope.GMToolDb.Fastest<Equipments>().PageSize(5000).BulkCopyAsync(items);
        }

        public async void WriteDungeonData(List<Dungeons> items)
        {
            await DbFrameworkScope.GMToolDb.Ado.ExecuteCommandAsync("delete from dungeons");
            await DbFrameworkScope.GMToolDb.Fastest<Dungeons>().PageSize(5000).BulkCopyAsync(items);
        }

        public async void WriteStackableData(List<Stackables> items)
        {
            await DbFrameworkScope.GMToolDb.Ado.ExecuteCommandAsync("delete from stackables");
            await DbFrameworkScope.GMToolDb.Fastest<Stackables>().PageSize(5000).BulkCopyAsync(items);
        }

        public async Task<bool> StackablesHasData()
        {
            return await DbFrameworkScope.GMToolDb.Queryable<Stackables>().CountAsync() > 0;
        }

        public async Task<List<LocalDbItemModel>> SearchStackables(string keyword)
        {
            return await DbFrameworkScope.GMToolDb.Queryable<Stackables>()
                          .Where(t => t.ItemId.Contains(keyword) || t.ItemName.Contains(keyword))
                          .Select(t => new LocalDbItemModel
                          {
                              ItemId = t.ItemId,
                              ItemName = t.ItemName
                          }).ToListAsync();
        }

        public async Task<bool> EquipmentsHasData()
        {
            return await DbFrameworkScope.GMToolDb.Queryable<Equipments>().CountAsync() > 0;
        }

        public async Task<List<LocalDbItemModel>> SearchEquipments(string keyword)
        {
            return await DbFrameworkScope.GMToolDb.Queryable<Equipments>()
                          .Where(t => t.ItemId.Contains(keyword) || t.ItemName.Contains(keyword))
                          .Select(t => new LocalDbItemModel
                          {
                              ItemId = t.ItemId,
                              ItemName = t.ItemName
                          }).ToListAsync();
        }
    }
}
