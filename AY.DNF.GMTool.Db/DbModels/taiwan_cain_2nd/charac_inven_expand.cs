using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain_2nd
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("charac_inven_expand", TableDescription = "")]
	public class CharacInvenExpand
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "cargo" , ColumnDataType = "blob", ColumnDescription = "")]
		public byte[] Cargo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "cargo_capacity" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int CargoCapacity { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "jewel" , ColumnDataType = "blob", ColumnDescription = "")]
		public byte[] Jewel { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "current_equipslot" , ColumnDataType = "char", Length = 1, ColumnDescription = "")]
		public string CurrentEquipslot { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "switch_equipslot" , ColumnDataType = "blob", ColumnDescription = "")]
		public byte[] SwitchEquipslot { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "expand_equipslot" , ColumnDataType = "blob", ColumnDescription = "")]
		public byte[] ExpandEquipslot { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "redeem_info" , ColumnDataType = "blob", ColumnDescription = "")]
		public byte[] RedeemInfo { get; set; }

	}
}
