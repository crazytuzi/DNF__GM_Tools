using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("stat_game_channel", TableDescription = "")]
	public class StatGameChannel
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_channel" , ColumnDataType = "varchar", Length = 10, ColumnDescription = "")]
		public string GcChannel { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_up_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime GcUpTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_now" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short GcNow { get; set; }

	}
}
