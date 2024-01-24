using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain_2nd
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("combo_skill", TableDescription = "")]
	public class ComboSkill
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "combo_idx" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int ComboIdx { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "value1" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Value1 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "value2" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Value2 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "value3" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Value3 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "value4" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Value4 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "value5" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Value5 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "value6" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Value6 { get; set; }

	}
}
