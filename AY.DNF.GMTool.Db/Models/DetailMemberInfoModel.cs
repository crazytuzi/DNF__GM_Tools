using System;

namespace AY.DNF.GMTool.Db.Models
{
    public class DetailMemberInfoModel : SimpleMemberInfoModel
    {
        public string? Job { get; set; }
        public long ExpertJob { get; set; }
        public DateTime LastPlayTime { get; set; }
        public string? VIP { get; set; }
        public long Money { get; set; }
    }
}
