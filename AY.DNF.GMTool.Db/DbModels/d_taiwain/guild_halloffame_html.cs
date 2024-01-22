using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("guild_halloffame_html", TableDescription = "")]
	public class GuildHalloffameHtml
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "fame_id" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int FameId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "title" , ColumnDataType = "varchar", Length = 100, ColumnDescription = "")]
		public string Title { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "html" , ColumnDataType = "text", Length = 0, ColumnDescription = "")]
		public string Html { get; set; } = string.Empty;

	}
}
