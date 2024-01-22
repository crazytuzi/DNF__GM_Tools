using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("geo_country_code", TableDescription = "")]
	public class GeoCountryCode
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "code_no" , ColumnDataType = "int", IsPrimaryKey = true, ColumnDescription = "")]
		public int CodeNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "country_code_a2" , ColumnDataType = "varchar", Length = 10, ColumnDescription = "")]
		public string CountryCodeA2 { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "country_code_a3" , ColumnDataType = "varchar", Length = 10, ColumnDescription = "")]
		public string CountryCodeA3 { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "country" , ColumnDataType = "varchar", Length = 255, ColumnDescription = "")]
		public string Country { get; set; } = string.Empty;

	}
}
