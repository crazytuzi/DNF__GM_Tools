using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("pvp_grade_expand", TableDescription = "")]
	public class PvpGradeExpand
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "pvp_grade" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int PvpGrade { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "pvp_point" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int PvpPoint { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "last_play_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime LastPlayTime { get; set; }

	}
}
