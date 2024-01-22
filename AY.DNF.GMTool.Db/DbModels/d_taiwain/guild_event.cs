using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("guild_event", TableDescription = "")]
	public class GuildEvent
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gno" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int Gno { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "stt_date" , ColumnDataType = "date", DefaultValue = "0000-00-00", ColumnDescription = "")]
		public DateTime SttDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "end_date" , ColumnDataType = "date", DefaultValue = "0000-00-00", ColumnDescription = "")]
		public DateTime EndDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ann_date" , ColumnDataType = "date", DefaultValue = "0000-00-00", ColumnDescription = "")]
		public DateTime AnnDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "page_url" , ColumnDataType = "varchar", Length = 100, ColumnDescription = "")]
		public string PageUrl { get; set; } = string.Empty;

	}
}
