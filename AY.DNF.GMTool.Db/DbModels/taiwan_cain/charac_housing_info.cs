using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("charac_housing_info", TableDescription = "")]
	public class CharacHousingInfo
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "installed" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Installed { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "decoration_inven" , ColumnDataType = "binary", DefaultValue = "                                                                                                                                                ", ColumnDescription = "")]
		public byte[] DecorationInven { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "version" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Version { get; set; }

	}
}
