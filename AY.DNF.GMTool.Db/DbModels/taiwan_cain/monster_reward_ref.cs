using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("monster_reward_ref", TableDescription = "")]
	public class MonsterRewardRef
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "level" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Level { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "exp" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Exp { get; set; }

	}
}
