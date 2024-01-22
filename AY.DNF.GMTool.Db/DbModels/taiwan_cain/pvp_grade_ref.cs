using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("pvp_grade_ref", TableDescription = "")]
	public class PvpGradeRef
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "grade" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int Grade { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "limit_pts" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int LimitPts { get; set; }

	}
}
