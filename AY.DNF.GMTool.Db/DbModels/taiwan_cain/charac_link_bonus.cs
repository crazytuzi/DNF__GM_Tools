using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("charac_link_bonus", TableDescription = "")]
	public class CharacLinkBonus
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "exp" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Exp { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gold" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Gold { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mercenary_start_time" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int MercenaryStartTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mercenary_finish_time" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int MercenaryFinishTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mercenary_area" , ColumnDataType = "tinyint", DefaultValue = "-1", ColumnDescription = "")]
		public long MercenaryArea { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mercenary_period" , ColumnDataType = "tinyint", DefaultValue = "-1", ColumnDescription = "")]
		public long MercenaryPeriod { get; set; }

	}
}
