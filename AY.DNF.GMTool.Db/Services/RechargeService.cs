using AY.DNF.GMTool.Db.DbModels.taiwan_billing;
using AY.DNF.GMTool.Db.DbModels.taiwan_cain;
using AY.DNF.GMTool.Db.DbModels.taiwan_cain_2nd;
using System.Threading.Tasks;

namespace AY.DNF.GMTool.Db.Services
{
    /// <summary>
    /// 充值服务
    /// </summary>
    public class RechargeService
    {
        #region D币/点

        /// <summary>
        /// 充值D币/点
        /// </summary>
        /// <param name="characNo"></param>
        /// <param name="count"></param>
        /// <param name="dType">0-D币 1-D点</param>
        /// <returns></returns>
        public async Task<bool> RechargeD(int characNo, int count, byte dType)
        {
            var account = await DbFrameworkScope.TaiwanCain.Queryable<CharacInfo>().Where(t => t.CharacNo == characNo).FirstAsync();

            if (dType == 0)
                return await DbFrameworkScope.TaiwanBilling.Updateable<CashCera>().SetColumns(t => t.Cera == t.Cera + count).Where(t => t.Account == account.MId.ToString()).ExecuteCommandAsync() > 0;
            else if (dType == 1)
                return await DbFrameworkScope.TaiwanBilling.Updateable<CashCeraPoint>().SetColumns(t => t.CeraPoint == t.CeraPoint + count).Where(t => t.Account == account.MId.ToString()).ExecuteCommandAsync() > 0;
            else return false;
        }

        #endregion

        #region 技能点

        /// <summary>
        /// 充值QP点
        /// </summary>
        /// <param name="characNo"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public async Task<bool> RechargeQP(int characNo, int count)
        {
            return await DbFrameworkScope.TaiwanCain.Updateable<CharacQuestShop>().SetColumns(t => t.Qp == t.Qp + count).Where(t => t.CharacNo == characNo).ExecuteCommandAsync() > 0;
        }

        /// <summary>
        /// 充值SP点
        /// </summary>
        /// <param name="characNo"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public async Task<bool> RechargeSP(int characNo, int count)
        {
            return await DbFrameworkScope.TaiwanCain2nd.Updateable<Skill>().SetColumns(t => t.RemainSp == t.RemainSp + count).Where(t => t.CharacNo == characNo).ExecuteCommandAsync() >= 0;
        }

        /// <summary>
        /// 充值TP点
        /// </summary>
        /// <param name="characNo"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public async Task<bool> RechargeTP(int characNo, int count)
        {
            return await DbFrameworkScope.TaiwanCain2nd.Updateable<Skill>()
                .SetColumns(t => t.RemainSfp1st == t.RemainSfp1st + count)
                .SetColumns(t => t.RemainSfp2nd == t.RemainSfp2nd + count)
                .Where(t => t.CharacNo == characNo).ExecuteCommandAsync() >= 0;
        }

        #endregion

        #region PVP

        /// <summary>
        /// 修改段位
        /// </summary>
        /// <param name="characNo"></param>
        /// <param name="pvpGradeTypeValue"></param>
        /// <returns></returns>
        public async Task<bool> RechargePVPGrade(int characNo, int pvpGradeTypeValue)
        {
            return await DbFrameworkScope.DTaiwan.Updateable<PvpResult>().SetColumns(t => t.PvpGrade == pvpGradeTypeValue).Where(t => t.CharacNo == characNo).ExecuteCommandAsync() > 0;
        }

        /// <summary>
        /// 修改胜点
        /// </summary>
        /// <param name="characNo"></param>
        /// <param name="winPoint"></param>
        /// <returns></returns>
        public async Task<bool> RechargePVPWinPoint(int characNo, int winPoint)
        {
            return await DbFrameworkScope.DTaiwan.Updateable<PvpResult>().SetColumns(t => t.WinPoint == winPoint).Where(t => t.CharacNo == characNo).ExecuteCommandAsync() > 0;
        }

        /// <summary>
        /// 修改胜场
        /// </summary>
        /// <param name="characNo"></param>
        /// <param name="win"></param>
        /// <returns></returns>
        public async Task<bool> RechargePVPWin(int characNo, int win)
        {
            return await DbFrameworkScope.DTaiwan.Updateable<PvpResult>().SetColumns(t => t.Win == win).Where(t => t.CharacNo == characNo).ExecuteCommandAsync() > 0;
        }

        #endregion

        /// <summary>
        /// 充值游戏币
        /// </summary>
        /// <param name="characNo"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public async Task<bool> RechargeMoney(int characNo, int count)
        {
            return await DbFrameworkScope.TaiwanCain2nd.Updateable<Inventory>().SetColumns(t => t.Money == t.Money + count).Where(t => t.CharacNo == characNo).ExecuteCommandAsync() >= 0;
        }
    }
}
