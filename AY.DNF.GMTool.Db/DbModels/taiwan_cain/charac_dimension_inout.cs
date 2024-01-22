using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("charac_dimension_inout", TableDescription = "")]
	public class CharacDimensionInout
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "dungeon1" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Dungeon1 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "dungeon2" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Dungeon2 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "dungeon3" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Dungeon3 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "dungeon4" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Dungeon4 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "dungeon5" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Dungeon5 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "dungeon6" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Dungeon6 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "dungeon7" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Dungeon7 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "dungeon8" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Dungeon8 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "dungeon9" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Dungeon9 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "dungeon10" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Dungeon10 { get; set; }

	}
}
