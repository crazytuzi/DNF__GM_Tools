using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("item_select_std", TableDescription = "")]
	public class ItemSelectStd
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "item_grade" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int ItemGrade { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "top" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Top { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "bottom" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Bottom { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "weight" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Weight { get; set; }

	}
}
