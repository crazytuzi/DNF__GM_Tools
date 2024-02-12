using AY.DNF.GMTool.Db.DbModels.taiwan_cain_2nd;
using System.Threading.Tasks;

namespace AY.DNF.GMTool.Db.Services
{
    /// <summary>
    /// 清理服务
    /// </summary>
    public class ClearService
    {
        /// <summary>
        /// 清理背包
        /// </summary>
        /// <param name="characNo"></param>
        /// <returns></returns>
        public async Task<bool> ClearBag(int characNo)
        {
            return await DbFrameworkScope.TaiwanCain2nd.Updateable<Inventory>().SetColumns(t => t.Inventory_ == null).Where(t => t.CharacNo == characNo).ExecuteCommandAsync() > 0;
        }

        /// <summary>
        /// 清理时装背包
        /// </summary>
        /// <param name="characNo"></param>
        /// <returns></returns>
        public async Task<bool> ClearUserItems(int characNo)
        {
            // 不清理穿戴的时装
            return await DbFrameworkScope.TaiwanCain2nd.Deleteable<UserItems>().Where(t => t.CharacNo == characNo && t.Slot >= 10).ExecuteCommandAsync() > 0;
        }

        /// <summary>
        /// 清理宠物
        /// </summary>
        /// <param name="characNo"></param>
        /// <returns></returns>
        public async Task<bool> ClearCreature(int characNo)
        {
            // 不清理装备中的宠物
            return await DbFrameworkScope.TaiwanCain2nd.Deleteable<CreatureItems>().Where(t => t.CharacNo == characNo && t.Slot != 238).ExecuteCommandAsync() > 0;
        }
    }
}
