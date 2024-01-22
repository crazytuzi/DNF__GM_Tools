using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("blood_dungeon_rank_select", TableDescription = "")]
	public class BloodDungeonRankSelect
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "min_amount" , ColumnDataType = "bigint", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public long MinAmount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "max_amount" , ColumnDataType = "bigint", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public long MaxAmount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "rank" , ColumnDataType = "tinyint", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public long Rank { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "reward_item_id" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int RewardItemId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "reward_gold" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int RewardGold { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "winner_count" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int WinnerCount { get; set; }

	}
}
