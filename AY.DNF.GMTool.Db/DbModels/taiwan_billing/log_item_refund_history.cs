using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_billing
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("log_item_refund_history", TableDescription = "")]
	public class LogItemRefundHistory
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "pf_rel_id" , ColumnDataType = "int", IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "")]
		public int PfRelId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "purchase_tran_id" , ColumnDataType = "bigint", ColumnDescription = "")]
		public long PurchaseTranId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "recharge_tran_id" , ColumnDataType = "bigint", ColumnDescription = "")]
		public long RechargeTranId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "account_id" , ColumnDataType = "char", Length = 30, ColumnDescription = "")]
		public string AccountId { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "occ_date" , ColumnDataType = "datetime", ColumnDescription = "")]
		public DateTime OccDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "reason" , ColumnDataType = "varchar", Length = 255, ColumnDescription = "")]
		public string Reason { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "admin_id" , ColumnDataType = "varchar", Length = 30, ColumnDescription = "")]
		public string AdminId { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "query_user" , ColumnDataType = "varchar", Length = 45, DefaultValue = "None", ColumnDescription = "")]
		public string QueryUser { get; set; } = string.Empty;

	}
}
