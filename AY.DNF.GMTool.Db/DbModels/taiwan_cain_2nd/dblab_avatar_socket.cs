using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain_2nd
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("dblab_avatar_socket", TableDescription = "")]
	public class DblabAvatarSocket
	{
		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "it_id" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "")]
		public int ItId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[SugarColumn(ColumnName = "jewel_socket" , ColumnDataType = "varchar", Length = 600, IsNullable = true, ColumnDescription = "")]
		public string? JewelSocket { get; set; }

	}
}
