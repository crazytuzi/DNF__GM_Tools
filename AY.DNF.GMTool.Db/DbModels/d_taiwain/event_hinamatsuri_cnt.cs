using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("event_hinamatsuri_cnt", TableDescription = "")]
	public class EventHinamatsuriCnt
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "cnt" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Cnt { get; set; }

	}
}
