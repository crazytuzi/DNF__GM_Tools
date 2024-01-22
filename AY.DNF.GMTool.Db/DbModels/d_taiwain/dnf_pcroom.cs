using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("dnf_pcroom", TableDescription = "")]
	public class DnfPcroom
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ip_no" , ColumnDataType = "int", IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "")]
		public int IpNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "district" , ColumnDataType = "varchar", Length = 10, ColumnDescription = "")]
		public string District { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "firm_name" , ColumnDataType = "varchar", Length = 25, ColumnDescription = "")]
		public string FirmName { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "telephone" , ColumnDataType = "varchar", Length = 10, ColumnDescription = "")]
		public string Telephone { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "address" , ColumnDataType = "varchar", Length = 75, ColumnDescription = "")]
		public string Address { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "leader" , ColumnDataType = "varchar", Length = 15, ColumnDescription = "")]
		public string Leader { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "start_ip" , ColumnDataType = "varchar", Length = 7, ColumnDescription = "")]
		public string StartIp { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "end_ip" , ColumnDataType = "varchar", Length = 7, ColumnDescription = "")]
		public string EndIp { get; set; } = string.Empty;

	}
}
