using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("charac_quest_shop", TableDescription = "")]
	public class CharacQuestShop
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "qp" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Qp { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "max_hp" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short MaxHp { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "max_mp" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short MaxMp { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "psy_attack" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short PsyAttack { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "psy_defense" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short PsyDefense { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mag_attack" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short MagAttack { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mag_defence" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short MagDefence { get; set; }

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
		[SugarColumn(ColumnName = "all_element_resist" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short AllElementResist { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "fire_element_resist" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short FireElementResist { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "water_element_resist" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short WaterElementResist { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "light_element_resist" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short LightElementResist { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "dark_element_resist" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short DarkElementResist { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "all_element_attack" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short AllElementAttack { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "fire_element_attack" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short FireElementAttack { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "water_element_attack" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short WaterElementAttack { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "light_element_attack" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short LightElementAttack { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "dark_element_attack" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short DarkElementAttack { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "psy_critical" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short PsyCritical { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mag_critical" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short MagCritical { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "good_hit" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short GoodHit { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "evasion" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Evasion { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "hit_recovery" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short HitRecovery { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "init_count" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short InitCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "separate_psy_mag_attack" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short SeparatePsyMagAttack { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "quest_piece" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short QuestPiece { get; set; }

	}
}
