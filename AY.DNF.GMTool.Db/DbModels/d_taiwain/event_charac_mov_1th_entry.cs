using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("event_charac_mov_1th_entry", TableDescription = "")]
	public class EventCharacMov1thEntry
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int MId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "occ_time" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int OccTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "it_no" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int ItNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "item_check" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int ItemCheck { get; set; }

	}
}
