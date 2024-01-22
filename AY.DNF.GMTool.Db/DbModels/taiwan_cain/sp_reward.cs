using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("sp_reward", TableDescription = "")]
	public class SpReward
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "grade" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Grade { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "sp" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Sp { get; set; }

	}
}
