// See https://aka.ms/new-console-template for more information
using AY.DNF.GMTool.Db;
using AY.DNF.GMTool.Db.DbModels.taiwan_cain;
using AY.DNF.GMTool.Test;
using System.Text;
using TiaoTiaoCode.NLogger;

Console.WriteLine("Hello, World!");

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);


TiaoTiaoNLogger.FastNoDatabaseInit();

DbFrameworkScope.Init("192.168.200.131", "game", "uu5!^%jg", 3306);

//CharacTest.CharacStat();
//CharacTest.CharacPvf();

InventoryTest.InventoryInfo();
QuestTest.QuestInfo();

Console.ReadLine();