using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("quest_category", TableDescription = "")]
	public class QuestCategory
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "quest_idx" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int QuestIdx { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "quest_name" , ColumnDataType = "varchar", Length = 30, ColumnDescription = "")]
		public string QuestName { get; set; } = string.Empty;

	}
}
