using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("charac_trade_limit_info", TableDescription = "")]
	public class CharacTradeLimitInfo
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int MId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "last_trade_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime LastTradeTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "total_trade_gold" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int TotalTradeGold { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "trade_count" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short TradeCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "nexon_user" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long NexonUser { get; set; }

	}
}
