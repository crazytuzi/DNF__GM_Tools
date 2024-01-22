using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("event_aradlotto_0809_entry", TableDescription = "")]
	public class EventAradlotto0809Entry
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int MId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "occ_date" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int OccDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "lotto_num" , ColumnDataType = "char", Length = 7, ColumnDescription = "")]
		public string LottoNum { get; set; } = string.Empty;

	}
}
