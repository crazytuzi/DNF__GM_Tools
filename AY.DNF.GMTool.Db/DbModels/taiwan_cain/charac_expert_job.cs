using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("charac_expert_job", TableDescription = "")]
	public class CharacExpertJob
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "expert_job_giveup_cnt" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long ExpertJobGiveupCnt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "expert_job_info" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int ExpertJobInfo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "expert_job_info_ex" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int ExpertJobInfoEx { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "recipe" , ColumnDataType = "blob", ColumnDescription = "")]
		public byte[] Recipe { get; set; }

	}
}
