using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("member_premium_history", TableDescription = "")]
	public class MemberPremiumHistory
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "event_id" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int EventId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "pre_type" , ColumnDataType = "tinyint", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public long PreType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int MId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "service_start" , ColumnDataType = "datetime", IsPrimaryKey = true, DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime ServiceStart { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "service_end" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime ServiceEnd { get; set; }

	}
}
