using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_billing
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("log_refund_history", TableDescription = "")]
	public class LogRefundHistory
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "tran_id" , ColumnDataType = "bigint", IsPrimaryKey = true, ColumnDescription = "")]
		public long TranId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "account_id" , ColumnDataType = "varchar", IsPrimaryKey = true, Length = 30, ColumnDescription = "")]
		public string AccountId { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "order_tran_id" , ColumnDataType = "varchar", Length = 35, ColumnDescription = "")]
		public string OrderTranId { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "amount" , ColumnDataType = "int", ColumnDescription = "")]
		public int Amount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "tran_state" , ColumnDataType = "tinyint", ColumnDescription = "")]
		public long TranState { get; set; }

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
