using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("charac_titlebook", TableDescription = "")]
	public class CharacTitlebook
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "specific_section" , ColumnDataType = "blob", ColumnDescription = "")]
		public byte[] SpecificSection { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "general_section" , ColumnDataType = "blob", ColumnDescription = "")]
		public byte[] GeneralSection { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "despair" , ColumnDataType = "blob", ColumnDescription = "")]
		public byte[] Despair { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "event" , ColumnDataType = "blob", ColumnDescription = "")]
		public byte[] Event { get; set; }

	}
}
