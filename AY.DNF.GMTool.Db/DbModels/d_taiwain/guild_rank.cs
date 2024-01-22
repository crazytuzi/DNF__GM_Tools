using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("guild_rank", TableDescription = "")]
	public class GuildRank
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "server_id" , ColumnDataType = "tinyint", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public long ServerId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "guild_id" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int GuildId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "guild_name" , ColumnDataType = "varchar", Length = 40, DefaultValue = "0", ColumnDescription = "")]
		public string GuildName { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "guild_Rank" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Guild_Rank { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "guild_point" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int GuildPoint { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "guild_acc_point" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int GuildAccPoint { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "guild_visit" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int GuildVisit { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "guild_acc_visit" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int GuildAccVisit { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "guild_member" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short GuildMember { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "guild_acc_member" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short GuildAccMember { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "guild_avg_lev" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short GuildAvgLev { get; set; }

	}
}
