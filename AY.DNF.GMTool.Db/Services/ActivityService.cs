using AY.DNF.GMTool.Db.DbModels.d_taiwan;
using AY.DNF.GMTool.Db.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AY.DNF.GMTool.Db.Services
{
    public class ActivityService
    {
        /// <summary>
        /// 查询当前进行中活动
        /// </summary>
        /// <returns></returns>
        public async Task<List<ActivityEventModel>> QueryAcitivities()
        {
            return await DbFrameworkScope.DTaiwan.Queryable<DnfEventLog>().InnerJoin<DnfEventInfo>((x, y) => x.EventType == y.EventId)
                            .Select((x, y) => new ActivityEventModel
                            {
                                EventId = y.EventId,
                                EventExplain = y.EventExplain,
                                EventType = x.EventType,
                                LogId = x.LogId,
                                Parameter1 = x.Parameter1,
                                Parameter2 = x.Parameter2
                            }).ToListAsync();
        }

        /// <summary>
        /// 查询活动
        /// </summary>
        /// <returns></returns>
        public async Task<List<EventInfoModel>> QueryEventInfos()
        {
            return await DbFrameworkScope.DTaiwan.Queryable<DnfEventInfo>().Where(t => !string.IsNullOrWhiteSpace(t.EventExplain) && !t.EventExplain.StartsWith("event"))
                            .Select(t => new EventInfoModel
                            {
                                EventId = t.EventId,
                                EventExplain = t.EventExplain
                            }).ToListAsync();
        }

        /// <summary>
        /// 添加活动
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public async Task<bool> AddEvent(ActivityEventModel eventLog)
        {
            return await DbFrameworkScope.DTaiwan.Insertable<DnfEventLog>(new DnfEventLog
            {
                OccTime = 0,
                EventType = eventLog.EventType,
                Parameter1 = eventLog.Parameter1,
                Parameter2 = eventLog.Parameter2,
                ServerId = 0,
                EventFlag = 0,
                StartTime = 0,
                EndTime = 0,
                MId = 0,
                Expl = "0",
                Etc = string.Empty
            }).ExecuteCommandAsync() > 0;
        }

        /// <summary>
        /// 删除活动
        /// </summary>
        /// <param name="logId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteEvent(int logId)
        {
            return await DbFrameworkScope.DTaiwan.Deleteable<DnfEventLog>().Where(t => t.LogId == logId).ExecuteCommandAsync() == 1;
        }
    }
}
