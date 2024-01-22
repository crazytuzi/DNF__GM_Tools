using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("guild_visit", TableDescription = "")]
	public class GuildVisit
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "guild_id" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int GuildId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "server_id" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long ServerId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "total_visit" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int TotalVisit { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "today_visit" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int TodayVisit { get; set; }

	}
}
