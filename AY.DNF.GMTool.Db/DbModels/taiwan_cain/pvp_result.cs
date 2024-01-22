using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("pvp_result", TableDescription = "")]
	public class PvpResult
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "win" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Win { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "lose" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Lose { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "pvp_point" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int PvpPoint { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "pvp_grade" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int PvpGrade { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "pvp_grade_ext" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long PvpGradeExt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "avg_kill_count" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int AvgKillCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "avg_buf_count" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int AvgBufCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "avg_debuf_count" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int AvgDebufCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "avg_heal_count" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int AvgHealCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "avg_counter_count" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int AvgCounterCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "avg_back_atk_count" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int AvgBackAtkCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "avg_union_hit_count" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int AvgUnionHitCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "avg_overkill_count" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int AvgOverkillCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "avg_aerial_count" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int AvgAerialCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "avg_combo_count" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int AvgComboCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "avg_attacked_count" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int AvgAttackedCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "avg_deal_damage" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int AvgDealDamage { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "avg_technic" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int AvgTechnic { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "avg_style" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int AvgStyle { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "avg_hit_penalty" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int AvgHitPenalty { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "pvp_count" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int PvpCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "win_point" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int WinPoint { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "last_play_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime LastPlayTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_count" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int PlayCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_time" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int PlayTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "pvp_grade_ext_update_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime PvpGradeExtUpdateTime { get; set; }

	}
}
