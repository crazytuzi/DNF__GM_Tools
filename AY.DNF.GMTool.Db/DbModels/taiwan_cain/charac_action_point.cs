using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("charac_action_point", TableDescription = "")]
	public class CharacActionPoint
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "occ_date" , ColumnDataType = "date", IsPrimaryKey = true, DefaultValue = "0000-00-00", ColumnDescription = "")]
		public DateTime OccDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ap_sum" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int ApSum { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "is_reward_medal" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long IsRewardMedal { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "is_reward_item_1" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long IsRewardItem1 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "is_reward_item_2" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long IsRewardItem2 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "is_reward_item_3" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long IsRewardItem3 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "is_reward_item_4" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long IsRewardItem4 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ap_clear_state" , ColumnDataType = "blob", ColumnDescription = "")]
		public byte[] ApClearState { get; set; }

	}
}
