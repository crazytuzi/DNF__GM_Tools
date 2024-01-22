using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_billing
{
	/// <summary>
	/// purchase history
	/// </summary>
	[SugarTable("log_purchase_history", TableDescription = "purchase history")]
	public class LogPurchaseHistory
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "tran_id" , ColumnDataType = "bigint", IsPrimaryKey = true, ColumnDescription = "")]
		public long TranId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "tran_state" , ColumnDataType = "tinyint", ColumnDescription = "")]
		public long TranState { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "account_id" , ColumnDataType = "char", Length = 30, ColumnDescription = "")]
		public string AccountId { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_id" , ColumnDataType = "char", Length = 30, ColumnDescription = "")]
		public string CharacId { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "item_id" , ColumnDataType = "int", ColumnDescription = "")]
		public int ItemId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "cera" , ColumnDataType = "int", ColumnDescription = "")]
		public int Cera { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "befor_cera" , ColumnDataType = "int", ColumnDescription = "")]
		public int BeforCera { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "after_cera" , ColumnDataType = "int", ColumnDescription = "")]
		public int AfterCera { get; set; }

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
