using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("charac_quest_ref", TableDescription = "")]
	public class CharacQuestRef
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "origin_idx" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int OriginIdx { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mapped_idx" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int MappedIdx { get; set; }

	}
}
