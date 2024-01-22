using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("dnf_restrict_state", TableDescription = "")]
	public class DnfRestrictState
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "server_group" , ColumnDataType = "int", IsPrimaryKey = true, ColumnDescription = "")]
		public int ServerGroup { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "category" , ColumnDataType = "int", IsPrimaryKey = true, ColumnDescription = "")]
		public int Category { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "restrict_code" , ColumnDataType = "int", IsPrimaryKey = true, ColumnDescription = "")]
		public int RestrictCode { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "restrict_value" , ColumnDataType = "char", Length = 1, ColumnDescription = "")]
		public string RestrictValue { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mod_date" , ColumnDataType = "datetime", ColumnDescription = "")]
		public DateTime ModDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "reg_date" , ColumnDataType = "datetime", ColumnDescription = "")]
		public DateTime RegDate { get; set; }

	}
}
