using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain_2nd
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("charac_advance_altar_item_desc", TableDescription = "")]
	public class CharacAdvanceAltarItemDesc
	{
		/// <summary>
		/// ｺｯｽﾅｸ?ｺﾅﾍ ｾﾆﾀﾌｵ
		/// </summary>
		[SugarColumn(ColumnName = "ridable_id" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "ｺｯｽﾅｸ?ｺﾅﾍ ｾﾆﾀﾌｵ")]
		public int RidableId { get; set; }

		/// <summary>
		/// ｾﾆﾀﾌﾅﾛﾅｸﾀﾔ 0:ﾀｯｴﾖ, 1:ｽｺﾅｳ, 2:ﾅｸｿ
		/// </summary>
		[SugarColumn(ColumnName = "item_type" , ColumnDataType = "smallint", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "ｾﾆﾀﾌﾅﾛﾅｸﾀﾔ 0:ﾀｯｴﾖ, 1:ｽｺﾅｳ, 2:ﾅｸｿ")]
		public short ItemType { get; set; }

		/// <summary>
		/// ｾﾆﾀﾌﾅﾛｾﾆﾀﾌｵ
		/// </summary>
		[SugarColumn(ColumnName = "item_id" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "ｾﾆﾀﾌﾅﾛｾﾆﾀﾌｵ")]
		public int ItemId { get; set; }

		/// <summary>
		/// ｾﾆﾀﾌﾅﾛｼｳｸ
		/// </summary>
		[SugarColumn(ColumnName = "item_desc" , ColumnDataType = "blob", ColumnDescription = "ｾﾆﾀﾌﾅﾛｼｳｸ")]
		public byte[] ItemDesc { get; set; }

	}
}
