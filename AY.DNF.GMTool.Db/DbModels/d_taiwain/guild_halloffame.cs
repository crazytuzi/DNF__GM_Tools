using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("guild_halloffame", TableDescription = "")]
	public class GuildHalloffame
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "fame_id" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int FameId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "server_id" , ColumnDataType = "tinyint", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public long ServerId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "guild_id" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int GuildId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "guild_name" , ColumnDataType = "varchar", Length = 40, ColumnDescription = "")]
		public string GuildName { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "file_url" , ColumnDataType = "varchar", Length = 128, DefaultValue = "0", ColumnDescription = "")]
		public string FileUrl { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "open_flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long OpenFlag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "main_flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long MainFlag { get; set; }

	}
}
