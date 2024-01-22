using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("game_channel", TableDescription = "")]
	public class GameChannel
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_no" , ColumnDataType = "int", IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "")]
		public int GcNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_now" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short GcNow { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_ip" , ColumnDataType = "varchar", Length = 64, ColumnDescription = "")]
		public string GcIp { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_port" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short GcPort { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_max" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short GcMax { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_game" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long GcGame { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_channel" , ColumnDataType = "varchar", Length = 32, ColumnDescription = "")]
		public string GcChannel { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_ch_group" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short GcChGroup { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_channeltype" , ColumnDataType = "varchar", Length = 25, ColumnDescription = "")]
		public string GcChanneltype { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_up_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime GcUpTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_swordman_cnt" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short GcSwordmanCnt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_fighter_cnt" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short GcFighterCnt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_gunner_cnt" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short GcGunnerCnt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_mage_cnt" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short GcMageCnt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_priest_cnt" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short GcPriestCnt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_at_gunner_cnt" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short GcAtGunnerCnt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_thief_cnt" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short GcThiefCnt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_hangame" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short GcHangame { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_nexon" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short GcNexon { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_type" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long GcType { get; set; }

	}
}
