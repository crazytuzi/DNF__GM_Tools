using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain_2nd
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("letter", TableDescription = "")]
	public class Letter
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "letter_id" , ColumnDataType = "int", IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "")]
		public int LetterId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "send_charac_no" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int SendCharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "send_charac_name" , ColumnDataType = "varchar", Length = 20, ColumnDescription = "")]
		public string SendCharacName { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "letter_text" , ColumnDataType = "varchar", Length = 255, ColumnDescription = "")]
		public string LetterText { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "reg_date" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime RegDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "stat" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Stat { get; set; }

	}
}
