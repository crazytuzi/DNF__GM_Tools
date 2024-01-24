using AY.DNF.GMTool.Db.DbModels.taiwan_cain;
using AY.DNF.GMTool.Db.DbModels.taiwan_cain_2nd;
using AY.DNF.GMTool.Db.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AY.DNF.GMTool.Db.Services
{
    public class MemberService
    {
        public async Task<DetailMemberInfoModel?> GetDetailMemberInfo(int characNo)
        {
            var sql = @$"
Set Charset latin1;
select charac_no CharacNo,charac_name CharacName,lev ,grow_type GrowType,expert_job ExpertJob
from charac_info 
where delete_flag!=1 ";
            // and charac_no={characNo}";
            var infos = await DbFrameworkScope.TaiwanCain.SqlQueryable<CharacInfo>(sql).ToListAsync();
            var info = infos.FirstOrDefault(t => t.CharacNo == characNo);
            //var info = await DbFrameworkScope.TaiwanCain.SqlQueryable<CharacInfo>(sql).FirstAsync();
            if (info == null) return null;
            var exInfo = await DbFrameworkScope.TaiwanCain.Queryable<CharacStat>().Where(t => t.CharacNo == characNo).FirstAsync();

            var money = await DbFrameworkScope.TaiwanCain2nd.Queryable<Inventory>().Where(t => t.CharacNo == characNo).FirstAsync();

            var di = new DetailMemberInfoModel
            {
                CharacNo = characNo,
                CharacName = info.CharacName,
                Level = info.Lev,
                LastPlayTime = exInfo.LastPlayTime.ToString().Equals("0000-00-00 00:00:00") ? DateTime.MinValue : DateTime.Parse(exInfo.LastPlayTime.ToString()),
                Job = $"{info.Job}_{info.GrowType}",
                ExpertJob = info.ExpertJob,
                VIP = string.IsNullOrWhiteSpace(info.VIP) ? "VIP" : "非VIP",
                Money = money.Money
            };

            return di;
        }

        /// <summary>
        /// 开左槽
        /// </summary>
        /// <param name="characNo"></param>
        /// <returns></returns>
        public async Task<bool> OpenLeft(int characNo)
        {
            return await DbFrameworkScope.TaiwanCain.Updateable<CharacStat>()
                                .SetColumns(t => t.AddSlotFlag == 1)
                                .Where(t => t.CharacNo == characNo)
                                .ExecuteCommandAsync() > 0;
        }

        /// <summary>
        /// 开右槽
        /// </summary>
        /// <param name="characNo"></param>
        /// <returns></returns>
        public async Task<bool> OpenRight(int characNo)
        {
            return await DbFrameworkScope.TaiwanCain.Updateable<CharacStat>()
                                .SetColumns(t => t.AddSlotFlag == 2)
                                .Where(t => t.CharacNo == characNo)
                                .ExecuteCommandAsync() > 0;
        }

        /// <summary>
        /// 开左右槽
        /// </summary>
        /// <param name="characNo"></param>
        /// <returns></returns>
        public async Task<bool> OpenLeftAndRight(int characNo)
        {
            return await DbFrameworkScope.TaiwanCain.Updateable<CharacStat>()
                                .SetColumns(t => t.AddSlotFlag == 3)
                                .Where(t => t.CharacNo == characNo)
                                .ExecuteCommandAsync() > 0;
        }

        /// <summary>
        /// 无限负重
        /// </summary>
        /// <param name="characNo"></param>
        /// <returns></returns>
        public async Task<bool> UnlimitedWeight(int characNo)
        {
            return await DbFrameworkScope.TaiwanCain.Updateable<CharacInfo>()
                                .SetColumns(t => t.InvenWeight == 99999999)
                                .Where(t => t.CharacNo == characNo)
                                .ExecuteCommandAsync() > 0;
        }

        /// <summary>
        /// 副职满级
        /// </summary>
        /// <param name="characNo"></param>
        /// <returns></returns>
        public async Task<bool> ExpertJobFull(int characNo)
        {
            return await DbFrameworkScope.TaiwanCain.Updateable<CharacStat>()
                              .SetColumns(t => t.ExpertJobExp == 99999999)
                              .Where(t => t.CharacNo == characNo)
                              .ExecuteCommandAsync() > 0;
        }

        /// <summary>
        /// 解除装备等级上限
        /// </summary>
        /// <param name="characNo"></param>
        /// <returns></returns>
        public async Task<bool> MaxEquipLevel(int characNo)
        {
            return await DbFrameworkScope.TaiwanCain.Updateable<CharacManageInfo>()
                             .SetColumns(t => t.MaxEquipLevel == 255)
                             .Where(t => t.CharacNo == characNo)
                             .ExecuteCommandAsync() > 0;
        }
    }
}
