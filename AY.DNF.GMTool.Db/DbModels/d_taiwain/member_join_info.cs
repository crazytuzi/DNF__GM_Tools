using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("member_join_info", TableDescription = "")]
	public class MemberJoinInfo
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int MId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "reg_date" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int RegDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ip" , ColumnDataType = "varchar", Length = 15, ColumnDescription = "")]
		public string Ip { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "contry_code" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long ContryCode { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "login_time" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int LoginTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "error_type" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long ErrorType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "login_ip" , ColumnDataType = "varchar", Length = 15, ColumnDescription = "")]
		public string LoginIp { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "game_use_history" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long GameUseHistory { get; set; }

	}
}
