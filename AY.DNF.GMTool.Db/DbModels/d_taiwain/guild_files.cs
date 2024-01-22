using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("guild_files", TableDescription = "")]
	public class GuildFiles
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gno" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int Gno { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gf_no" , ColumnDataType = "tinyint", IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "")]
		public long GfNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "file_server" , ColumnDataType = "varchar", Length = 50, ColumnDescription = "")]
		public string FileServer { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "file_location" , ColumnDataType = "varchar", Length = 100, ColumnDescription = "")]
		public string FileLocation { get; set; } = string.Empty;

	}
}
