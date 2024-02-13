namespace AY.DNF.GMTool.Db.Models
{
    public class SimpleMemberInfoModel
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int CharacNo { get; set; }

        /// <summary>
        /// 角色名
        /// </summary>
        public string? CharacName { get; set; }

        /// <summary>
        /// 等级
        /// </summary>
        public long Level { get; set; }

        /// <summary>
        /// 觉醒次数
        /// </summary>
        public int JxCount { get; set; }
    }
}
