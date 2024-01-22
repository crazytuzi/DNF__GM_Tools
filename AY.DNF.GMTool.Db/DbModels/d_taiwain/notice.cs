using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("notice", TableDescription = "")]
	public class Notice
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "bbs_name" , ColumnDataType = "varchar", Length = 10, ColumnDescription = "")]
		public string BbsName { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "no" , ColumnDataType = "mediumint", IsIdentity = true, ColumnDescription = "")]
		public int No { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "category" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Category { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_nickname" , ColumnDataType = "varchar", Length = 12, ColumnDescription = "")]
		public string MNickname { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int MId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_user_id" , ColumnDataType = "varchar", Length = 16, ColumnDescription = "")]
		public string MUserId { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_sex" , ColumnDataType = "enum", DefaultValue = "m", ColumnDescription = "")]
		public int MSex { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "title" , ColumnDataType = "varchar", Length = 120, ColumnDescription = "")]
		public string Title { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "create_day" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int CreateDay { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "comment" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Comment { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "view" , ColumnDataType = "mediumint", DefaultValue = "0", ColumnDescription = "")]
		public int View { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "recom" , ColumnDataType = "mediumint", DefaultValue = "0", ColumnDescription = "")]
		public int Recom { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "adorn" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Adorn { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "adorn_color1" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long AdornColor1 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "adorn_color2" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long AdornColor2 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "depth" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Depth { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "sequence" , ColumnDataType = "double unsigned", DefaultValue = "0", ColumnDescription = "")]
		public double Sequence { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "content" , ColumnDataType = "text", Length = 0, ColumnDescription = "")]
		public string Content { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "content_type" , ColumnDataType = "enum", DefaultValue = "br", ColumnDescription = "")]
		public int ContentType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ip" , ColumnDataType = "varchar", Length = 15, ColumnDescription = "")]
		public string Ip { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ring" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Ring { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "sms" , ColumnDataType = "enum", DefaultValue = "n", ColumnDescription = "")]
		public int Sms { get; set; }

	}
}
