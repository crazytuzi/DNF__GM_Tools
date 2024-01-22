using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("dnf_event_prize", TableDescription = "")]
	public class DnfEventPrize
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "prize_id" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int PrizeId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int MId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "check_time" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int CheckTime { get; set; }

	}
}
