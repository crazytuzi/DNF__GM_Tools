using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("accounts", TableDescription = "")]
	public class Accounts
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "UID" , ColumnDataType = "int", IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "")]
		public int UID { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "accountname" , ColumnDataType = "varchar", Length = 255, ColumnDescription = "")]
		public string Accountname { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "password" , ColumnDataType = "varchar", Length = 255, ColumnDescription = "")]
		public string Password { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "qq" , ColumnDataType = "varchar", Length = 255, IsNullable = true, ColumnDescription = "")]
		public string? Qq { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ip" , ColumnDataType = "varchar", Length = 255, IsNullable = true, ColumnDescription = "")]
		public string? Ip { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "VIP" , ColumnDataType = "varchar", Length = 255, ColumnDescription = "")]
		public string VIP { get; set; } = string.Empty;

	}
}
