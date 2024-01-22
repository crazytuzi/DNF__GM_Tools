using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("geo_allow_country", TableDescription = "")]
	public class GeoAllowCountry
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "server_group" , ColumnDataType = "tinyint", IsPrimaryKey = true, ColumnDescription = "")]
		public long ServerGroup { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "country_code" , ColumnDataType = "varchar", IsPrimaryKey = true, Length = 10, ColumnDescription = "")]
		public string CountryCode { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "reg_date" , ColumnDataType = "datetime", ColumnDescription = "")]
		public DateTime RegDate { get; set; }

	}
}
