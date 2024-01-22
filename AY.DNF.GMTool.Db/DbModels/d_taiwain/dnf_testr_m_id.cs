using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("dnf_testr_m_id", TableDescription = "")]
	public class DnfTestrMId
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int MId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "sex" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Sex { get; set; }

	}
}
