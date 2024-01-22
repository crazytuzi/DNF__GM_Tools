using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("charac_option", TableDescription = "")]
	public class CharacOption
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "options" , ColumnDataType = "blob", ColumnDescription = "")]
		public byte[] Options { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "best_clear_time" , ColumnDataType = "blob", ColumnDescription = "")]
		public byte[] BestClearTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "blue_marble_enter_count" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long BlueMarbleEnterCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_inform_notice" , ColumnDataType = "varchar", Length = 255, ColumnDescription = "")]
		public string CharacInformNotice { get; set; } = string.Empty;

	}
}
