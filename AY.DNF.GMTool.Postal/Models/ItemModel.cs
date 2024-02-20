namespace AY.DNF.GMTool.Postal.Models
{
    /// <summary>
    /// 查询信息Model
    /// </summary>
    public class ItemModel
    {
        /// <summary>
        /// 物品ID
        /// </summary>
        public string? ItemId { get; set; }

        /// <summary>
        /// 物品名
        /// </summary>
        public string? ItemName { get; set; }

        public string? NpkPath { get; set; }
        public uint FrameNo { get; set; }
        public string? Desc { get; set; }
    }
}
