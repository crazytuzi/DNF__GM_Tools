using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain_2nd
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("user_items_work", TableDescription = "")]
	public class UserItemsWork
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ui_id" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int UiId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "slot" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Slot { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "it_id" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int ItId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "expire_date" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime ExpireDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "obtain_from" , ColumnDataType = "tinyint", IsNullable = true, ColumnDescription = "")]
		public long? ObtainFrom { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "reg_date" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime RegDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ipg_agency_no" , ColumnDataType = "varchar", Length = 32, ColumnDescription = "")]
		public string IpgAgencyNo { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ability_no" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long AbilityNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "stat" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Stat { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "clear_avatar_id" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int ClearAvatarId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "jewel_socket" , ColumnDataType = "blob", ColumnDescription = "")]
		public byte[] JewelSocket { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "item_lock_key" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long ItemLockKey { get; set; }

	}
}
