using AY.DNF.GMTool.Db.DbModels.local;
using AY.DNF.GMTool.Db.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AY.DNF.GMTool.Db.Services
{
    public class LocalItemsService
    {
        public async Task<List<LocalDbItemModel>> SearchItems(string keyWord)
        {
            return await DbFrameworkScope.LocalDb.Queryable<AllItems>()
                            .Where(t => t.ItemId.Contains(keyWord) || t.ItemName.Contains(keyWord))
                            .Select(t => new LocalDbItemModel
                            {
                                ItemId = t.ItemId,
                                ItemName = t.ItemName,
                                Sort = t.Sort,
                            }).ToListAsync();

        }
    }
}
