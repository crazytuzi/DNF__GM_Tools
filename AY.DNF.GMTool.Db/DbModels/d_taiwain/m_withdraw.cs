using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("m_withdraw", TableDescription = "")]
	public class MWithdraw
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "")]
		public int MId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "user_id" , ColumnDataType = "varchar", Length = 6, ColumnDescription = "")]
		public string UserId { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "user_name" , ColumnDataType = "varchar", Length = 5, ColumnDescription = "")]
		public string UserName { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "first_ssn" , ColumnDataType = "varchar", Length = 3, ColumnDescription = "")]
		public string FirstSsn { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "second_ssn" , ColumnDataType = "varchar", Length = 3, ColumnDescription = "")]
		public string SecondSsn { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "passwd" , ColumnDataType = "varchar", Length = 8, ColumnDescription = "")]
		public string Passwd { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mobile_no" , ColumnDataType = "varchar", Length = 7, ColumnDescription = "")]
		public string MobileNo { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "reg_date" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int RegDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "email" , ColumnDataType = "varchar", Length = 25, ColumnDescription = "")]
		public string Email { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "q_no" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long QNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "q_answer" , ColumnDataType = "varchar", Length = 15, ColumnDescription = "")]
		public string QAnswer { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "updt_date" , ColumnDataType = "timestamp", DefaultValue = "CURRENT_TIMESTAMP", ColumnDescription = "")]
		public DateTime UpdtDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "state" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long State { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "w_type" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short WType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "w_cause" , ColumnDataType = "varchar", Length = 100, ColumnDescription = "")]
		public string WCause { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "w_date" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int WDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "nickname" , ColumnDataType = "varchar", Length = 8, ColumnDescription = "")]
		public string Nickname { get; set; } = string.Empty;

	}
}
