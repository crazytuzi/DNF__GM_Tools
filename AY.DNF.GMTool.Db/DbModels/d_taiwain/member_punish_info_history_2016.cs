using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("member_punish_info_history_2016", TableDescription = "")]
	public class MemberPunishInfoHistory2016
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
		[SugarColumn(ColumnName = "punish_type" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int PunishType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "occ_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime OccTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "punish_value" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int PunishValue { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "apply_flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long ApplyFlag { get; set; }

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
		[SugarColumn(ColumnName = "admin_id" , ColumnDataType = "varchar", Length = 25, IsNullable = true, ColumnDescription = "")]
		public string? AdminId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "reason" , ColumnDataType = "varchar", Length = 100, IsNullable = true, ColumnDescription = "")]
		public string? Reason { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "is_kicked" , ColumnDataType = "tinyint", IsNullable = true, ColumnDescription = "")]
		public long? IsKicked { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "first_ssn" , ColumnDataType = "varchar", Length = 32, IsNullable = true, ColumnDescription = "")]
		public string? FirstSsn { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "second_ssn" , ColumnDataType = "varchar", Length = 32, IsNullable = true, ColumnDescription = "")]
		public string? SecondSsn { get; set; }

	}
}
