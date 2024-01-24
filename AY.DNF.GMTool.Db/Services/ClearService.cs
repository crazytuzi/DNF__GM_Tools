using AY.DNF.GMTool.Db.DbModels.taiwan_cain_2nd;
using System.Threading.Tasks;

namespace AY.DNF.GMTool.Db.Services
{
    public class ClearService
    {
        public async Task<bool> ClearBag(int characNo)
        {
            return await DbFrameworkScope.TaiwanCain2nd.Updateable<Inventory>().SetColumns(t => t.Inventory_ == null).Where(t => t.CharacNo == characNo).ExecuteCommandAsync() > 0;
        }
    }
}
