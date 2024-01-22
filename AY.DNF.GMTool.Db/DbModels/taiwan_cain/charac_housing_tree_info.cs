using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("charac_housing_tree_info", TableDescription = "")]
	public class CharacHousingTreeInfo
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "tree_id" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int TreeId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "expire_date" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime ExpireDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "current_point" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short CurrentPoint { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "leaf_point" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short LeafPoint { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "day_water_count" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short DayWaterCount { get; set; }

	}
}
