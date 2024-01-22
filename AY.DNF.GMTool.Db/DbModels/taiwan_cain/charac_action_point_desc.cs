using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("charac_action_point_desc", TableDescription = "")]
	public class CharacActionPointDesc
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "action_group_index" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int ActionGroupIndex { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "action_index" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int ActionIndex { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "action_group_name" , ColumnDataType = "varchar", Length = 128, IsNullable = true, ColumnDescription = "")]
		public string? ActionGroupName { get; set; }

	}
}
