using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("charac_view", TableDescription = "")]
	public class CharacView
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int MId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "info" , ColumnDataType = "blob", ColumnDescription = "")]
		public byte[] Info { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "slot_effect_count" , ColumnDataType = "tinyint", DefaultValue = "18", ColumnDescription = "")]
		public long SlotEffectCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_slot_limit" , ColumnDataType = "tinyint", DefaultValue = "18", ColumnDescription = "")]
		public long CharacSlotLimit { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "hash_key" , ColumnDataType = "varchar", Length = 32, ColumnDescription = "")]
		public string HashKey { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_count" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long CharacCount { get; set; }

	}
}
