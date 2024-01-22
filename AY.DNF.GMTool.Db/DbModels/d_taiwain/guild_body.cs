using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("guild_body", TableDescription = "")]
	public class GuildBody
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gno" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int Gno { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "body" , ColumnDataType = "text", Length = 0, ColumnDescription = "")]
		public string Body { get; set; } = string.Empty;

	}
}
