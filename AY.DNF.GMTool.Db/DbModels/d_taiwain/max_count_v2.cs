using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("max_count_v2", TableDescription = "")]
	public class MaxCountV2
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "server_info" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long ServerInfo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "num_occupations_charscreen" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int NumOccupationsCharscreen { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "num_occupations_seriaroom" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int NumOccupationsSeriaroom { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "num_login_per_min" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int NumLoginPerMin { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "num_logout_per_min" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int NumLogoutPerMin { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mc_date" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime McDate { get; set; }

	}
}
