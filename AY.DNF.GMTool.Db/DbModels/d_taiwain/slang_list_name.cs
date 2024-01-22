using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("slang_list_name", TableDescription = "")]
	public class SlangListName
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "slang" , ColumnDataType = "varchar", IsPrimaryKey = true, Length = 153, ColumnDescription = "")]
		public string Slang { get; set; } = string.Empty;

	}
}
