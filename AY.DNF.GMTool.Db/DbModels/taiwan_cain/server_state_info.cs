using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("server_state_info", TableDescription = "")]
	public class ServerStateInfo
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "category" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "-1", ColumnDescription = "")]
		public int Category { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "code" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "-1", ColumnDescription = "")]
		public int Code { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "state" , ColumnDataType = "binary", DefaultValue = "            ", ColumnDescription = "")]
		public byte[] State { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "start_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime StartTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "end_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime EndTime { get; set; }

	}
}
