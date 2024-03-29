﻿using AY.DNF.GMTool.Db.DbModels.GMTool;
using AY.DNF.GMTool.Db.DbModels.taiwan_cain;
using AY.DNF.GMTool.Db.DbModels.taiwan_cain_2nd;
using AY.DNF.GMTool.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AY.DNF.GMTool.Db.Services
{
    /// <summary>
    /// 游戏角色相关服务
    /// </summary>
    public class MemberService
    {
        /// <summary>
        /// 角色详情
        /// </summary>
        /// <param name="characNo"></param>
        /// <returns></returns>
        public async Task<DetailMemberInfoModel?> GetDetailMemberInfo(int characNo)
        {
            var sql = @$"
Set Charset latin1;
select charac_no CharacNo,charac_name CharacName,job,lev,grow_type GrowType,expert_job ExpertJob
from charac_info 
where delete_flag!=1 ";
            var infos = await DbFrameworkScope.TaiwanCain.SqlQueryable<CharacInfo>(sql).ToListAsync();
            var info = infos.FirstOrDefault(t => t.CharacNo == characNo);
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

        /// <summary>
        /// 全图地狱
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public async Task<bool> AllHell(int uid)
        {
            var dungeonStr = "1|1,2|3,3|3,4|3,5|3,6|3,7|3,8|3,9|3,11|3,12|3,13|3,14|3,15|3,17|3,21|3,22|3,23|3,24|3,25|3,26|3,27|3,31|3,32|3,33|3,34|3,35|3,36|3,37|3,40|3,41|2,42|3,43|3,44|3,45|3,50|3,51|3,52|3,53|3,60|3,61|3,65|2,66|1,67|2,70|3,71|3,72|3,73|3,74|3,75|3,76|3,77|3,80|3,81|3,82|3,83|3,84|3,85|3,86|3,87|3,88|3,89|3,90|3,91|2,92|3,93|3,100|3,101|3,102|3,103|3,104|3,110|3,111|3,112|3,140|3,141|3,502|3,511|3,521|3,1000|3,1500|3,1501|3,1502|3,1504|1,1506|3,3506|3,10000|3";

            // 如果有pvf解析的地下城数据，则用数据组上面的串
            var dungeon = await DbFrameworkScope.GMToolDb.Queryable<Dungeons>().ToListAsync();
            if (dungeon != null && dungeon.Count > 0)
                dungeonStr = dungeon.Aggregate(string.Empty, (x, y) => x += $"{y.Id}|3,").TrimEnd(',');

            var data = DbFrameworkScope.TaiwanCain.Queryable<MemberDungeon>().Where(t => t.MId == uid);
            if (data == null)
                return await DbFrameworkScope.TaiwanCain.Insertable<MemberDungeon>(new MemberDungeon { MId = uid, Dungeon = dungeonStr }).ExecuteCommandAsync() > 0;
            else
                return await DbFrameworkScope.TaiwanCain.Updateable<MemberDungeon>(new MemberDungeon { MId = uid, Dungeon = dungeonStr }).Where(t => t.MId == uid).ExecuteCommandAsync() > 0;
        }

        /// <summary>
        /// 修改职业
        /// </summary>
        /// <param name="characNo"></param>
        /// <param name="job"></param>
        /// <param name="growJob"></param>
        /// <returns></returns>
        public async Task<bool> ChangeJog(int characNo, int job, int growJob)
        {
            var data = await DbFrameworkScope.TaiwanCain.Queryable<CharacInfo>().Where(t => t.CharacNo == characNo).FirstAsync();
            if (data == null) return false;

            if (data.Lev < 50) growJob = 0;
            data.Job = job;
            data.GrowType = growJob;

            return await DbFrameworkScope.TaiwanCain.Updateable(data).ExecuteCommandAsync() > 0;
        }

        /// <summary>
        /// 获取角色进行中任务列表
        /// </summary>
        /// <param name="characNo"></param>
        /// <returns></returns>
        public async Task<List<QuestModel>> GetCharacQuests(int characNo)
        {
            var dt = await DbFrameworkScope.TaiwanCain.Ado.GetDataTableAsync($"select * from new_charac_quest where charac_no={characNo}");
            if (dt.Rows.Count <= 0) return new List<QuestModel>();

            var result = new List<QuestModel>();
            var row = dt.Rows[0];
            for (var i = 1; i <= 20; i++)
            {
                var quest = new QuestModel
                {
                    Slot = i,
                };

                var indexStr = row[$"play_{i}"].ToString();
                var trigger = row[$"play_{i}_trigger"].ToString();
                // 任务已标识完成，但还没确认完成的任务则不显示
                if (int.Parse(trigger) == 0) continue;
                quest.QuestIndex = int.Parse(indexStr);

                result.Add(quest);
            }

            return result;
        }

        /// <summary>
        /// 完成指定任务
        /// </summary>
        /// <param name="characNo"></param>
        /// <param name="slot"></param>
        /// <returns></returns>
        public async Task<bool> FinishQuest(int characNo, int slot)
        {
            var sql = $"update new_charac_quest set play_{slot}_trigger=0 where charac_no={characNo}";
            return await DbFrameworkScope.TaiwanCain.Ado.ExecuteCommandAsync(sql) > 0;
        }

        /// <summary>
        /// 已删除角色名释放
        /// 调用一次，在其名前加一次"del_"
        /// </summary>
        /// <returns></returns>
        public async Task<bool> DeleteCharacNameRelease()
        {
            var sql = @$"set charset latin1;update charac_info set charac_name=concat('del_',charac_name) where delete_flag=1";
            return await DbFrameworkScope.TaiwanCain.Ado.ExecuteCommandAsync(sql) > 0;
        }
    }
}
