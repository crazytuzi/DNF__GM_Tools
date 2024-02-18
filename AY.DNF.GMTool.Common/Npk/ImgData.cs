using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AY.DNF.GMTool.Common.Npk
{
    public class ImgData
    {
        /// <summary>
        /// 16
        /// </summary>
        public byte[] FlagBytes { get; set; }
        public string FlagStr { get; set; }
        /// <summary>
        /// 4
        /// </summary>
        public byte[] DataLengthBytes { get; set; }
        public uint DataLength { get; set; }
        /// <summary>
        /// 4 保留位
        /// </summary>
        public byte[] SafeBytes { get; set; }

        /// <summary>
        /// 4
        /// </summary>
        public byte[] ImgVerBytes { get; set; }
        public uint ImgVer { get; set; }    

        /// <summary>
        /// 4
        /// 图像数量
        /// </summary>
        public byte[] ImgCountBytes { get; set; }
        public uint ImageCount { get; set; }

        public byte[] ImageData { get; }

        public ImgData(byte[] imageData)
        {
            ImageData = imageData;
            var startIndex = 0;

            //
            var imgTypeBytes = new byte[4];
            Array.Copy(imageData, startIndex, imgTypeBytes, 0, imgTypeBytes.Length);
            startIndex += imgTypeBytes.Length;

            // 帧号
            var frameNoBytes = new byte[4];
            Array.Copy(imageData, startIndex, frameNoBytes, 0, frameNoBytes.Length);
            startIndex += frameNoBytes.Length;
            var frameNo = BitConverter.ToUInt32(frameNoBytes);
        }
    }
}
