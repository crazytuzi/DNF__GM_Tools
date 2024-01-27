using AY.DNF.GMTool.Db.DbModels.GMTool;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AY.DNF.GMTool.Db.Services
{
    public class GMToolService
    {
        public async void WriteEquipData(List<EquipDictionary> items)
        {
            await DbFrameworkScope.GMToolDb.Ado.ExecuteCommandAsync("delete from equipdictionary");
            await DbFrameworkScope.GMToolDb.Fastest<EquipDictionary>().PageSize(5000).BulkCopyAsync(items);            
        }

        public async void WriteDungeonData(List<DungeonDictionary> items)
        {
            await DbFrameworkScope.GMToolDb.Ado.ExecuteCommandAsync("delete from dungeondictionary");
            await DbFrameworkScope.GMToolDb.Fastest<DungeonDictionary>().PageSize(5000).BulkCopyAsync(items);
        }
    }
}
