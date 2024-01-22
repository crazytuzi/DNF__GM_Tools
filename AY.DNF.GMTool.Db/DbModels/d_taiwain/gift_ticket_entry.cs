using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("gift_ticket_entry", TableDescription = "")]
	public class GiftTicketEntry
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "id" , ColumnDataType = "int", IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "")]
		public int Id { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gift_no" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short GiftNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "buyer_id" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int BuyerId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "buyer_date" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int BuyerDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "buyer_code" , ColumnDataType = "varchar", Length = 21, ColumnDescription = "")]
		public string BuyerCode { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "buyer_check" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int BuyerCheck { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "other_id" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int OtherId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "other_date" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int OtherDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "other_code" , ColumnDataType = "varchar", Length = 21, ColumnDescription = "")]
		public string OtherCode { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "other_check" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int OtherCheck { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "message" , ColumnDataType = "varchar", Length = 200, ColumnDescription = "")]
		public string Message { get; set; } = string.Empty;

	}
}
