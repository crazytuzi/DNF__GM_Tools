using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("member_punish_hack", TableDescription = "")]
	public class MemberPunishHack
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int MId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "occ_time" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int OccTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "period" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Period { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "now_flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long NowFlag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "auto_flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long AutoFlag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "reason" , ColumnDataType = "varchar", Length = 250, ColumnDescription = "")]
		public string Reason { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "hack_ip" , ColumnDataType = "varchar", Length = 15, ColumnDescription = "")]
		public string HackIp { get; set; } = string.Empty;

	}
}
