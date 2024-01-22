using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("exp_level_ref", TableDescription = "")]
	public class ExpLevelRef
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "exp" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Exp { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "lev" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Lev { get; set; }

	}
}
