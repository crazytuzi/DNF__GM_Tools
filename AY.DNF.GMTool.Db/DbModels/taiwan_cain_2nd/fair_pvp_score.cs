using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain_2nd
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("fair_pvp_score", TableDescription = "")]
	public class FairPvpScore
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "private_win" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int PrivateWin { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "private_lose" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int PrivateLose { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "private_draw" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int PrivateDraw { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "relay_battle_win" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int RelayBattleWin { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "relay_battle_lose" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int RelayBattleLose { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "relay_battle_draw" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int RelayBattleDraw { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "relay_battle_2kill" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int RelayBattle2kill { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "successive_win" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int SuccessiveWin { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "job_score" , ColumnDataType = "blob", IsNullable = true, ColumnDescription = "")]
		public byte[]? JobScore { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "relay_battle_3kill" , ColumnDataType = "int", IsNullable = true, DefaultValue = "0", ColumnDescription = "")]
		public int? RelayBattle3kill { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "max_successive_win" , ColumnDataType = "int", IsNullable = true, DefaultValue = "0", ColumnDescription = "")]
		public int? MaxSuccessiveWin { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "daily_play_count" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int DailyPlayCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "last_play_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime LastPlayTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "pvp_mission_info" , ColumnDataType = "blob", IsNullable = true, ColumnDescription = "")]
		public byte[]? PvpMissionInfo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "give_item" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long GiveItem { get; set; }

	}
}
