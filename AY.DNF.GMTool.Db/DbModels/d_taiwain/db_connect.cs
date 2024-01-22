using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("db_connect", TableDescription = "")]
	public class DbConnect
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "no" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int No { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "host_name" , ColumnDataType = "varchar", Length = 50, IsNullable = true, ColumnDescription = "")]
		public string? HostName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "db_server_group" , ColumnDataType = "tinyint", IsNullable = true, ColumnDescription = "")]
		public long? DbServerGroup { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "db_type" , ColumnDataType = "int", ColumnDescription = "")]
		public int DbType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "db_name" , ColumnDataType = "varchar", Length = 50, ColumnDescription = "")]
		public string DbName { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "db_ip" , ColumnDataType = "varchar", Length = 16, ColumnDescription = "")]
		public string DbIp { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "db_port" , ColumnDataType = "int", ColumnDescription = "")]
		public int DbPort { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "db_userid" , ColumnDataType = "varchar", Length = 20, ColumnDescription = "")]
		public string DbUserid { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "db_passwd" , ColumnDataType = "varchar", Length = 50, ColumnDescription = "")]
		public string DbPasswd { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "comments" , ColumnDataType = "varchar", Length = 255, IsNullable = true, ColumnDescription = "")]
		public string? Comments { get; set; }

	}
}
