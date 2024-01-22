using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("member_captcha_info", TableDescription = "")]
	public class MemberCaptchaInfo
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int MId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "cert_time" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int CertTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "fail_count" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long FailCount { get; set; }

	}
}
