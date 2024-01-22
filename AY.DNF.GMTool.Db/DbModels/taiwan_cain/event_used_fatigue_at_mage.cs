using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("event_used_fatigue_at_mage", TableDescription = "")]
	public class EventUsedFatigueAtMage
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "fatigue_quantity" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int FatigueQuantity { get; set; }

	}
}
