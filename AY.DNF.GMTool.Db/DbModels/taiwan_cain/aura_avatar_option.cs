using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("aura_avatar_option", TableDescription = "")]
	public class AuraAvatarOption
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "option_type" , ColumnDataType = "tinyint", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public long OptionType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "value_1" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Value1 { get; set; }

	}
}
