using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("charac_housing_water_history", TableDescription = "")]
	public class CharacHousingWaterHistory
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "give_time" , ColumnDataType = "timestamp", IsPrimaryKey = true, DefaultValue = "CURRENT_TIMESTAMP", ColumnDescription = "")]
		public DateTime GiveTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "give_charac_name" , ColumnDataType = "varchar", Length = 20, ColumnDescription = "")]
		public string GiveCharacName { get; set; } = string.Empty;

	}
}
