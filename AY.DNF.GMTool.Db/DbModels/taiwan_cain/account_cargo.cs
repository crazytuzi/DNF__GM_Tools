using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("account_cargo", TableDescription = "")]
	public class AccountCargo
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "bigint", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public long MId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "money" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Money { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "capacity" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Capacity { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "cargo" , ColumnDataType = "blob", ColumnDescription = "")]
		public byte[] Cargo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "occ_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime OccTime { get; set; }

	}
}
