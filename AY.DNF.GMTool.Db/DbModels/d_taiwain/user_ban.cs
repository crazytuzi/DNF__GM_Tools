using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("user_ban", TableDescription = "")]
	public class UserBan
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "no" , ColumnDataType = "int", IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "")]
		public int No { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "category" , ColumnDataType = "tinyint", DefaultValue = "1", ColumnDescription = "")]
		public long Category { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int MId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ban_term" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short BanTerm { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ban_reason" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long BanReason { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "detail_reason" , ColumnDataType = "text", Length = 0, ColumnDescription = "")]
		public string DetailReason { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ban_date" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int BanDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "cancel_reason" , ColumnDataType = "text", Length = 0, ColumnDescription = "")]
		public string CancelReason { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "cancel_date" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int CancelDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "admin_id" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int AdminId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "status" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Status { get; set; }

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

	}
}
