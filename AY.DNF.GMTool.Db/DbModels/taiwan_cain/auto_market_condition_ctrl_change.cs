using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("auto_market_condition_ctrl_change", TableDescription = "")]
	public class AutoMarketConditionCtrlChange
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "occ_time" , ColumnDataType = "date", IsPrimaryKey = true, DefaultValue = "0000-00-00", ColumnDescription = "")]
		public DateTime OccTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "total_gold_old" , ColumnDataType = "bigint", DefaultValue = "0", ColumnDescription = "")]
		public long TotalGoldOld { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "over_gold_old" , ColumnDataType = "bigint", DefaultValue = "0", ColumnDescription = "")]
		public long OverGoldOld { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "total_gold_new" , ColumnDataType = "bigint", DefaultValue = "0", ColumnDescription = "")]
		public long TotalGoldNew { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "over_gold_new" , ColumnDataType = "bigint", DefaultValue = "0", ColumnDescription = "")]
		public long OverGoldNew { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "MNG_user_id" , ColumnDataType = "varchar", Length = 30, ColumnDescription = "")]
		public string MNGUserId { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "memo" , ColumnDataType = "varchar", Length = 255, ColumnDescription = "")]
		public string Memo { get; set; } = string.Empty;

	}
}
