using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("ch_status", TableDescription = "")]
	public class ChStatus
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_group" , ColumnDataType = "tinyint", DefaultValue = "1", ColumnDescription = "")]
		public long GcGroup { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_status" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long GcStatus { get; set; }

	}
}
