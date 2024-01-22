using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("account_cerashop_restrict", TableDescription = "")]
	public class AccountCerashopRestrict
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int MId { get; set; }

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
