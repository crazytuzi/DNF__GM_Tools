using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain_2nd
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("charac_event_items", TableDescription = "")]
	public class CharacEventItems
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "id" , ColumnDataType = "int", IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "")]
		public int Id { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "it_id" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int ItId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "event_code" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int EventCode { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "reg_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime RegTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "delete_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime DeleteTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "delete_flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long DeleteFlag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "stack_count" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int StackCount { get; set; }

	}
}
