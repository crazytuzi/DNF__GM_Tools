using AY.DNF.GMTool.Db;
using AY.DNF.GMTool.Db.DbModels.taiwan_cain;
using pvfLoaderXinyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AY.DNF.GMTool.Test
{
    internal class CharacTest
    {
        public static void CharacStat()
        {
            var a = DbFrameworkScope.TaiwanCain.Queryable<CharacStat>().Where(t => t.CharacNo == 8).First();
            var b = DbFrameworkScope.TaiwanCain.Queryable<CharacStat>().Where(t => t.CharacNo == 1).First();
        }

        public static void CharacPvf()
        {
            var pvf = new PvfFile(@"D:\99Game\DNF GM\Script.pvf");

            var characLst = pvf.GetPvfFileByPath("character/character.lst", Encoding.UTF8);

            var characArr = characLst.Split("\r\n", StringSplitOptions.RemoveEmptyEntries).Where(t => !t.StartsWith("#")).ToList();
            var jobList = characArr.Select(t =>
            {
                var arr = t.Split("\t");
                return new JobItem { Id = int.Parse(arr[0]), Path = arr[1].Replace("`","") };
            }).ToList();

            var job = jobList.First(t => t.Id == 3);

            var jobInfo = pvf.GetPvfFileByPath($"character/{job.Path}", Encoding.UTF8);
            var jobInfoList= jobInfo.Split("\r\n", StringSplitOptions.RemoveEmptyEntries).Where(t => !t.StartsWith("#")).ToList();
        }
    }

    struct JobItem
    {
        public int Id { get; set; }
        public string Path { get; set; }
    }
}
