using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("under_billing_confirm", TableDescription = "")]
	public class UnderBillingConfirm
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int MId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "parent_name" , ColumnDataType = "varchar", Length = 4, ColumnDescription = "")]
		public string ParentName { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "parent_jumin" , ColumnDataType = "bigint", DefaultValue = "0", ColumnDescription = "")]
		public long ParentJumin { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "parent_phone1" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long ParentPhone1 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "parent_phone2" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short ParentPhone2 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "parent_phone3" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short ParentPhone3 { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "parent_email" , ColumnDataType = "varchar", Length = 25, ColumnDescription = "")]
		public string ParentEmail { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "parent_consent_type" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long ParentConsentType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "create_date" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int CreateDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "consent_date" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int ConsentDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "consent_yn" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long ConsentYn { get; set; }

	}
}
