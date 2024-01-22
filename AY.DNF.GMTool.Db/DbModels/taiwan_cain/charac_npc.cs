using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("charac_npc", TableDescription = "")]
	public class CharacNpc
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "npc_cnt" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long NpcCnt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "npc_data" , ColumnDataType = "blob", ColumnDescription = "")]
		public byte[] NpcData { get; set; }

	}
}
