using AY.DNF.GMTool.Common.Npk;

namespace AY.DNF.GMTool.Test
{
    internal class NpkTest
    {       
        public static void Read()
        {
            var npkFilePath = @"D:\99Game\游蝶新客户端95黑金5\ImagePacks2\sprite_item_stackable.NPK";
            var npkFile = new NpkFile(npkFilePath);
        }
    }
}
