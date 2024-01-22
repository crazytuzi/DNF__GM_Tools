using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("dnf_story", TableDescription = "")]
	public class DnfStory
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "no" , ColumnDataType = "int", IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "")]
		public int No { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "story_type" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long StoryType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "notice_flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long NoticeFlag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int MId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "reg_id" , ColumnDataType = "varchar", Length = 12, ColumnDescription = "")]
		public string RegId { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "title" , ColumnDataType = "varchar", Length = 50, ColumnDescription = "")]
		public string Title { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "url" , ColumnDataType = "varchar", Length = 250, ColumnDescription = "")]
		public string Url { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "img_name" , ColumnDataType = "varchar", Length = 30, ColumnDescription = "")]
		public string ImgName { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "opt" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Opt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "open_flag" , ColumnDataType = "enum", DefaultValue = "n", ColumnDescription = "")]
		public int OpenFlag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "reg_date" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime RegDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "hits" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Hits { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "reserve_time" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int ReserveTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "content" , ColumnDataType = "text", Length = 0, IsNullable = true, ColumnDescription = "")]
		public string? Content { get; set; }

	}
}
