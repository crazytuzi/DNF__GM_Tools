using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("member_lioness", TableDescription = "")]
	public class MemberLioness
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "user_id" , ColumnDataType = "varchar", Length = 30, ColumnDescription = "")]
		public string UserId { get; set; } = string.Empty;

	}
}
