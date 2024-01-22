using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("event_1106_idol_bring_up", TableDescription = "")]
	public class Event1106IdolBringUp
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int MId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "pot_type" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long PotType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "water_cnt" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long WaterCnt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "give_title_flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long GiveTitleFlag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "occ_date" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime OccDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "give_title_flag2" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long GiveTitleFlag2 { get; set; }

	}
}
