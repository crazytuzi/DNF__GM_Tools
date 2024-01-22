using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_billing
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("log_error_history", TableDescription = "")]
	public class LogErrorHistory
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "no" , ColumnDataType = "int", IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "")]
		public int No { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "error_id" , ColumnDataType = "int", ColumnDescription = "")]
		public int ErrorId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "error_msg" , ColumnDataType = "varchar", Length = 255, ColumnDescription = "")]
		public string ErrorMsg { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "error_query" , ColumnDataType = "varchar", Length = 512, ColumnDescription = "")]
		public string ErrorQuery { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "proc_name" , ColumnDataType = "varchar", Length = 45, ColumnDescription = "")]
		public string ProcName { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "proc_line" , ColumnDataType = "int", ColumnDescription = "")]
		public int ProcLine { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "query_user" , ColumnDataType = "varchar", Length = 45, DefaultValue = "None", ColumnDescription = "")]
		public string QueryUser { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "occ_date" , ColumnDataType = "datetime", ColumnDescription = "")]
		public DateTime OccDate { get; set; }

	}
}
