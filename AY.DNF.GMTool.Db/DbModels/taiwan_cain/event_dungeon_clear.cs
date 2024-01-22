using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("event_dungeon_clear", TableDescription = "")]
	public class EventDungeonClear
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "clear_cnt" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int ClearCnt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "update_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime UpdateTime { get; set; }

	}
}
