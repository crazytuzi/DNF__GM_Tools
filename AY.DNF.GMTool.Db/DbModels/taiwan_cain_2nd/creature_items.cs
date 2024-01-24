using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain_2nd
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("creature_items", TableDescription = "")]
	public class CreatureItems
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ui_id" , ColumnDataType = "int", IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "")]
		public int UiId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "slot" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Slot { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "it_id" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int ItId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "reg_date" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime RegDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "name" , ColumnDataType = "varchar", Length = 12, ColumnDescription = "")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "stomach" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Stomach { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "exp" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Exp { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "endurance" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Endurance { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "creature_type" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long CreatureType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "no_charge" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long NoCharge { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "stat" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Stat { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "item_lock_key" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long ItemLockKey { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ipg_agency_no" , ColumnDataType = "varchar", Length = 32, ColumnDescription = "")]
		public string IpgAgencyNo { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "expire_date" , ColumnDataType = "datetime", DefaultValue = "9999-12-31 23:59:59", ColumnDescription = "")]
		public DateTime ExpireDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "delete_date" , ColumnDataType = "datetime", DefaultValue = "9999-12-31 23:59:59", ColumnDescription = "")]
		public DateTime DeleteDate { get; set; }

	}
}
