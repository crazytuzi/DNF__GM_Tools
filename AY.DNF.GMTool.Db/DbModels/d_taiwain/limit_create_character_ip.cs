using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("limit_create_character_ip", TableDescription = "")]
	public class LimitCreateCharacterIp
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ip" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int Ip { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ip_str" , ColumnDataType = "char", Length = 16, ColumnDescription = "")]
		public string IpStr { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "last_access_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime LastAccessTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "count" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Count { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "last_access_mid" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int LastAccessMid { get; set; }

	}
}
