using AY.DNF.GMTool.Db;
using AY.DNF.GMTool.Db.DbModels.taiwan_cain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AY.DNF.GMTool.Test
{
    internal class QuestTest
    {
        public static void QuestInfo()
        {
            var quests = DbFrameworkScope.TaiwanCain.Queryable<QuestCategory>().ToList();

            var memberQuest = DbFrameworkScope.TaiwanCain.Queryable<NewCharacQuest>().Where(t => t.CharacNo == 8).First();

            var a = Encoding.GetEncoding("big5").GetString(memberQuest.ClearQuest);
            var b = Encoding.GetEncoding("gb2312").GetString(memberQuest.ClearQuest);
            var c = Encoding.Unicode.GetString(memberQuest.ClearQuest);
            var d = Encoding.Default.GetString(memberQuest.ClearQuest);
        }
    }
}
