using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("bak_dnf_item_info", TableDescription = "")]
	public class BakDnfItemInfo
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "it_no" , ColumnDataType = "mediumint", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int ItNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "it_name" , ColumnDataType = "varchar", Length = 25, ColumnDescription = "")]
		public string ItName { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "it_eng_name" , ColumnDataType = "varchar", Length = 50, ColumnDescription = "")]
		public string ItEngName { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "it_explain" , ColumnDataType = "varchar", Length = 60, ColumnDescription = "")]
		public string ItExplain { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "master_type" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long MasterType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "sub_type" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short SubType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "job" , ColumnDataType = "varchar", Length = 12, ColumnDescription = "")]
		public string Job { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "class" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Class { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "revert" , ColumnDataType = "varchar", Length = 5, ColumnDescription = "")]
		public string Revert { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "level" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Level { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "skill" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Skill { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "create_ratio" , ColumnDataType = "float", DefaultValue = "0", ColumnDescription = "")]
		public float CreateRatio { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "rarity" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Rarity { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "weight" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Weight { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "price" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Price { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "cash" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Cash { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "medal" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Medal { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "durability" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Durability { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "cooltime" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Cooltime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "hp_max" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short HpMax { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mp_max" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short MpMax { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "phy_att" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short PhyAtt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "phy_def" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short PhyDef { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mag_att" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short MagAtt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mag_def" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short MagDef { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "equip_phy_att" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short EquipPhyAtt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "equip_phy_def" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short EquipPhyDef { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "equip_mag_att" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short EquipMagAtt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "equip_mag_def" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short EquipMagDef { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ref_fire" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long RefFire { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ref_water" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long RefWater { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ref_dark" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long RefDark { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ref_light" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long RefLight { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ref_all" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long RefAll { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ref_slow" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long RefSlow { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ref_freeze" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long RefFreeze { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ref_poison" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long RefPoison { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ref_stun" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long RefStun { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ref_cus" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long RefCus { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ref_blind" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long RefBlind { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ref_lite" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long RefLite { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ref_ston" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long RefSton { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ref_sleep" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long RefSleep { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ref_deekement" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long RefDeekement { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ref_deadlystrike" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long RefDeadlystrike { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ref_bleeding" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long RefBleeding { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ref_confuse" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long RefConfuse { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ref_hold" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long RefHold { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ref_all_stat" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long RefAllStat { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ref_pierce" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short RefPierce { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ref_stuck" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short RefStuck { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "inven_max" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short InvenMax { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "hp_regenrate" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short HpRegenrate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mp_regenrate" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short MpRegenrate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mov_speed" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short MovSpeed { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "att_speed" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short AttSpeed { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "quest" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Quest { get; set; }

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
		[SugarColumn(ColumnName = "att_element" , ColumnDataType = "enum", DefaultValue = "Void", ColumnDescription = "")]
		public int AttElement { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "att_active_status" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short AttActiveStatus { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "att_active_status_ratio" , ColumnDataType = "float", DefaultValue = "0", ColumnDescription = "")]
		public float AttActiveStatusRatio { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "att_active_status_pow" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short AttActiveStatusPow { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "att_backforce" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short AttBackforce { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "att_upforce" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short AttUpforce { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "att_hp_drain" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long AttHpDrain { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "att_mp_drain" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long AttMpDrain { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "criticalhit_rate" , ColumnDataType = "float", DefaultValue = "0", ColumnDescription = "")]
		public float CriticalhitRate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "stuck_rate" , ColumnDataType = "float", DefaultValue = "0", ColumnDescription = "")]
		public float StuckRate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "att_defenseIgnore" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long AttDefenseIgnore { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "skill_levelup" , ColumnDataType = "varchar", Length = 25, ColumnDescription = "")]
		public string SkillLevelup { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "set_type" , ColumnDataType = "enum", DefaultValue = "n", ColumnDescription = "")]
		public int SetType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "url" , ColumnDataType = "varchar", Length = 64, ColumnDescription = "")]
		public string Url { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "jewel_type" , ColumnDataType = "varchar", Length = 5, ColumnDescription = "")]
		public string JewelType { get; set; } = string.Empty;

	}
}
