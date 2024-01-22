using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("charac_manage_info", TableDescription = "")]
	public class CharacManageInfo
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "tag_charac_no" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int TagCharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "striker_skill_index" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long StrikerSkillIndex { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "max_equip_level" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short MaxEquipLevel { get; set; }

	}
}
