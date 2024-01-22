using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("geo_allow", TableDescription = "")]
	public class GeoAllow
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "allow_ip" , ColumnDataType = "varchar", IsPrimaryKey = true, Length = 20, ColumnDescription = "")]
		public string AllowIp { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "allow_c_code" , ColumnDataType = "varchar", Length = 4, ColumnDescription = "")]
		public string AllowCCode { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "allow_date" , ColumnDataType = "timestamp", DefaultValue = "CURRENT_TIMESTAMP", ColumnDescription = "")]
		public DateTime AllowDate { get; set; }

	}
}
