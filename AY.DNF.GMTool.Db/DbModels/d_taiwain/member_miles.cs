using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("member_miles", TableDescription = "")]
	public class MemberMiles
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int MId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "miles" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Miles { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "daily_miles" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short DailyMiles { get; set; }

	}
}
