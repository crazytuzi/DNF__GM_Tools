using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("log_num_occupations", TableDescription = "")]
	public class LogNumOccupations
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "occ_time" , ColumnDataType = "datetime", IsPrimaryKey = true, DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime OccTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "num_occupations_charscreen" , ColumnDataType = "mediumint", DefaultValue = "0", ColumnDescription = "")]
		public int NumOccupationsCharscreen { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "num_occupations_seriaroom" , ColumnDataType = "mediumint", DefaultValue = "0", ColumnDescription = "")]
		public int NumOccupationsSeriaroom { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "num_login_per_min" , ColumnDataType = "mediumint", DefaultValue = "0", ColumnDescription = "")]
		public int NumLoginPerMin { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "num_logout_per_min" , ColumnDataType = "mediumint", DefaultValue = "0", ColumnDescription = "")]
		public int NumLogoutPerMin { get; set; }

	}
}
