using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain_2nd
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("skill_lethe", TableDescription = "")]
	public class SkillLethe
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int MId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "skill_slot" , ColumnDataType = "blob", ColumnDescription = "")]
		public byte[] SkillSlot { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Flag { get; set; }

	}
}
