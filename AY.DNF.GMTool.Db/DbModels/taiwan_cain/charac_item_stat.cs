using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("charac_item_stat", TableDescription = "")]
	public class CharacItemStat
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "cooltime_item" , ColumnDataType = "blob", ColumnDescription = "")]
		public byte[] CooltimeItem { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "effect_item" , ColumnDataType = "blob", ColumnDescription = "")]
		public byte[] EffectItem { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "check_flag" , ColumnDataType = "blob", ColumnDescription = "")]
		public byte[] CheckFlag { get; set; }

	}
}
