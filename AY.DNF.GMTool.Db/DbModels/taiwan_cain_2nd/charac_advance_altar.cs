using SqlSugar;
using System;
using System.Collections.Generic;

namespace AY.DNF.GMTool.Db.DbModels.taiwan_cain_2nd
{
	/// <summary>
	/// 
	/// </summary>
	[SugarTable("charac_advance_altar", TableDescription = "")]
	public class CharacAdvanceAltar
	{
		/// <summary>
		/// ﾄｳｸｯﾅﾍｹ?｣
		/// </summary>
		[SugarColumn(ColumnName = "charac_no" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "ﾄｳｸｯﾅﾍｹ?｣")]
		public int CharacNo { get; set; }

		/// <summary>
		/// ｺｯｽﾅｸ?ｺﾅﾍ ｾﾆﾀﾌｵ
		/// </summary>
		[SugarColumn(ColumnName = "ridable_id" , ColumnDataType = "int", IsPrimaryKey = true, DefaultValue = "0", ColumnDescription = "ｺｯｽﾅｸ?ｺﾅﾍ ｾﾆﾀﾌｵ")]
		public int RidableId { get; set; }

		/// <summary>
		/// ｹｫｷ眤ﾔﾀ螻ﾇ(ｻ鄂ﾅﾀﾇ ﾃﾊｴ??ﾃｳｷｳ ｸﾅﾀﾏ ﾃ､ｿ??
		/// </summary>
		[SugarColumn(ColumnName = "ticket_free" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "ｹｫｷ眤ﾔﾀ螻ﾇ(ｻ鄂ﾅﾀﾇ ﾃﾊｴ??ﾃｳｷｳ ｸﾅﾀﾏ ﾃ､ｿ??")]
		public short TicketFree { get; set; }

		/// <summary>
		/// ｼｼｶ?･ｿ｡ｼｭ ｱｸｸﾅﾇﾑ ﾀｯｷ眤ﾔﾀ螻ﾇ
		/// </summary>
		[SugarColumn(ColumnName = "ticket_cera" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "ｼｼｶ?･ｿ｡ｼｭ ｱｸｸﾅﾇﾑ ﾀｯｷ眤ﾔﾀ螻ﾇ")]
		public short TicketCera { get; set; }

		/// <summary>
		/// ｽｺﾅﾗﾀﾌﾁ?ﾅｬｸｮｾ?ｺｸｻ?ｸｷﾎ ｹﾞﾀｺ star (ﾁ?｡ﾇﾏｰ?ｰｨｼﾒ ｾ?ｽ)
		/// </summary>
		[SugarColumn(ColumnName = "star_game" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "ｽｺﾅﾗﾀﾌﾁ?ﾅｬｸｮｾ?ｺｸｻ?ｸｷﾎ ｹﾞﾀｺ star (ﾁ?｡ﾇﾏｰ?ｰｨｼﾒ ｾ?ｽ)")]
		public int StarGame { get; set; }

		/// <summary>
		/// ｼｼｶ?･ｿ｡ｼｭ ｱｸｸﾅﾇﾑ ﾀｯｷ?star(ﾁ?｡ﾇﾏｰ?ｰｨｼﾒ ｾ?ｽ)
		/// </summary>
		[SugarColumn(ColumnName = "star_cera" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "ｼｼｶ?･ｿ｡ｼｭ ｱｸｸﾅﾇﾑ ﾀｯｷ?star(ﾁ?｡ﾇﾏｰ?ｰｨｼﾒ ｾ?ｽ)")]
		public int StarCera { get; set; }

		/// <summary>
		/// ｻ鄙?｡ｴﾉﾇﾑ star (=ｻ鄙?ﾏｰ?ｳｲﾀｺ star)
		/// </summary>
		[SugarColumn(ColumnName = "star_usable" , ColumnDataType = "int", DefaultValue = "0", ColumnDescription = "ｻ鄙?｡ｴﾉﾇﾑ star (=ｻ鄙?ﾏｰ?ｳｲﾀｺ star)")]
		public int StarUsable { get; set; }

		/// <summary>
		/// ｼｭｹﾙﾀﾌｹ??蠢｡ｼｭ ﾅｬｸｮｾ?ﾑ ﾃﾖｴ?ｽｺﾅﾗﾀﾌﾁ??｣
		/// </summary>
		[SugarColumn(ColumnName = "survival_best" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "ｼｭｹﾙﾀﾌｹ??蠢｡ｼｭ ﾅｬｸｮｾ?ﾑ ﾃﾖｴ?ｽｺﾅﾗﾀﾌﾁ??｣")]
		public short SurvivalBest { get; set; }

		/// <summary>
		/// starｸｦ ﾃﾊｱ篳ｭﾇﾑ ﾈｸｼ?ｱ篳ｹ:ﾃﾊｱ篳ｭ ﾈｽｼ?｡ ｵ??ｺ??ﾌ ｴﾙｸｧ)
		/// </summary>
		[SugarColumn(ColumnName = "star_reset_count" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "starｸｦ ﾃﾊｱ篳ｭﾇﾑ ﾈｸｼ?ｱ篳ｹ:ﾃﾊｱ篳ｭ ﾈｽｼ?｡ ｵ??ｺ??ﾌ ｴﾙｸｧ)")]
		public short StarResetCount { get; set; }

		/// <summary>
		/// ｽｺﾅﾗﾀﾌﾁ?unlock ﾀﾌﾆ衄ｮｸｦ ｺｸｿｩﾁ狎ﾟ ﾇﾏｴﾂﾁ?
		/// </summary>
		[SugarColumn(ColumnName = "is_unlock_stage_effect" , ColumnDataType = "smallint", DefaultValue = "0", ColumnDescription = "ｽｺﾅﾗﾀﾌﾁ?unlock ﾀﾌﾆ衄ｮｸｦ ｺｸｿｩﾁ狎ﾟ ﾇﾏｴﾂﾁ?")]
		public short IsUnlockStageEffect { get; set; }

		/// <summary>
		/// ﾅｬｸｮｾ?ﾑ, ﾀﾔﾀ?ﾇﾒ ｼ?ﾀﾖｴﾂ ｽｺﾅﾗﾀﾌﾁ?ｮｽｺﾆｮ
		/// </summary>
		[SugarColumn(ColumnName = "stage_list" , ColumnDataType = "blob", ColumnDescription = "ﾅｬｸｮｾ?ﾑ, ﾀﾔﾀ?ﾇﾒ ｼ?ﾀﾖｴﾂ ｽｺﾅﾗﾀﾌﾁ?ｮｽｺﾆｮ")]
		public byte[] StageList { get; set; }

		/// <summary>
		/// ｽｽｷﾔ ｸｮｽｺﾆｮ
		/// </summary>
		[SugarColumn(ColumnName = "slot_list" , ColumnDataType = "blob", ColumnDescription = "ｽｽｷﾔ ｸｮｽｺﾆｮ")]
		public byte[] SlotList { get; set; }

		/// <summary>
		/// ｾ?ﾗｷｹﾀﾌｵ?ｻ?｡ｿ｡ｼｭ ｱｸｸﾅﾇﾑ ｾﾆﾀﾌﾅﾛ ｸｮｽｺﾆｮ
		/// </summary>
		[SugarColumn(ColumnName = "buy_item_list" , ColumnDataType = "blob", ColumnDescription = "ｾ?ﾗｷｹﾀﾌｵ?ｻ?｡ｿ｡ｼｭ ｱｸｸﾅﾇﾑ ｾﾆﾀﾌﾅﾛ ｸｮｽｺﾆｮ")]
		public byte[] BuyItemList { get; set; }

		/// <summary>
		/// ｾ??ｺｸｻ?ｸｮｽｺﾆｮ
		/// </summary>
		[SugarColumn(ColumnName = "reward_list" , ColumnDataType = "blob", ColumnDescription = "ｾ??ｺｸｻ?ｸｮｽｺﾆｮ")]
		public byte[] RewardList { get; set; }

	}
}
