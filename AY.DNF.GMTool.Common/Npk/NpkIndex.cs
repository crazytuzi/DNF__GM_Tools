using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AY.DNF.GMTool.Common.Npk
{
    public class NpkIndex
    {
        /// <summary>
        /// 4
        /// </summary>
        public byte[] OffsetBytes { get; set; }
        public uint Offset { get; set; }
        /// <summary>
        /// 4
        /// </summary>
        public byte[] SizeBytes { get; set; }
        public uint Size { get; set; }
        /// <summary>
        /// 256
        /// </summary>
        public byte[] NameBytes { get; set; }
        public string Name { get; set; }

        public byte[] ImageDataBytes { get; private set; }

        public List<ImageIndex> Images { get; } = new();
        public ImgData ImageData { get; }

        public NpkIndex()
        {

        }

        public void ParserImg(byte[] imageDataBytes)
        {
            ImageDataBytes = imageDataBytes;

            var startIndex = 0;
            var flagBytes = new byte[16];
            Array.Copy(imageDataBytes, 0, flagBytes, 0, flagBytes.Length);
            startIndex += flagBytes.Length;
            var flag = Encoding.ASCII.GetString(flagBytes);

            var dataLengthBytes = new byte[4];
            Array.Copy(imageDataBytes, startIndex, dataLengthBytes, 0, dataLengthBytes.Length);
            startIndex += dataLengthBytes.Length;
            var dataLength = BitConverter.ToUInt32(dataLengthBytes);

            // 保留位
            var safeBytes = new byte[4];
            Array.Copy(imageDataBytes, startIndex, safeBytes, 0, safeBytes.Length);
            startIndex += safeBytes.Length;

            // img 版本
            var imgVerBytes = new byte[4];
            Array.Copy(imageDataBytes, startIndex, imgVerBytes, 0, imgVerBytes.Length);
            startIndex += imgVerBytes.Length;
            var imgVer = BitConverter.ToUInt32(imgVerBytes);

            // 图像数量内容
            var imgCountBytes = new byte[4];
            Array.Copy(imageDataBytes, startIndex, imgCountBytes, 0, imgCountBytes.Length);
            startIndex += imgCountBytes.Length;
            var imgCount = BitConverter.ToUInt32(imgCountBytes);

            // 取图像索引
            for (var i = 0; i < imgCount; i++)
            {
                try
                {
                    var colorBytes = new byte[4];
                    Array.Copy(imageDataBytes, startIndex, colorBytes, 0, colorBytes.Length);
                    startIndex += colorBytes.Length;

                    // 索引指向型
                    if (colorBytes[0] == 17)
                    {
                        var vector = new byte[4];
                        Array.Copy(imageDataBytes, startIndex, vector, 0, vector.Length);
                        startIndex += vector.Length;

                        Images.Add(new ImageIndex
                        {
                            VectorIndex = BitConverter.ToUInt32(vector)
                        });

                        continue;
                    }

                    var zibBytes = new byte[4];
                    Array.Copy(imageDataBytes, startIndex, zibBytes, 0, zibBytes.Length);
                    startIndex += zibBytes.Length;

                    var widthBytes = new byte[4];
                    Array.Copy(imageDataBytes, startIndex, widthBytes, 0, widthBytes.Length);
                    startIndex += widthBytes.Length;
                    var width = BitConverter.ToUInt32(widthBytes);
                    if (Name.Contains("consumption.img") && width != 28)
                    {
                        var b = false;
                    }
                    var heightBytes = new byte[4];
                    Array.Copy(imageDataBytes, startIndex, heightBytes, 0, heightBytes.Length);
                    startIndex += heightBytes.Length;
                    var height = BitConverter.ToUInt32(heightBytes);

                    // 图像数据长度
                    var lengthBytes = new byte[4];
                    Array.Copy(imageDataBytes, startIndex, lengthBytes, 0, lengthBytes.Length);
                    startIndex += lengthBytes.Length;
                    var length = BitConverter.ToUInt32(lengthBytes);

                    var xBytes = new byte[4];
                    Array.Copy(imageDataBytes, startIndex, xBytes, 0, xBytes.Length);
                    startIndex += xBytes.Length;
                    var x = BitConverter.ToUInt32(xBytes);

                    var yBytes = new byte[4];
                    Array.Copy(imageDataBytes, startIndex, yBytes, 0, yBytes.Length);
                    startIndex += yBytes.Length;
                    var y = BitConverter.ToUInt32(yBytes);

                    var frameWidthBytes = new byte[4];
                    Array.Copy(imageDataBytes, startIndex, frameWidthBytes, 0, frameWidthBytes.Length);
                    startIndex += frameWidthBytes.Length;
                    var frameWidth = BitConverter.ToUInt32(frameWidthBytes);

                    var frameHeightBytes = new byte[4];
                    Array.Copy(imageDataBytes, startIndex, frameHeightBytes, 0, frameHeightBytes.Length);
                    startIndex += frameHeightBytes.Length;
                    var frameHeight = BitConverter.ToUInt32(frameHeightBytes);

                    var imgIndex = new ImageIndex
                    {
                        ColorBytes = colorBytes,
                        ZibBytes = zibBytes,
                        IsZib = zibBytes[0] == 0x06,
                        WidthBytes = widthBytes,
                        Width = width,
                        Height = height,
                        LengthBytes = lengthBytes,
                        Length = length,
                        XBytes = xBytes,
                        ImgTypeBytes = new byte[4] { 0x11, 0x00, 0x00, 0x00 },
                        X = x,
                        YBytes = yBytes,
                        Y = y,
                        FrameWidthBytes = frameWidthBytes,
                        FrameWidth = frameWidth,
                        FrameHeightBytes = frameHeightBytes,
                        FrameHeight = frameHeight
                    };

                    Images.Add(imgIndex);
                }
                catch { }
            }

            for (var i = 0; i < Images.Count; i++)
            {
                if (Images[i].VectorIndex != null) continue;
                var len = Images[i].Length;
                if (len > imageDataBytes.Length) continue;
                if (imageDataBytes.Length - startIndex < len) continue;
                var data = new byte[len];
                Array.Copy(imageDataBytes, startIndex, data, 0, len);
                startIndex += (int)len;

                Images[i].ImageBytes = data;
            }
        }
    }
}
