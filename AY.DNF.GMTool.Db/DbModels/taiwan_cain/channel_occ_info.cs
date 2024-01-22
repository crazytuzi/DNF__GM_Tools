using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("channel_occ_info", TableDescription = "")]
	public class ChannelOccInfo
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int GcNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "age" , ColumnDataType = "tinyint", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public long Age { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "occ_num" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short OccNum { get; set; }

	}
}
