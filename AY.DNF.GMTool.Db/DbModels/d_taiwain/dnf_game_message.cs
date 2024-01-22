using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("dnf_game_message", TableDescription = "")]
	public class DnfGameMessage
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "no" , ColumnDataType = "int", IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "")]
		public int No { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "message" , ColumnDataType = "varchar", Length = 255, IsNullable = true, ColumnDescription = "")]
		public string? Message { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "display_type" , ColumnDataType = "tinyint", DefaultValue = "1", ColumnDescription = "")]
		public long DisplayType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "start_h" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long StartH { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "end_h" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long EndH { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "occ_date" , ColumnDataType = "date", DefaultValue = "0000-00-00", ColumnDescription = "")]
		public DateTime OccDate { get; set; }

	}
}
