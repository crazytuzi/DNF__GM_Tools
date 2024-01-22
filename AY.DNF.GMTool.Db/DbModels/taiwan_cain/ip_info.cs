using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("ip_info", TableDescription = "")]
	public class IpInfo
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "no" , ColumnDataType = "int", IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "")]
		public int No { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int MId { get; set; }

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

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "occ_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime OccTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ip_check" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long IpCheck { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "vendor_no" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int VendorNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "speed_no" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int SpeedNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "start_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime StartTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "end_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime EndTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charge_flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long ChargeFlag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "settle_no" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int SettleNo { get; set; }

	}
}
