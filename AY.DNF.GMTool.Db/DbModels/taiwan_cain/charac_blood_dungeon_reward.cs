using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("charac_blood_dungeon_reward", TableDescription = "")]
	public class CharacBloodDungeonReward
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "week_occ_date" , ColumnDataType = "date", IsPrimaryKey = true, DefaultValue = "0000-00-00", ColumnDescription = "")]
		public DateTime WeekOccDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "week_point" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int WeekPoint { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "week_enter_count" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int WeekEnterCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "week_use_gold" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int WeekUseGold { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "last_play_date" , ColumnDataType = "date", DefaultValue = "0000-00-00", ColumnDescription = "")]
		public DateTime LastPlayDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "enter_count" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int EnterCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "rank" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Rank { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "reward" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Reward { get; set; }

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

	}
}
