using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
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
		[SugarColumn(ColumnName = "district" , ColumnDataType = "varchar", Length = 20, ColumnDescription = "")]
		public string District { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "firm_name" , ColumnDataType = "varchar", Length = 50, ColumnDescription = "")]
		public string FirmName { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "telephone" , ColumnDataType = "varchar", Length = 20, ColumnDescription = "")]
		public string Telephone { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "address" , ColumnDataType = "varchar", Length = 150, ColumnDescription = "")]
		public string Address { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "leader" , ColumnDataType = "varchar", Length = 30, ColumnDescription = "")]
		public string Leader { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ip" , ColumnDataType = "varchar", Length = 11, ColumnDescription = "")]
		public string Ip { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "start_ip" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long StartIp { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "end_ip" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long EndIp { get; set; }

	}
}
