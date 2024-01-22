using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("auction_history", TableDescription = "")]
	public class AuctionHistory
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "auction_id" , ColumnDataType = "bigint", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public long AuctionId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "start_time" , ColumnDataType = "datetime", IsNullable = true, ColumnDescription = "")]
		public DateTime? StartTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "occ_time" , ColumnDataType = "datetime", IsNullable = true, ColumnDescription = "")]
		public DateTime? OccTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "event_type" , ColumnDataType = "tinyint", IsNullable = true, ColumnDescription = "")]
		public long? EventType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "owner_id" , ColumnDataType = "int", IsNullable = true, ColumnDescription = "")]
		public int? OwnerId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "buyer_id" , ColumnDataType = "int", IsNullable = true, ColumnDescription = "")]
		public int? BuyerId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "price" , ColumnDataType = "int", IsNullable = true, ColumnDescription = "")]
		public int? Price { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "seal_flag" , ColumnDataType = "tinyint", IsNullable = true, ColumnDescription = "")]
		public long? SealFlag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "item_id" , ColumnDataType = "int", IsNullable = true, ColumnDescription = "")]
		public int? ItemId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "add_info" , ColumnDataType = "int", IsNullable = true, ColumnDescription = "")]
		public int? AddInfo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "upgrade" , ColumnDataType = "tinyint", IsNullable = true, ColumnDescription = "")]
		public long? Upgrade { get; set; }

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
		[SugarColumn(ColumnName = "seal_cnt" , ColumnDataType = "tinyint", IsNullable = true, ColumnDescription = "")]
		public long? SealCnt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "endurance" , ColumnDataType = "smallint", IsNullable = true, ColumnDescription = "")]
		public short? Endurance { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "extend_info" , ColumnDataType = "int", IsNullable = true, ColumnDescription = "")]
		public int? ExtendInfo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "owner_postal_id" , ColumnDataType = "int", IsNullable = true, ColumnDescription = "")]
		public int? OwnerPostalId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "buyer_postal_id" , ColumnDataType = "int", IsNullable = true, ColumnDescription = "")]
		public int? BuyerPostalId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "unit_price" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int UnitPrice { get; set; }

	}
}
