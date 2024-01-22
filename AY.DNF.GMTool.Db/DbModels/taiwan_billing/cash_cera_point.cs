using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_billing
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("cash_cera_point", TableDescription = "")]
	public class CashCeraPoint
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "account" , ColumnDataType = "varchar", IsPrimaryKey = true, Length = 30, ColumnDescription = "")]
		public string Account { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "cera_point" , ColumnDataType = "int", ColumnDescription = "")]
		public int CeraPoint { get; set; }

		///// <summary>
		///// 
		///// </summary>
		//[SugarColumn(ColumnName = "reg_date" , ColumnDataType = "datetime", ColumnDescription = "")]
		//public DateTime? RegDate { get; set; }

		///// <summary>
		///// 
		///// </summary>
		//[SugarColumn(ColumnName = "mod_date" , ColumnDataType = "datetime", ColumnDescription = "")]
		//public DateTime? ModDate { get; set; }

	}
}
