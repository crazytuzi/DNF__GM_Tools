using Prism.Mvvm;
using System;

namespace AY.DNF.GMTool.Models
{
	/// <summary>
	/// 当前角色信息
	/// </summary>
    public class CurMemberInfoModel : BindableBase
    {
		private string _characNo=string.Empty;
		/// <summary>
		/// 角色编号
		/// </summary>
		public string CharacNo
		{
			get { return _characNo; }
			set { SetProperty(ref _characNo, value); }
		}

		private string _characName = string.Empty;
		/// <summary>
		/// 角色名
		/// </summary>
		public string CharacName
		{
			get { return _characName; }
			set { _characName = value; }
		}

		private long _level;
		/// <summary>
		/// 等级
		/// </summary>
		public long Level
		{
			get { return _level; }
			set { SetProperty(ref _level, value); }
		}

		private string? _job;
		/// <summary>
		/// 职业
		/// </summary>
		public string? Job
		{
			get { return _job; }
			set { SetProperty(ref _job, value); }
		}

		private string? _expertJob;
		/// <summary>
		/// 副职
		/// </summary>
		public string? ExpertJob
		{
			get { return _expertJob; }
			set { SetProperty(ref _expertJob, value); }
		}

		private DateTime	_lastPlayTime;
		/// <summary>
		/// 最后游戏时间
		/// </summary>
		public DateTime LastPlayTime
        {
			get { return _lastPlayTime; }
			set { SetProperty(ref _lastPlayTime, value); }
		}

		private string? _vip;
		/// <summary>
		/// 是否VIP用户
		/// </summary>
		public string? VIP
		{
			get { return _vip; }
			set { SetProperty(ref _vip, value); }
		}

		private long _money;
		/// <summary>
		/// 金币数量
		/// </summary>
		public long Money
		{
			get { return _money; }
			set { SetProperty(ref _money, value); }
		}
	}
}
