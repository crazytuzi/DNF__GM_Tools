using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("charac_stat", TableDescription = "")]
	public class CharacStat
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "village" , ColumnDataType = "tinyint", DefaultValue = "1", ColumnDescription = "")]
		public long Village { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "exp" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Exp { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "HP" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long HP { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "fatigue" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Fatigue { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "used_fatigue" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short UsedFatigue { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "premium_fatigue" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short PremiumFatigue { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "dungeon_clear_point" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int DungeonClearPoint { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "last_play_time", ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime LastPlayTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "forbidden_to_play" , ColumnDataType = "char", Length = 1, ColumnDescription = "")]
		public string ForbiddenToPlay { get; set; } = string.Empty;

		///// <summary>
		///// 
		///// </summary>
		//[SugarColumn(ColumnName = "forbidden_due_to" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		//public object? ForbiddenDueTo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "tutorial_flag" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int TutorialFlag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "trade_gold_total" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int TradeGoldTotal { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "trade_gold_total_billion" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short TradeGoldTotalBillion { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "trade_gold_daily" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int TradeGoldDaily { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "dungeon_map_pass_cnt" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int DungeonMapPassCnt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "dungeon_map_help_pass_cnt" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int DungeonMapHelpPassCnt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "help_abuse_point" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int HelpAbusePoint { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "chaos_point" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int ChaosPoint { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "chaos_exp" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int ChaosExp { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "chaos_mode_count" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int ChaosModeCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "chaos_kill_count" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int ChaosKillCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "chaos_die_count" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int ChaosDieCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "chaos_die_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime ChaosDieTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "chaos_kill_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime ChaosKillTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "assault_count" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int AssaultCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "luck_point" , ColumnDataType = "int", DefaultValue = "5000", ColumnDescription = "")]
		public int LuckPoint { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "dungeon_play_count" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int DungeonPlayCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "help_abuse_ratio" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int HelpAbuseRatio { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "help_abuse_exp" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int HelpAbuseExp { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "expert_job_exp" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int ExpertJobExp { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "fatigue_battery_charging" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int FatigueBatteryCharging { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "escalade_tutorial_flag" , ColumnDataType = "varchar", Length = 32, ColumnDescription = "")]
		public string EscaladeTutorialFlag { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "power_war_point" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short PowerWarPoint { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "power_war_assault_count" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int PowerWarAssaultCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "power_war_assault_victory_count" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int PowerWarAssaultVictoryCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "fatigue_grownup_buff" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int FatigueGrownupBuff { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "village_prev" , ColumnDataType = "tinyint", DefaultValue = "1", ColumnDescription = "")]
		public long VillagePrev { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "last_play_time_powerwar" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime LastPlayTimePowerwar { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "emotion" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Emotion { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "add_slot_flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long AddSlotFlag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "member_dungeon_flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long MemberDungeonFlag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "open_flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long OpenFlag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "member_bonus_fatigue" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long MemberBonusFatigue { get; set; }

		///// <summary>
		///// 
		///// </summary>
		//[SugarColumn(ColumnName = "birthday_effect_time" , ColumnDataType = "datetime", IsNullable = true, DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		//public DateTime? BirthdayEffectTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "visible_flags" , ColumnDataType = "tinyint", DefaultValue = "2", ColumnDescription = "")]
		public long VisibleFlags { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "add_equipslot_flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long AddEquipslotFlag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "channel_equipslot_switch" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long ChannelEquipslotSwitch { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "expand_equipslot_switch" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long ExpandEquipslotSwitch { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "growth_power_reward" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long GrowthPowerReward { get; set; }

		///// <summary>
		///// 
		///// </summary>
		//[SugarColumn(ColumnName = "chaos_respon_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		//public DateTime ChaosResponTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "last_play_dungeon_index" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int LastPlayDungeonIndex { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "total_play_time" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int TotalPlayTime { get; set; }

	}
}
