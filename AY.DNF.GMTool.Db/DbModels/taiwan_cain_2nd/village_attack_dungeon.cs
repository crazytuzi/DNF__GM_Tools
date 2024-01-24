using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain_2nd
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("village_attack_dungeon", TableDescription = "")]
	public class VillageAttackDungeon
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "occ_date" , ColumnDataType = "date", IsPrimaryKey = true, DefaultValue = "0000-00-00", ColumnDescription = "")]
		public DateTime OccDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "attack_count" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long AttackCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "revenge_dungeon" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long RevengeDungeon { get; set; }

	}
}
