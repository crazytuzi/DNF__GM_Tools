using System;
using System.Collections.Generic;
using System.Text;

namespace AY.DNF.GMTool.Db.Models
{
    public class ActivityEventModel
    {
        public int LogId { get; set; }
        public int EventId { get; set; }
        public long EventType { get; set; }
        public int Parameter1 { get; set; }
        public int Parameter2 { get; set; }
        public string EventExplain { get; set; }
    }
}
