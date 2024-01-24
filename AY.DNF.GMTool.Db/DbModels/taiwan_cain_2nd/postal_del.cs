using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain_2nd
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("postal_del", TableDescription = "")]
	public class PostalDel
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "sdate" , ColumnDataType = "date", IsPrimaryKey = true, DefaultValue = "0000-00-00", ColumnDescription = "")]
		public DateTime Sdate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "postal_id" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int PostalId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "occ_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime OccTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "send_charac_no" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int SendCharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "send_charac_name" , ColumnDataType = "varchar", Length = 20, ColumnDescription = "")]
		public string SendCharacName { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "receive_charac_no" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int ReceiveCharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "item_id" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int ItemId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "add_info" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int AddInfo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "endurance" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short Endurance { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "upgrade" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Upgrade { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "amplify_option" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long AmplifyOption { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "amplify_value" , ColumnDataType = "mediumint", DefaultValue = "0", ColumnDescription = "")]
		public int AmplifyValue { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gold" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Gold { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "receive_time" , ColumnDataType = "datetime", DefaultValue = "0000-00-00 00:00:00", ColumnDescription = "")]
		public DateTime ReceiveTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "delete_flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long DeleteFlag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "avata_flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long AvataFlag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "unlimit_flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long UnlimitFlag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "seal_flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long SealFlag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "creature_flag" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long CreatureFlag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "postal" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int Postal { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "letter_id" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int LetterId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "extend_info" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int ExtendInfo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ipg_db_id" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long IpgDbId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ipg_transaction_id" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int IpgTransactionId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "ipg_nexon_id" , ColumnDataType = "varchar", Length = 32, ColumnDescription = "")]
		public string IpgNexonId { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "auction_id" , ColumnDataType = "bigint", DefaultValue = "0", ColumnDescription = "")]
		public long AuctionId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "random_option" , ColumnDataType = "varbinary", ColumnDescription = "")]
		public byte[] RandomOption { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "seperate_upgrade" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long SeperateUpgrade { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "type" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long Type { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "item_guid" , ColumnDataType = "varbinary", ColumnDescription = "")]
		public byte[] ItemGuid { get; set; }

	}
}
