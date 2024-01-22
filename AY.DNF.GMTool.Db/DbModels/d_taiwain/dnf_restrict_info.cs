using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 서비스 제재 정보 문자열
	/// </summary>
	[SugarTable("dnf_restrict_info", TableDescription = "서비스 제재 정보 문자열")]
	public class DnfRestrictInfo
	{
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
		[SugarColumn(ColumnName = "restrict_str" , ColumnDataType = "varchar", Length = 45, ColumnDescription = "")]
		public string RestrictStr { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "reg_date" , ColumnDataType = "datetime", ColumnDescription = "")]
		public DateTime RegDate { get; set; }

	}
}
