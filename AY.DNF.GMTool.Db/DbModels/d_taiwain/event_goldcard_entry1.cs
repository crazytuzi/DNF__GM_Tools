using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("event_goldcard_entry1", TableDescription = "")]
	public class EventGoldcardEntry1
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "occ_date" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int OccDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int MId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "item_no" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long ItemNo { get; set; }

	}
}
