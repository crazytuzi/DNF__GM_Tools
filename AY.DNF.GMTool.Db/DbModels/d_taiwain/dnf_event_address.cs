using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("dnf_event_address", TableDescription = "")]
	public class DnfEventAddress
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "event_id" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int EventId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int MId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "occ_date" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime OccDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "zipcode" , ColumnDataType = "varchar", Length = 7, ColumnDescription = "")]
		public string Zipcode { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "address" , ColumnDataType = "varchar", Length = 150, ColumnDescription = "")]
		public string Address { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "phone_no" , ColumnDataType = "varchar", Length = 15, ColumnDescription = "")]
		public string PhoneNo { get; set; } = string.Empty;

	}
}
