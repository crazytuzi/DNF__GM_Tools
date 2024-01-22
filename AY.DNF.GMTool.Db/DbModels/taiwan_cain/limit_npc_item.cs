using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("limit_npc_item", TableDescription = "")]
	public class LimitNpcItem
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "item_index" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int ItemIndex { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "max_count" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int MaxCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "sell_count" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int SellCount { get; set; }

	}
}
