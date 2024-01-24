namespace AY.DNF.GMTool.Db.Services
{
    /// <summary>
    /// 泡点服务
    /// </summary>
    public class BubbleService
    {
        public int SendDPoint(int count)
        {
            var updateRows = DbFrameworkScope.TaiwanBilling.Ado.ExecuteCommand($"Update cash_cera set cera=cera+{count}");
            return updateRows;
        }

        public int SendDCoin(int count)
        {
            var updateRows = DbFrameworkScope.TaiwanBilling.Ado.ExecuteCommand($"Update cash_cera_point set cera_point=cera_point+{count}");
            return updateRows;
        }
    }
}
