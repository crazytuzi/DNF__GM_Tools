using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain_2nd
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("skill_index", TableDescription = "")]
	public class SkillIndex
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "no" , ColumnDataType = "int", IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "")]
		public int No { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "job" , ColumnDataType = "mediumint", DefaultValue = "100", ColumnDescription = "")]
		public int Job { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "skill_idx" , ColumnDataType = "mediumint", DefaultValue = "0", ColumnDescription = "")]
		public int SkillIdx { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "skill_name" , ColumnDataType = "varchar", Length = 30, ColumnDescription = "")]
		public string SkillName { get; set; } = string.Empty;

	}
}
