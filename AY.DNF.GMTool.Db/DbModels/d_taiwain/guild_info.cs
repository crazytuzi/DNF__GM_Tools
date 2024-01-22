using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("guild_info", TableDescription = "")]
	public class GuildInfo
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "guild_id" , ColumnDataType = "int", IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "")]
		public int GuildId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "server_id" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long ServerId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "guild_name" , ColumnDataType = "varchar", Length = 40, ColumnDescription = "")]
		public string GuildName { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "master_id" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int MasterId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "master_no" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int MasterNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "master_name" , ColumnDataType = "varchar", Length = 20, ColumnDescription = "")]
		public string MasterName { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "guild_url" , ColumnDataType = "varchar", Length = 40, ColumnDescription = "")]
		public string GuildUrl { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "guild_icon" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long GuildIcon { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "create_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime CreateTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "lev" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Lev { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ability" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Ability { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "expire_flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long ExpireFlag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "expire_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime ExpireTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "member_secede_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime MemberSecedeTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "member_count" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int MemberCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "recommend_flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long RecommendFlag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "recommend_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime RecommendTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "guild_point" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int GuildPoint { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "guild_point_acc" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int GuildPointAcc { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "guild_point_prev" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int GuildPointPrev { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "guild_rank" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int GuildRank { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "guild_war_point" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int GuildWarPoint { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "final_entry" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short FinalEntry { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "final_win" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short FinalWin { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "guild_icon_auth" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long GuildIconAuth { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "guild_exp" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int GuildExp { get; set; }

	}
}
