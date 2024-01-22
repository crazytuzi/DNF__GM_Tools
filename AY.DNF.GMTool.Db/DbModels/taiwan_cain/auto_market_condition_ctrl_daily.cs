using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("auto_market_condition_ctrl_daily", TableDescription = "")]
	public class AutoMarketConditionCtrlDaily
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "occ_time" , ColumnDataType = "date", IsPrimaryKey = true, DefaultValue = "0000-00-00", ColumnDescription = "")]
		public DateTime OccTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "total_gold" , ColumnDataType = "bigint", DefaultValue = "0", ColumnDescription = "")]
		public long TotalGold { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "auction_gold" , ColumnDataType = "bigint", DefaultValue = "0", ColumnDescription = "")]
		public long AuctionGold { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "over_gold" , ColumnDataType = "bigint", DefaultValue = "0", ColumnDescription = "")]
		public long OverGold { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "optimum_gold_supply" , ColumnDataType = "bigint", DefaultValue = "0", ColumnDescription = "")]
		public long OptimumGoldSupply { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gold_phase" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int GoldPhase { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "item_phase" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int ItemPhase { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "durability_phase" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int DurabilityPhase { get; set; }

	}
}
