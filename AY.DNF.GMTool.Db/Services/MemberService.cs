using AY.DNF.GMTool.Db.DbModels.GMTool;
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

        public async Task<bool> AllHell(int uid)
        {
            var dungeonStr = "1|1,2|3,3|3,4|3,5|3,6|3,7|3,8|3,9|3,11|3,12|3,13|3,14|3,15|3,17|3,21|3,22|3,23|3,24|3,25|3,26|3,27|3,31|3,32|3,33|3,34|3,35|3,36|3,37|3,40|3,41|2,42|3,43|3,44|3,45|3,50|3,51|3,52|3,53|3,60|3,61|3,65|2,66|1,67|2,70|3,71|3,72|3,73|3,74|3,75|3,76|3,77|3,80|3,81|3,82|3,83|3,84|3,85|3,86|3,87|3,88|3,89|3,90|3,91|2,92|3,93|3,100|3,101|3,102|3,103|3,104|3,110|3,111|3,112|3,140|3,141|3,502|3,511|3,521|3,1000|3,1500|3,1501|3,1502|3,1504|1,1506|3,3506|3,10000|3";
            var dungeon = await DbFrameworkScope.GMToolDb.Queryable<DungeonDictionary>().ToListAsync();
            if (dungeon != null && dungeon.Count > 0)
                dungeonStr = dungeon.Aggregate(string.Empty, (x, y) => x += $"{y.Id}|3,").TrimEnd(',');

            var data = DbFrameworkScope.TaiwanCain.Queryable<MemberDungeon>().Where(t => t.MId == uid);
            if (data == null)
                return await DbFrameworkScope.TaiwanCain2nd.Insertable<MemberDungeon>(new MemberDungeon { MId = uid, Dungeon = dungeonStr }).ExecuteCommandAsync() > 0;
            else
                return await DbFrameworkScope.TaiwanCain2nd.Updateable<MemberDungeon>(new MemberDungeon { MId = uid, Dungeon = dungeonStr }).Where(t => t.MId == uid).ExecuteCommandAsync() > 0;
        }
    }
}
