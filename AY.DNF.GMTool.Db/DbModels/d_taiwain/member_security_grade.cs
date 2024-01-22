using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("member_security_grade", TableDescription = "")]
	public class MemberSecurityGrade
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int MId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "last_visit_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime LastVisitTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "pass_fail_cnt" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int PassFailCnt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "last_vaccine_date" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime LastVaccineDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "last_window_date" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime LastWindowDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "goblin_pass_mod" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime GoblinPassMod { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "goblin_fail_cnt" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int GoblinFailCnt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "security_card_reg" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime SecurityCardReg { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "security_card_fail_cnt" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int SecurityCardFailCnt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_opt_reg" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime MOptReg { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "pc_opt_reg" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime PcOptReg { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "black_ip_try_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime BlackIpTryTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "linear_pass_fail_cnt" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int LinearPassFailCnt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "last_pass_fail_time" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int LastPassFailTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "last_check_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime LastCheckTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "pass_modify_check" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime PassModifyCheck { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "member_pc_reg" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime MemberPcReg { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gatekeeper_otp_reg" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime GatekeeperOtpReg { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "goblin_validity_time" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int GoblinValidityTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "security_card_validity_time" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int SecurityCardValidityTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "validity_ip" , ColumnDataType = "varchar", Length = 15, ColumnDescription = "")]
		public string ValidityIp { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "cargopad_status" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long CargopadStatus { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "cargopad_mod" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime CargopadMod { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "cargopad_validity_time" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int CargopadValidityTime { get; set; }

	}
}
