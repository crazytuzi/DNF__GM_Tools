using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("news_bbs", TableDescription = "")]
	public class NewsBbs
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "bbs_code" , ColumnDataType = "tinyint", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public long BbsCode { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "emph_yn" , ColumnDataType = "tinyint", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public long EmphYn { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "no" , ColumnDataType = "int", IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "")]
		public int No { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "user_id" , ColumnDataType = "varchar", Length = 12, ColumnDescription = "")]
		public string UserId { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "reg_date" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int RegDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "html_yn" , ColumnDataType = "tinyint", IsNullable = true, DefaultValue = "0", ColumnDescription = "")]
		public long? HtmlYn { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "subject" , ColumnDataType = "varchar", Length = 50, ColumnDescription = "")]
		public string Subject { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "body" , ColumnDataType = "text", Length = 0, ColumnDescription = "")]
		public string Body { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "hits" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Hits { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "prev_no" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int PrevNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "next_no" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int NextNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "updt_date" , ColumnDataType = "int", IsNullable = true, ColumnDescription = "")]
		public int? UpdtDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "use_yn" , ColumnDataType = "tinyint", DefaultValue = "1", ColumnDescription = "")]
		public long UseYn { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "file_name" , ColumnDataType = "varchar", Length = 50, IsNullable = true, ColumnDescription = "")]
		public string? FileName { get; set; }

	}
}
