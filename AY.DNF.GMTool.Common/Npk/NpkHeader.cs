using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AY.DNF.GMTool.Common.Npk
{
    public struct NpkHeader
    {
        /// <summary>
        /// 16
        /// </summary>
        public byte[] FlagBytes { get; set; }
        public string FlagStr { get; set; }
        public byte[] CountBytes { get; set; }
        public int Count { get; set; }
    }
}
