using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("max_count_pvp", TableDescription = "")]
	public class MaxCountPvp
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "server_info" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long ServerInfo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mc_max" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int McMax { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mc_date" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime McDate { get; set; }

	}
}
