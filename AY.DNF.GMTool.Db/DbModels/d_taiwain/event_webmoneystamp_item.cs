using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("event_webmoneystamp_item", TableDescription = "")]
	public class EventWebmoneystampItem
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int MId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "occ_time" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int OccTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "server_id" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long ServerId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "item_no" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int ItemNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "item_check" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int ItemCheck { get; set; }

	}
}
