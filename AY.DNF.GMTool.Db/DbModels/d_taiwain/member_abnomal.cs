using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("member_abnomal", TableDescription = "")]
	public class MemberAbnomal
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "user_id" , ColumnDataType = "varchar", IsPrimaryKey = true, Length = 12, ColumnDescription = "")]
		public string UserId { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "overlab_count" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short OverlabCount { get; set; }

	}
}
