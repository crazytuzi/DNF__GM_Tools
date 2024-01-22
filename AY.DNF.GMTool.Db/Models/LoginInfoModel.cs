using System;
using System.Collections.Generic;
using System.Text;

namespace AY.DNF.GMTool.Db.Models
{
    /// <summary>
    /// 登录信息
    /// </summary>
    public class LoginInfoModel
    {
        /// <summary>
        /// UID
        /// </summary>
        public string? Uid { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string? AccountName { get; set; }

        /// <summary>
        /// D币余额
        /// </summary>
        public int DCoin { get; set; }

        /// <summary>
        /// D点余额
        /// </summary>
        public int DPoint { get; set; }

        /// <summary>
        /// 封停状态
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// VIP状态
        /// </summary>
        public string? VIP { get; set; }

        /// <summary>
        /// 欣悦等级
        /// </summary>
        public string? XinYueLevel { get; set; }

        /// <summary>
        /// 是否在线
        /// </summary>
        public string? IsOnLine { get; set; }

        /// <summary>
        /// 账号下角色
        /// </summary>
        public List<SimpleMemberInfoModel> MemberInfos { get; set; } = new List<SimpleMemberInfoModel>();
    }
}
