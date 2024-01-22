using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("guild_stat", TableDescription = "")]
	public class GuildStat
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "occ_date" , ColumnDataType = "date", IsPrimaryKey = true, DefaultValue = "0000-00-00", ColumnDescription = "")]
		public DateTime OccDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "lev" , ColumnDataType = "tinyint", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public long Lev { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "server_id" , ColumnDataType = "tinyint", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public long ServerId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "create_no" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int CreateNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "acc_create_no" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int AccCreateNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "member_no" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int MemberNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "acc_member_no" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int AccMemberNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "avg_lev" , ColumnDataType = "float", DefaultValue = "0", ColumnDescription = "")]
		public float AvgLev { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "avg_master_lev" , ColumnDataType = "float", DefaultValue = "0", ColumnDescription = "")]
		public float AvgMasterLev { get; set; }

	}
}
