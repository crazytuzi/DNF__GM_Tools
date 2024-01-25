using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("charac_info", TableDescription = "")]
	public class CharacInfo
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int MId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_name" , ColumnDataType = "varchar", Length = 20, ColumnDescription = "")]
		public string CharacName { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "village" , ColumnDataType = "tinyint", DefaultValue = "1", ColumnDescription = "")]
		public long Village { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "job" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public int  Job { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "lev" , ColumnDataType = "tinyint", DefaultValue = "1", ColumnDescription = "")]
		public long Lev { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "exp" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Exp { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "grow_type" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long GrowType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "HP" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long HP { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "maxHP" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short MaxHP { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "maxMP" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short MaxMP { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "phy_attack" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short PhyAttack { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "phy_defense" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short PhyDefense { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mag_attack" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short MagAttack { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mag_defense" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short MagDefense { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "element_resist" , ColumnDataType = "tinyblob", ColumnDescription = "")]
		public byte[] ElementResist { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "spec_property" , ColumnDataType = "tinyblob", ColumnDescription = "")]
		public byte[] SpecProperty { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "inven_weight" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int InvenWeight { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "hp_regen" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short HpRegen { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mp_regen" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short MpRegen { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "move_speed" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short MoveSpeed { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "attack_speed" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short AttackSpeed { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "cast_speed" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short CastSpeed { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "hit_recovery" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short HitRecovery { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "jump" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Jump { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_weight" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int CharacWeight { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "fatigue" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Fatigue { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "max_fatigue" , ColumnDataType = "smallint", DefaultValue = "70", ColumnDescription = "")]
		public short MaxFatigue { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "premium_fatigue" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short PremiumFatigue { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "max_premium_fatigue" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short MaxPremiumFatigue { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "create_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime CreateTime { get; set; }

		///// <summary>
		///// 
		///// </summary>
		//[SugarColumn(ColumnName = "last_play_time", ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		//public object LastPlayTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "dungeon_clear_point" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int DungeonClearPoint { get; set; }

		///// <summary>
		///// 
		///// </summary>
		//[SugarColumn(ColumnName = "delete_time", ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		//public object? DeleteTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "delete_flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long DeleteFlag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "guild_id" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int GuildId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "guild_right" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long GuildRight { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "member_flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long MemberFlag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "sex" , ColumnDataType = "tinyint", DefaultValue = "1", ColumnDescription = "")]
		public long Sex { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "expert_job" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long ExpertJob { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "skill_tree_index" , ColumnDataType = "tinyint", DefaultValue = "-1", ColumnDescription = "")]
		public long SkillTreeIndex { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "link_charac_no" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int LinkCharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "event_charac_level" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long EventCharacLevel { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "guild_secede" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long GuildSecede { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "start_time" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int StartTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "finish_time" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int FinishTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "competition_area" , ColumnDataType = "tinyint", DefaultValue = "-1", ColumnDescription = "")]
		public long CompetitionArea { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "competition_period" , ColumnDataType = "tinyint", DefaultValue = "-1", ColumnDescription = "")]
		public long CompetitionPeriod { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mercenary_start_time" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int MercenaryStartTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mercenary_finish_time" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int MercenaryFinishTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mercenary_area" , ColumnDataType = "tinyint", DefaultValue = "-1", ColumnDescription = "")]
		public long MercenaryArea { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mercenary_period" , ColumnDataType = "tinyint", DefaultValue = "-1", ColumnDescription = "")]
		public long MercenaryPeriod { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "VIP" , ColumnDataType = "varchar", Length = 255, ColumnDescription = "")]
		public string VIP { get; set; } = string.Empty;

	}
}
