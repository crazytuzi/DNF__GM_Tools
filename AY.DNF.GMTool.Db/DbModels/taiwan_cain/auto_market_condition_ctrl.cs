using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("auto_market_condition_ctrl", TableDescription = "")]
	public class AutoMarketConditionCtrl
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "optimum_gold_supply" , ColumnDataType = "bigint", DefaultValue = "0", ColumnDescription = "")]
		public long OptimumGoldSupply { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "over_gold" , ColumnDataType = "bigint", DefaultValue = "0", ColumnDescription = "")]
		public long OverGold { get; set; }

	}
}
