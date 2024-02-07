using AY.DNF.GMTool.Db;
using AY.DNF.GMTool.Db.DbModels.taiwan_cain_2nd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AY.DNF.GMTool.Test
{
    internal class InventoryTest
    {
        public static void InventoryInfo()
        {
            var inventory = DbFrameworkScope.TaiwanCain2nd.Queryable<Inventory>().Where(t => t.CharacNo == 8).First();

            var a = Encoding.UTF8.GetString(inventory.Inventory_);            
        }
    }
}
