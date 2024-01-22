using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("guild_introduce", TableDescription = "")]
	public class GuildIntroduce
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
		[SugarColumn(ColumnName = "introduce" , ColumnDataType = "varchar", Length = 200, ColumnDescription = "")]
		public string Introduce { get; set; } = string.Empty;

	}
}
