using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.d_taiwan
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("game_channel", TableDescription = "")]
	public class GameChannel
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_no" , ColumnDataType = "int", IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "")]
		public int GcNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_now" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short GcNow { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_ip" , ColumnDataType = "char", Length = 32, ColumnDescription = "")]
		public string GcIp { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_port" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short GcPort { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_max" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short GcMax { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_game" , ColumnDataType = "tinyint", DefaultValue = "0", ColumnDescription = "")]
		public long GcGame { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_channel" , ColumnDataType = "char", Length = 16, ColumnDescription = "")]
		public string GcChannel { get; set; } = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_ch_group" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "")]
		public short GcChGroup { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "gc_channeltype" , ColumnDataType = "char", Length = 0, ColumnDescription = "")]
		public string GcChanneltype { get; set; } = string.Empty;

	}
}
