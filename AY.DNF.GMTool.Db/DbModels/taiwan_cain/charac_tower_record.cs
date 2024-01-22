using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("charac_tower_record", TableDescription = "")]
	public class CharacTowerRecord
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "tower_index" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long TowerIndex { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "member_info_1" , ColumnDataType = "char", Length = 32, ColumnDescription = "")]
		public string MemberInfo1 { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "stage_1" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Stage1 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_time_1" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int PlayTime1 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "occ_time_1" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime OccTime1 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "member_info_2" , ColumnDataType = "char", Length = 64, ColumnDescription = "")]
		public string MemberInfo2 { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "stage_2" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Stage2 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_time_2" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int PlayTime2 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "occ_time_2" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime OccTime2 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "member_info_3" , ColumnDataType = "char", Length = 96, ColumnDescription = "")]
		public string MemberInfo3 { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "stage_3" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Stage3 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_time_3" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int PlayTime3 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "occ_time_3" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime OccTime3 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "member_info_4" , ColumnDataType = "char", Length = 128, ColumnDescription = "")]
		public string MemberInfo4 { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "stage_4" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Stage4 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_time_4" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int PlayTime4 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "occ_time_4" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime OccTime4 { get; set; }

	}
}
