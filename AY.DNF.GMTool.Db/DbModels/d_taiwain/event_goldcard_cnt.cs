using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("event_goldcard_cnt", TableDescription = "")]
	public class EventGoldcardCnt
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "item_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int ItemNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "occ_date" , ColumnDataType = "date", IsPrimaryKey = true, DefaultValue = "0000-00-00", ColumnDescription = "")]
		public DateTime OccDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "cnt" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Cnt { get; set; }

	}
}
