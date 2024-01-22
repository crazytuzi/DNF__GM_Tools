using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("event_levelup_support", TableDescription = "")]
	public class EventLevelupSupport
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "level" , ColumnDataType = "int", IsPrimaryKey = true, ColumnDescription = "")]
		public int Level { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "state" , ColumnDataType = "int", IsNullable = true, ColumnDescription = "")]
		public int? State { get; set; }

	}
}
