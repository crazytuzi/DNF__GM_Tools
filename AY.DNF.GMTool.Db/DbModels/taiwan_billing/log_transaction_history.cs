using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_billing
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("log_transaction_history", TableDescription = "")]
	public class LogTransactionHistory
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "tran_id" , ColumnDataType = "bigint", IsPrimaryKey = true, ColumnDescription = "")]
		public long TranId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "tran_type" , ColumnDataType = "tinyint", ColumnDescription = "")]
		public long TranType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "occ_date" , ColumnDataType = "datetime", ColumnDescription = "")]
		public DateTime OccDate { get; set; }

	}
}
