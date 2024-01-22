using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("charac_best_record", TableDescription = "")]
	public class CharacBestRecord
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "dungeon_no" , ColumnDataType = "smallint", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public short DungeonNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "difficulty" , ColumnDataType = "smallint", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public short Difficulty { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "style" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Style { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "technic" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Technic { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "attacked" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Attacked { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "rank" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Rank { get; set; }

	}
}
