using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("charac_tower_despair", TableDescription = "")]
	public class CharacTowerDespair
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "first_layer_start_date" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime FirstLayerStartDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "today_enter_count" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long TodayEnterCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "last_clear_layer" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long LastClearLayer { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "enter_count_by_week" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int EnterCountByWeek { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_date" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime MDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "last_clear_date" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime LastClearDate { get; set; }

	}
}
