namespace AY.DNF.GMTool.Db.Services
{
    /// <summary>
    /// 泡点服务
    /// </summary>
    public class BubbleService
    {
        /// <summary>
        /// 增加D币
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public int SendDPoint(int count)
        {
            var updateRows = DbFrameworkScope.TaiwanBilling.Ado.ExecuteCommand($"Update cash_cera set cera=cera+{count}");
            return updateRows;
        }

        /// <summary>
        /// 增加D点
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public int SendDCoin(int count)
        {
            var updateRows = DbFrameworkScope.TaiwanBilling.Ado.ExecuteCommand($"Update cash_cera_point set cera_point=cera_point+{count}");
            return updateRows;
        }
    }
}
