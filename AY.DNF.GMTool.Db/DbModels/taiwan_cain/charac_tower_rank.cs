using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("charac_tower_rank", TableDescription = "")]
	public class CharacTowerRank
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "tower_index" , ColumnDataType = "tinyint", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public long TowerIndex { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "part_type" , ColumnDataType = "tinyint", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public long PartType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "member_info" , ColumnDataType = "char", Length = 128, ColumnDescription = "")]
		public string MemberInfo { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "rank" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Rank { get; set; }

	}
}
