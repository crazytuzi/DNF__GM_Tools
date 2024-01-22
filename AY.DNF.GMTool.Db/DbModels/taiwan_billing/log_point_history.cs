using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_billing
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("log_point_history", TableDescription = "")]
	public class LogPointHistory
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "no" , ColumnDataType = "int", IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "")]
		public int No { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "account_id" , ColumnDataType = "varchar", Length = 30, ColumnDescription = "")]
		public string AccountId { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_id" , ColumnDataType = "varchar", Length = 30, ColumnDescription = "")]
		public string CharacId { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "cera_point" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int CeraPoint { get; set; }

		/// <summary>
		/// A(add), U(use)
		/// </summary>
		[SugarColumn(ColumnName = "command" , ColumnDataType = "enum", ColumnDescription = "A(add), U(use)")]
		public int Command { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charge_type" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long ChargeType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "free_charge_type" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long FreeChargeType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "item_id" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int ItemId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "query_user" , ColumnDataType = "varchar", Length = 45, DefaultValue = "None", ColumnDescription = "")]
		public string QueryUser { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "reg_date" , ColumnDataType = "datetime", ColumnDescription = "")]
		public DateTime RegDate { get; set; }

	}
}
