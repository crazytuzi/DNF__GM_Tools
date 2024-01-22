using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("item_making_skill_info", TableDescription = "")]
	public class ItemMakingSkillInfo
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "weapon" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Weapon { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "cloth" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Cloth { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "leather" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Leather { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "light_armor" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short LightArmor { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "heavy_armor" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short HeavyArmor { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "plate" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Plate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "amulet" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Amulet { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "wrist" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Wrist { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ring" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Ring { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "support" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Support { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "magic_stone" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short MagicStone { get; set; }

	}
}
