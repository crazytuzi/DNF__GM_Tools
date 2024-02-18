using System;
using System.Collections.Generic;
using System.Text;

namespace AY.DNF.GMTool.Db.Models
{
    public class LocalDbItemModel
    {
        public string ItemName { get; set; }
        public string ItemId { get; set; }
        public int Sort { get; set; }

        public string NpkPath { get; set; }
        public uint FrameNo { get; set; }
    }
}
