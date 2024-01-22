using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("limited_shop_manager", TableDescription = "")]
	public class LimitedShopManager
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "no" , ColumnDataType = "int", IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "")]
		public int No { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "occ_time" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int OccTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "server_id" , ColumnDataType = "tinyint", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public long ServerId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ipg_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int IpgNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "item_no" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int ItemNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "item_cnt" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int ItemCnt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "cera_price" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int CeraPrice { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gold_price" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int GoldPrice { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "avatar_period_type" , ColumnDataType = "tinyint", DefaultValue = "-1", ColumnDescription = "")]
		public long AvatarPeriodType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "total_cnt" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int TotalCnt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "sell_cnt" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int SellCnt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "restrict_no" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int RestrictNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "start_time" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int StartTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "end_time" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int EndTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "real_end_time" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int RealEndTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "npc_idx" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int NpcIdx { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "cond_charac_job" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long CondCharacJob { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "cond_lev_begin" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long CondLevBegin { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "cond_lev_end" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long CondLevEnd { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "cond_acc_create_time_begin" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int CondAccCreateTimeBegin { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "cond_acc_create_time_end" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int CondAccCreateTimeEnd { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "cond_cha_create_time_begin" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int CondChaCreateTimeBegin { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "cond_cha_create_time_end" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int CondChaCreateTimeEnd { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "status_flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long StatusFlag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "title" , ColumnDataType = "varchar", Length = 50, ColumnDescription = "")]
		public string Title { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "range_section" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long RangeSection { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "reason_etc" , ColumnDataType = "varchar", Length = 200, ColumnDescription = "")]
		public string ReasonEtc { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "reason_stop" , ColumnDataType = "varchar", Length = 200, ColumnDescription = "")]
		public string ReasonStop { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "pos_flag" , ColumnDataType = "char", Length = 1, DefaultValue = "0", ColumnDescription = "")]
		public string PosFlag { get; set; } = string.Empty;

	}
}
