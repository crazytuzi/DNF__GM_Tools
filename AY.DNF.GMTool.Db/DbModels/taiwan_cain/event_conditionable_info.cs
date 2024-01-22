using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("event_conditionable_info", TableDescription = "")]
	public class EventConditionableInfo
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "current_step" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long CurrentStep { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "reward_step" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long RewardStep { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "update_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime UpdateTime { get; set; }

	}
}
