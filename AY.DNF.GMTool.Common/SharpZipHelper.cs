using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AY.DNF.GMTool.Common
{
    public class SharpZipHelper
    {
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
    }
}
