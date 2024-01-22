using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("member_info_mileage", TableDescription = "")]
	public class MemberInfoMileage
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "")]
		public int MId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "user_id" , ColumnDataType = "varchar", Length = 30, IsNullable = true, ColumnDescription = "")]
		public string? UserId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "user_name" , ColumnDataType = "varchar", Length = 10, ColumnDescription = "")]
		public string UserName { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "first_ssn" , ColumnDataType = "varchar", Length = 6, ColumnDescription = "")]
		public string FirstSsn { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "second_ssn" , ColumnDataType = "varchar", Length = 7, ColumnDescription = "")]
		public string SecondSsn { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "passwd" , ColumnDataType = "varchar", Length = 32, ColumnDescription = "")]
		public string Passwd { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mobile_no" , ColumnDataType = "varchar", Length = 15, ColumnDescription = "")]
		public string MobileNo { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "reg_date" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int RegDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "email" , ColumnDataType = "varchar", Length = 50, ColumnDescription = "")]
		public string Email { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "q_no" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long QNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "q_answer" , ColumnDataType = "varchar", Length = 30, ColumnDescription = "")]
		public string QAnswer { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "updt_date" , ColumnDataType = "timestamp", DefaultValue = "CURRENT_TIMESTAMP", ColumnDescription = "")]
		public DateTime UpdtDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "state" , ColumnDataType = "tinyint", DefaultValue = "1", ColumnDescription = "")]
		public long State { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "nickname" , ColumnDataType = "varchar", Length = 16, ColumnDescription = "")]
		public string Nickname { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "email_yn" , ColumnDataType = "enum", DefaultValue = "y", ColumnDescription = "")]
		public int EmailYn { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ssn_check" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long SsnCheck { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "slot" , ColumnDataType = "int", DefaultValue = "8", ColumnDescription = "")]
		public int Slot { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "last_play_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime LastPlayTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "hangame_flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long HangameFlag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "hanmon_flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long HanmonFlag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mileage" , ColumnDataType = "int", IsNullable = true, DefaultValue = "0", ColumnDescription = "")]
		public int? Mileage { get; set; }

	}
}
