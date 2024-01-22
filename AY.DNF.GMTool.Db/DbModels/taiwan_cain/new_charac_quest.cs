using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("new_charac_quest", TableDescription = "")]
	public class NewCharacQuest
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "clear_quest" , ColumnDataType = "blob", ColumnDescription = "")]
		public byte[] ClearQuest { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "quest_notify" , ColumnDataType = "blob", ColumnDescription = "")]
		public byte[] QuestNotify { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_1" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Play1 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_1_trigger" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Play1Trigger { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_2" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Play2 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_2_trigger" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Play2Trigger { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_3" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Play3 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_3_trigger" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Play3Trigger { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_4" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Play4 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_4_trigger" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Play4Trigger { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_5" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Play5 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_5_trigger" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Play5Trigger { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_6" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Play6 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_6_trigger" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Play6Trigger { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_7" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Play7 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_7_trigger" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Play7Trigger { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_8" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Play8 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_8_trigger" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Play8Trigger { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_9" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Play9 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_9_trigger" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Play9Trigger { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_10" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Play10 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_10_trigger" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Play10Trigger { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "auto_clear" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long AutoClear { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_11" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Play11 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_11_trigger" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Play11Trigger { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_12" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Play12 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_12_trigger" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Play12Trigger { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_13" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Play13 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_13_trigger" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Play13Trigger { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_14" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Play14 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_14_trigger" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Play14Trigger { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_15" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Play15 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_15_trigger" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Play15Trigger { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_16" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Play16 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_16_trigger" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Play16Trigger { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_17" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Play17 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_17_trigger" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Play17Trigger { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_18" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Play18 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_18_trigger" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Play18Trigger { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_19" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Play19 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_19_trigger" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Play19Trigger { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_20" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Play20 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "play_20_trigger" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Play20Trigger { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "urgentQuestIndex" , ColumnDataType = "smallint", DefaultValue = "-1", ColumnDescription = "")]
		public short UrgentQuestIndex { get; set; }

	}
}
