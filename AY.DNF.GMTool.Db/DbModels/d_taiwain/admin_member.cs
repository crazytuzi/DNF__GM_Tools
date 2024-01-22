using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("admin_member", TableDescription = "")]
	public class AdminMember
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "no" , ColumnDataType = "int", IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "")]
		public int No { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "user_id" , ColumnDataType = "varchar", Length = 20, ColumnDescription = "")]
		public string UserId { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "password" , ColumnDataType = "varchar", Length = 20, ColumnDescription = "")]
		public string Password { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "name" , ColumnDataType = "varchar", Length = 20, ColumnDescription = "")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "email" , ColumnDataType = "varchar", Length = 255, IsNullable = true, ColumnDescription = "")]
		public string? Email { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "phone" , ColumnDataType = "varchar", Length = 255, IsNullable = true, ColumnDescription = "")]
		public string? Phone { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "msn" , ColumnDataType = "varchar", Length = 50, IsNullable = true, ColumnDescription = "")]
		public string? Msn { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "comment" , ColumnDataType = "text", Length = 0, IsNullable = true, ColumnDescription = "")]
		public string? Comment { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "reg_date" , ColumnDataType = "int", IsNullable = true, ColumnDescription = "")]
		public int? RegDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "confirm" , ColumnDataType = "char", Length = 1, IsNullable = true, DefaultValue = "0", ColumnDescription = "")]
		public string? Confirm { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "level" , ColumnDataType = "varchar", Length = 2000, ColumnDescription = "")]
		public string Level { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "level_group1" , ColumnDataType = "varchar", Length = 2, DefaultValue = "_", ColumnDescription = "")]
		public string LevelGroup1 { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "level_group2" , ColumnDataType = "varchar", Length = 2, DefaultValue = "_", ColumnDescription = "")]
		public string LevelGroup2 { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "level_group3" , ColumnDataType = "varchar", Length = 2, DefaultValue = "_", ColumnDescription = "")]
		public string LevelGroup3 { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "level_group4" , ColumnDataType = "varchar", Length = 2, DefaultValue = "_", ColumnDescription = "")]
		public string LevelGroup4 { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "level_group5" , ColumnDataType = "varchar", Length = 2, DefaultValue = "_", ColumnDescription = "")]
		public string LevelGroup5 { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "level_group6" , ColumnDataType = "varchar", Length = 2, DefaultValue = "_", ColumnDescription = "")]
		public string LevelGroup6 { get; set; } = string.Empty;

	}
}
