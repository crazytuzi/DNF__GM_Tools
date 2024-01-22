using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("dnf_event_info", TableDescription = "")]
	public class DnfEventInfo
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "event_id" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int EventId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "event_name" , ColumnDataType = "varchar", Length = 30, ColumnDescription = "")]
		public string EventName { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "event_explain" , ColumnDataType = "varchar", Length = 100, ColumnDescription = "")]
		public string EventExplain { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "apply_type" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long ApplyType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "start_date" , ColumnDataType = "date", DefaultValue = "0000-00-00", ColumnDescription = "")]
		public DateTime StartDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "end_date" , ColumnDataType = "date", DefaultValue = "0000-00-00", ColumnDescription = "")]
		public DateTime EndDate { get; set; }

	}
}
