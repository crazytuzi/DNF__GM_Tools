using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("event_arad_birthday_6th", TableDescription = "")]
	public class EventAradBirthday6th
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "server" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int Server { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "point" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Point { get; set; }

	}
}
