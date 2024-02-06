using AY.DNF.GMTool.Db.DbModels.GMTool;
using AY.DNF.GMTool.Db.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AY.DNF.GMTool.Db.Services
{
    /// <summary>
    /// GM工具 PVF数据相关服务
    /// </summary>
    public class GMToolService
    {
        /// <summary>
        /// 装备数据定入
        /// </summary>
        /// <param name="items"></param>
        public async void WriteEquipData(List<Equipments> items)
        {
            await DbFrameworkScope.GMToolDb.Ado.ExecuteCommandAsync("delete from equipments");
            await DbFrameworkScope.GMToolDb.Fastest<Equipments>().PageSize(5000).BulkCopyAsync(items);
        }

        /// <summary>
        /// 地下城数据写入
        /// </summary>
        /// <param name="items"></param>
        public async void WriteDungeonData(List<Dungeons> items)
        {
            await DbFrameworkScope.GMToolDb.Ado.ExecuteCommandAsync("delete from dungeons");
            await DbFrameworkScope.GMToolDb.Fastest<Dungeons>().PageSize(5000).BulkCopyAsync(items);
        }

        /// <summary>
        /// 道具数据写入
        /// </summary>
        /// <param name="items"></param>
        public async void WriteStackableData(List<Stackables> items)
        {
            await DbFrameworkScope.GMToolDb.Ado.ExecuteCommandAsync("delete from stackables");
            await DbFrameworkScope.GMToolDb.Fastest<Stackables>().PageSize(5000).BulkCopyAsync(items);
        }

        /// <summary>
        /// 检查是否有道具信息
        /// </summary>
        /// <returns></returns>
        public async Task<bool> StackablesHasData()
        {
            return await DbFrameworkScope.GMToolDb.Queryable<Stackables>().CountAsync() > 0;
        }

        /// <summary>
        /// 查询道具
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 查询是否有装备信息
        /// </summary>
        /// <returns></returns>
        public async Task<bool> EquipmentsHasData()
        {
            return await DbFrameworkScope.GMToolDb.Queryable<Equipments>().CountAsync() > 0;
        }

        /// <summary>
        /// 查询装备
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
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
