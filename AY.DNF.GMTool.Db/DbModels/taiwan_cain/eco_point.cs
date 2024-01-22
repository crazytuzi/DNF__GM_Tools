using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("eco_point", TableDescription = "")]
	public class EcoPoint
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "eco_point" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Eco_Point { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "point_500" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Point500 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "point_300" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Point300 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "point_100" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Point100 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "point_50" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Point50 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "point_20" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Point20 { get; set; }

	}
}
