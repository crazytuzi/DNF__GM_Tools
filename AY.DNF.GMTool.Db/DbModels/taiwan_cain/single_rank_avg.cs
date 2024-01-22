using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("single_rank_avg", TableDescription = "")]
	public class SingleRankAvg
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "dungeon_index" , ColumnDataType = "smallint", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public short DungeonIndex { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "level" , ColumnDataType = "smallint", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public short Level { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "job" , ColumnDataType = "smallint", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public short Job { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "clear_count" , ColumnDataType = "bigint", DefaultValue = "0", ColumnDescription = "")]
		public long ClearCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "average" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Average { get; set; }

	}
}
