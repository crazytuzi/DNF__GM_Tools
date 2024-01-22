using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("bad_user", TableDescription = "")]
	public class BadUser
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "no" , ColumnDataType = "int", IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "")]
		public int No { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int MId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "bad_code" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int BadCode { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "create_day" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int CreateDay { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "exit_day" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int ExitDay { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "admin_n" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int AdminN { get; set; }

	}
}
