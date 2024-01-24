using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain_2nd
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("inventory", TableDescription = "")]
	public class Inventory
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "money" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Money { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "coin" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Coin { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "inventory" , ColumnDataType = "blob", ColumnDescription = "")]
		public byte[] Inventory_ { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "equipslot" , ColumnDataType = "blob", ColumnDescription = "")]
		public byte[] Equipslot { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "pay_coin" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int PayCoin { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "event_coin" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int EventCoin { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "creature" , ColumnDataType = "blob", ColumnDescription = "")]
		public byte[] Creature { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "creature_flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long CreatureFlag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "katagaki" , ColumnDataType = "blob", ColumnDescription = "")]
		public byte[] Katagaki { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "inventory_capacity" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int InventoryCapacity { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "avatar_coin" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int AvatarCoin { get; set; }

	}
}
