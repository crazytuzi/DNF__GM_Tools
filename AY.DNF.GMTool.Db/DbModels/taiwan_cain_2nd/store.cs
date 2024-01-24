using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain_2nd
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("store", TableDescription = "")]
	public class Store
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "store" , ColumnDataType = "blob", ColumnDescription = "")]
		public byte[] Store_ { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "use_doll" , ColumnDataType = "tinyint", IsNullable = true, DefaultValue = "0", ColumnDescription = "")]
		public long? UseDoll { get; set; }

	}
}
