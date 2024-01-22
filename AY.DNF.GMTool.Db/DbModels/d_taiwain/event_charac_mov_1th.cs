using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("event_charac_mov_1th", TableDescription = "")]
	public class EventCharacMov1th
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "id" , ColumnDataType = "int", IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "")]
		public int Id { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "m_id" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int MId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "server_id" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long ServerId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int CharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "move_server_id" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long MoveServerId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "move_charac_no" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int MoveCharacNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "move_check" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "")]
		public int MoveCheck { get; set; }

	}
}
