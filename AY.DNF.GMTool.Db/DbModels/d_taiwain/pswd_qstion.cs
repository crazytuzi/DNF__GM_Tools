using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("pswd_qstion", TableDescription = "")]
	public class PswdQstion
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "q_no" , ColumnDataType = "tinyint", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public long QNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "q_text" , ColumnDataType = "varchar", Length = 20, ColumnDescription = "")]
		public string QText { get; set; } = string.Empty;

	}
}
