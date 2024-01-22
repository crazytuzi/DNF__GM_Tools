using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("charac_blood_best_record", TableDescription = "")]
	public class CharacBloodBestRecord
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "dungeon_index" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int DungeonIndex { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "best_round" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long BestRound { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "best_time" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int BestTime { get; set; }

	}
}
