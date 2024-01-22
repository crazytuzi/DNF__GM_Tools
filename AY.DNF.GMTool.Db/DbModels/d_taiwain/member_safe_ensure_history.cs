using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("member_safe_ensure_history", TableDescription = "")]
	public class MemberSafeEnsureHistory
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mod_flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long ModFlag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mod_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime ModTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int MId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "occ_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime OccTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "mobile_no" , ColumnDataType = "varchar", Length = 15, ColumnDescription = "")]
		public string MobileNo { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "service_flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long ServiceFlag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "type1_flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Type1Flag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "type2_flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Type2Flag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "expire_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime ExpireTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "settle_id" , ColumnDataType = "varchar", Length = 18, ColumnDescription = "")]
		public string SettleId { get; set; } = string.Empty;

	}
}
