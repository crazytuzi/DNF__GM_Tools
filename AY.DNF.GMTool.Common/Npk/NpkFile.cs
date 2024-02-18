using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AY.DNF.GMTool.Common.Npk
{
    public class NpkFile
    {
        static string checkString = "puchikon@neople dungeon and fighter DNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNFDNF ";
        static byte[] checkBytes = Encoding.ASCII.GetBytes(checkString);

        public List<NpkIndex> NpkFiles { get; set; } = new();

        public NpkFile(string filePath)
        {
            using var fs = new FileStream(filePath, FileMode.Open);
            var fileBytes = new byte[fs.Length];
            fs.Read(fileBytes, 0, fileBytes.Length);

            var startIndex = 0;
            var flagBytes = new byte[16];
            Array.Copy(fileBytes, startIndex, flagBytes, 0, flagBytes.Length);
            startIndex = flagBytes.Length;

            var countBytes = new byte[4];
            Array.Copy(fileBytes, startIndex, countBytes, 0, countBytes.Length);
            startIndex += countBytes.Length;

            var header = new NpkHeader
            {
                FlagBytes = flagBytes,
                FlagStr = Encoding.ASCII.GetString(flagBytes),
                CountBytes = countBytes,
                Count = BitConverter.ToInt32(countBytes)
            };

            var checkCodeLength = 32 * header.Count;

            // 循环读取img文件
            for (var i = 0; i < header.Count; i++)
            {
                var offsetBytes = new byte[4];
                Array.Copy(fileBytes, startIndex, offsetBytes, 0, offsetBytes.Length);
                startIndex += offsetBytes.Length;

                var sizeBytes = new byte[4];
                Array.Copy(fileBytes, startIndex, sizeBytes, 0, sizeBytes.Length);
                startIndex += sizeBytes.Length;

                var nameBytes = new byte[256];
                Array.Copy(fileBytes, startIndex, nameBytes, 0, nameBytes.Length);
                startIndex += nameBytes.Length;

                var imgDataBytes = new byte[BitConverter.ToUInt32(sizeBytes)];
                Array.Copy(fileBytes, BitConverter.ToUInt32(offsetBytes), imgDataBytes, 0, imgDataBytes.Length);

                var nkpIndex = new NpkIndex
                {
                    OffsetBytes = offsetBytes,
                    Offset = BitConverter.ToUInt32(offsetBytes),
                    SizeBytes = sizeBytes,
                    Size = BitConverter.ToUInt32(sizeBytes),
                    NameBytes = nameBytes,
                    Name = DecodeName(nameBytes).Trim()
                };
                nkpIndex.ParserImg(imgDataBytes);
                NpkFiles.Add(nkpIndex);
            }
        }

        static string DecodeName(byte[] org)
        {
            var orgNameBytes = new byte[256];
            if (org.Length < 256)
            {
                Array.Copy(org, orgNameBytes, org.Length);
                for (var i = org.Length; i < 256; i++)
                {
                    orgNameBytes[i] = 0x00;
                }
            }
            else
                orgNameBytes = org;

            var newNameBytes = new byte[256];
            for (var i = 0; i < 256; i++)
            {
                newNameBytes[i] = (byte)(orgNameBytes[i] ^ checkBytes[i]);
            }

            return Encoding.ASCII.GetString(newNameBytes.Where(t => t != 0x00).ToArray());
        }
    }
}
