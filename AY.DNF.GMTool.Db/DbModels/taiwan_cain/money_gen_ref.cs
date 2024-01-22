using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("money_gen_ref", TableDescription = "")]
	public class MoneyGenRef
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "grade" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Grade { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "bottom_grade" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int BottomGrade { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "money" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Money { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "random_value" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int RandomValue { get; set; }

	}
}
