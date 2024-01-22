using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("item_gen_ref", TableDescription = "")]
	public class ItemGenRef
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "item_grade" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long ItemGrade { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "rate_type" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long RateType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "money_rate" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short MoneyRate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "item_rate" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short ItemRate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "free_rate" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short FreeRate { get; set; }

	}
}
