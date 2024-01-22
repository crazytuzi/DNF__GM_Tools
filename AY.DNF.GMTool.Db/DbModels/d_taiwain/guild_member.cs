using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("guild_member", TableDescription = "")]
	public class GuildMember
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "guild_id" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int GuildId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int MId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "server_id" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long ServerId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_name" , ColumnDataType = "varchar", Length = 20, ColumnDescription = "")]
		public string CharacName { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "nick_name" , ColumnDataType = "varchar", Length = 12, ColumnDescription = "")]
		public string NickName { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "grade" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Grade { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "job" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Job { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "grow_type" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long GrowType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "lev" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Lev { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "age" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Age { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "born_year" , ColumnDataType = "varchar", Length = 2, ColumnDescription = "")]
		public string BornYear { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "sex" , ColumnDataType = "char", Length = 1, ColumnDescription = "")]
		public string Sex { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "apply_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime ApplyTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "member_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime MemberTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "member_flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long MemberFlag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "bbs_cnt" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short BbsCnt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "last_visit_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime LastVisitTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "secede_type" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long SecedeType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "secede_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime SecedeTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "member_point" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int MemberPoint { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "member_point_prev" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int MemberPointPrev { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "last_play_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime LastPlayTime { get; set; }

	}
}
