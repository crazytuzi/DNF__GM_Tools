using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("charac_cerashop_restrict", TableDescription = "")]
	public class CharacCerashopRestrict
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ipg_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int IpgNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "count" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Count { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "next_date" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int NextDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "end_date" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int EndDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "last_access_date" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int LastAccessDate { get; set; }

	}
}
