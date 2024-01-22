using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("charac_kill_monster_info", TableDescription = "")]
	public class CharacKillMonsterInfo
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "boss_info" , ColumnDataType = "blob", ColumnDescription = "")]
		public byte[] BossInfo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "named_info" , ColumnDataType = "blob", ColumnDescription = "")]
		public byte[] NamedInfo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "apc_boss_info" , ColumnDataType = "blob", ColumnDescription = "")]
		public byte[] ApcBossInfo { get; set; }

	}
}
