using AY.DNF.GMTool.Db;
using AY.DNF.GMTool.Db.DbModels.GMTool;
using AY.DNF.GMTool.Db.DbModels.taiwan_cain_2nd;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AY.DNF.GMTool.Test
{
    internal class InventoryTest
    {
        public static void InventoryInfo()
        {
            var inventory = DbFrameworkScope.TaiwanCain2nd.Queryable<Inventory>().Where(t => t.CharacNo == 12).First();

            // 背包blob 流
            // inventory.Inventory_
            var blob = inventory.Inventory_.ToList();
            blob = blob.GetRange(4, blob.Count - 4);
            blob = SharpZipLibDecompress(blob.ToArray()).ToList();
            var num = blob.Count / 61;
            for (var i = 0; i < num; i++)
            {
                // 按
                var arr = blob.GetRange(i * 61, 61);

                var item = new DnfItemSlot(arr.ToArray());
                if (item.ItemType == 0x00) continue;
                Console.WriteLine($"{i} --> {item.typeZh} --> {item.ItemName}");
            }
        }

        #region 背包流解析

        /// <summary>
        /// 压缩
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] MicrosoftCompress(byte[] data)
        {
            MemoryStream uncompressed = new MemoryStream(data); // 这里举例用的是内存中的数据；需要对文本进行压缩的话，使用 FileStream 即可
            MemoryStream compressed = new MemoryStream();
            DeflateStream deflateStream = new DeflateStream(compressed, CompressionMode.Compress); // 注意：这里第一个参数填写的是压缩后的数据应该被输出到的地方
            uncompressed.CopyTo(deflateStream); // 用 CopyTo 将需要压缩的数据一次性输入；也可以使用Write进行部分输入
            deflateStream.Close();  // 在Close中，会先后执行 Finish 和 Flush 操作。
            byte[] result = compressed.ToArray();
            return result;
        }

        /// <summary>
        /// 解压
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] MicrosoftDecompress(byte[] data)
        {
            MemoryStream compressed = new MemoryStream(data);
            MemoryStream decompressed = new MemoryStream();
            DeflateStream deflateStream = new DeflateStream(compressed, CompressionMode.Decompress); // 注意： 这里第一个参数同样是填写压缩的数据，但是这次是作为输入的数据
            deflateStream.CopyTo(decompressed);
            byte[] result = decompressed.ToArray();
            return result;
        }

        public static byte[] SharpZipLibDecompress(byte[] data)
        {
            MemoryStream compressed = new MemoryStream(data);
            MemoryStream decompressed = new MemoryStream();
            InflaterInputStream inputStream = new InflaterInputStream(compressed);
            inputStream.CopyTo(decompressed);
            return decompressed.ToArray();
        }
        public static byte[] SharpZipLibCompress(byte[] data)
        {
            MemoryStream compressed = new MemoryStream();
            DeflaterOutputStream outputStream = new DeflaterOutputStream(compressed);
            outputStream.Write(data, 0, data.Length);
            outputStream.Close();
            return compressed.ToArray();
        }

        #endregion
    }

    internal class DnfItemSlot
    {
        Dictionary<byte, string> typeDict = new()
        {
            {0x00,"已删除/空槽位"},
            {0x01,"装备"},
            {0x02,"消耗品"},
            {0x03,"材料"},
            {0x04,"任务材料"},
            {0x05,"宠物"},
            {0x06,"宠物装备"},
            {0x07,"宠物消耗品"},
            {0x0a,"副职业" }
        };
        Dictionary<string, byte> typeDictRev = new()
        {
            {"已删除/空槽位",0x00},
            {"装备",0x01},
            {"消耗品",0x02},
            {"材料",0x03},
            {"任务材料",0x04},
            {"宠物",0x05},
            {"宠物装备",0x06},
            {"宠物消耗品",0x07},
            {"副职业",0x0a }
        };

        byte[] oriBytes;
        byte isSeal;
        public uint ItemId { get; set; }
        public byte ItemType { get; set; }
        public string typeZh { get; set; }

        public uint ItemCount { get; set; }

        public string ItemName { get; set; }

        public DnfItemSlot(byte[] item_bytes)
        {
            var itemBytes = item_bytes.ToList();
            oriBytes = item_bytes;
            isSeal = item_bytes[0];
            ItemType = item_bytes[1];
            ItemId = BitConverter.ToUInt32(itemBytes.GetRange(2, 4).ToArray(), 0);

            var enhancementLevel = item_bytes[6];
            typeZh = typeDict[ItemType];

            if (typeZh == "装备")
            {
                var tmp = itemBytes.GetRange(7, 4).ToArray();
                tmp.Reverse();
                ItemCount = BitConverter.ToUInt32(tmp);

                ItemName = DbFrameworkScope.GMToolDb.Queryable<Equipments>().Where(t => t.ItemId == ItemId.ToString()).First()?.ItemName;
            }
            else
            {
                ItemCount = BitConverter.ToUInt32(itemBytes.GetRange(7, 4).ToArray());
                ItemName = DbFrameworkScope.GMToolDb.Queryable<Stackables>().Where(t => t.ItemId == ItemId.ToString()).First()?.ItemName;
            }

            var durablity = BitConverter.ToUInt16(itemBytes.GetRange(11, 2).ToArray());
            var orb_bytes = itemBytes.GetRange(13, 4);
            var orb = BitConverter.ToUInt32(orb_bytes.ToArray());
            var increaseType = itemBytes[17];
            var increaseValue = BitConverter.ToUInt16(itemBytes.GetRange(18, 2).ToArray());
            var _others20_30 = itemBytes.GetRange(20, 11);
            var otherWorld = itemBytes.GetRange(31, 2);
            var _others32_36 = itemBytes.GetRange(33, 4);
            var magicSeal = itemBytes.GetRange(37, 51 - 31);
            var forgeLevel = itemBytes[51];
            var _other = itemBytes.GetRange(52, itemBytes.Count - 52);

        }
    }
}
