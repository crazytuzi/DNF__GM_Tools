using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("dnf_event_log", TableDescription = "")]
	public class DnfEventLog
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "log_id" , ColumnDataType = "int", IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "")]
		public int LogId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "occ_time" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int OccTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "event_type" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long EventType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "parameter1" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Parameter1 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "parameter2" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Parameter2 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "server_id" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long ServerId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "event_flag" , ColumnDataType = "tinyint", IsNullable = true, DefaultValue = "0", ColumnDescription = "")]
		public long? EventFlag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "start_time" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int StartTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "end_time" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int EndTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int MId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "expl" , ColumnDataType = "varchar", Length = 200, ColumnDescription = "")]
		public string Expl { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "etc" , ColumnDataType = "varchar", Length = 100, ColumnDescription = "")]
		public string Etc { get; set; } = string.Empty;

	}
}
