using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("dnf_gamein_notice", TableDescription = "")]
	public class DnfGameinNotice
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "no" , ColumnDataType = "int", IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "")]
		public int No { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "img_name" , ColumnDataType = "varchar", Length = 250, ColumnDescription = "")]
		public string ImgName { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "server_id" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long ServerId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "reg_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime RegTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "open_flag" , ColumnDataType = "enum", IsNullable = true, DefaultValue = "n", ColumnDescription = "")]
		public int? OpenFlag { get; set; }

	}
}
