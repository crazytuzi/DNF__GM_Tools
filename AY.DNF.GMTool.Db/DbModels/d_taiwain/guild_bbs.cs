using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("guild_bbs", TableDescription = "")]
	public class GuildBbs
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gno" , ColumnDataType = "int", IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "")]
		public int Gno { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "bd_id" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long BdId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "empyn" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Empyn { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mgno" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Mgno { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "open" , ColumnDataType = "tinyint", DefaultValue = "1", ColumnDescription = "")]
		public long Open { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "main" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Main { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "reg_date" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int RegDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mod_date" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int ModDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "hits" , ColumnDataType = "mediumint", DefaultValue = "0", ColumnDescription = "")]
		public int Hits { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "body_type" , ColumnDataType = "char", Length = 1, ColumnDescription = "")]
		public string BodyType { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int MId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "reg_id" , ColumnDataType = "varchar", Length = 20, ColumnDescription = "")]
		public string RegId { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "subject" , ColumnDataType = "varchar", Length = 50, ColumnDescription = "")]
		public string Subject { get; set; } = string.Empty;

	}
}
