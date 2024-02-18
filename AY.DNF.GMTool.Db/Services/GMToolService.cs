using AY.DNF.GMTool.Db.DbModels.GMTool;
using AY.DNF.GMTool.Db.Models;
using SqlSugar;
using System.Collections.Generic;
using System.Linq;
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
        /// 写入职业数据
        /// </summary>
        /// <param name="items"></param>
        public async void WriteJobData(List<JobTree> items)
        {
            await DbFrameworkScope.GMToolDb.Ado.ExecuteCommandAsync("delete from jobtree");
            await DbFrameworkScope.GMToolDb.Fastest<JobTree>().PageSize(5000).BulkCopyAsync(items);
        }

        /// <summary>
        /// 写入任务数据
        /// </summary>
        /// <param name="items"></param>
        public async void WriteQuestData(List<Quests> items)
        {
            await DbFrameworkScope.GMToolDb.Ado.ExecuteCommandAsync("delete from quests");
            await DbFrameworkScope.GMToolDb.Fastest<Quests>().PageSize(5000).BulkCopyAsync(items);
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
                              ItemName = t.ItemName,
                              NpkPath = t.NpkPath,
                              FrameNo = t.FrameNo,
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
                              ItemName = t.ItemName,
                              NpkPath = t.NpkPath,
                              FrameNo = t.FrameNo,
                          }).ToListAsync();
        }

        /// <summary>
        /// 获取职业信息
        /// </summary>
        /// <returns></returns>
        public async Task<List<JobTree>> GetJobs(int? baseJobIndex = null)
        {
            var data = await DbFrameworkScope.GMToolDb.Queryable<JobTree>().ToTreeAsync(t => t.GrowJobs, t => t.ParentId, "root");

            if (baseJobIndex != null)
                return data.Where(t => t.JobId == baseJobIndex).ToList();

            return data;
        }

        /// <summary>
        /// 根据任务索引获取任务信息
        /// </summary>
        /// <param name="questIndex"></param>
        /// <returns></returns>
        public async Task<List<Quests>> GetQuests(int[] questIndex)
        {
            if (questIndex.Length <= 0) return new List<Quests>();

            var tmp = questIndex.ToList();
            return await DbFrameworkScope.GMToolDb.Queryable<Quests>().Where(t => tmp.Contains(t.QuestIndex)).ToListAsync();
        }
    }
}
