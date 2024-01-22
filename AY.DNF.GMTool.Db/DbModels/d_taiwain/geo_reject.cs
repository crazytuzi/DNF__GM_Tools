using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("geo_reject", TableDescription = "")]
	public class GeoReject
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "rej_ip" , ColumnDataType = "varchar", IsPrimaryKey = true, Length = 20, ColumnDescription = "")]
		public string RejIp { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "rej_c_code" , ColumnDataType = "varchar", Length = 4, ColumnDescription = "")]
		public string RejCCode { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "rej_ip_count" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int RejIpCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "rej_last_date" , ColumnDataType = "timestamp", DefaultValue = "CURRENT_TIMESTAMP", ColumnDescription = "")]
		public DateTime RejLastDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "rej_chk" , ColumnDataType = "char", Length = 1, DefaultValue = "N", ColumnDescription = "")]
		public string RejChk { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "rej_src" , ColumnDataType = "enum", DefaultValue = "w", ColumnDescription = "")]
		public int RejSrc { get; set; }

	}
}
