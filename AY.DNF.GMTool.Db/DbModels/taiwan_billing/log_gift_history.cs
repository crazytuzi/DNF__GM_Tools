using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_billing
{
	/// <summary>
	/// gift history
	/// </summary>
	[SugarTable("log_gift_history", TableDescription = "gift history")]
	public class LogGiftHistory
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
		[SugarColumn(ColumnName = "send_account_id" , ColumnDataType = "varchar", Length = 30, ColumnDescription = "")]
		public string SendAccountId { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "send_charac_id" , ColumnDataType = "varchar", Length = 30, ColumnDescription = "")]
		public string SendCharacId { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "recv_account_id" , ColumnDataType = "varchar", Length = 30, ColumnDescription = "")]
		public string RecvAccountId { get; set; } = string.Empty;

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
		[SugarColumn(ColumnName = "send_befor_cera" , ColumnDataType = "int", ColumnDescription = "")]
		public int SendBeforCera { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "send_after_cera" , ColumnDataType = "int", ColumnDescription = "")]
		public int SendAfterCera { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "recv_befor_cera" , ColumnDataType = "int", ColumnDescription = "")]
		public int RecvBeforCera { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "recv_after_cera" , ColumnDataType = "int", ColumnDescription = "")]
		public int RecvAfterCera { get; set; }

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
