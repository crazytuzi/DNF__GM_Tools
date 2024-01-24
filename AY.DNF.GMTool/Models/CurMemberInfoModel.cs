using Prism.Mvvm;
using System;

namespace AY.DNF.GMTool.Models
{
    public class CurMemberInfoModel : BindableBase
    {
		private string _characNo;

		public string CharacNo
		{
			get { return _characNo; }
			set { SetProperty(ref _characNo, value); }
		}
		private string _characName;

		public string CharacName
		{
			get { return _characName; }
			set { _characName = value; }
		}

		private long _level;

		public long Level
		{
			get { return _level; }
			set { SetProperty(ref _level, value); }
		}

		private string? _job;

		public string? Job
		{
			get { return _job; }
			set { SetProperty(ref _job, value); }
		}

		private string? _expertJob;

		public string? ExpertJob
		{
			get { return _expertJob; }
			set { SetProperty(ref _expertJob, value); }
		}

		private DateTime	_lastPlayTime;
		public DateTime LastPlayTime
        {
			get { return _lastPlayTime; }
			set { SetProperty(ref _lastPlayTime, value); }
		}

		private string? _vip;

		public string? VIP
		{
			get { return _vip; }
			set { SetProperty(ref _vip, value); }
		}

		private long _money;

		public long Money
		{
			get { return _money; }
			set { SetProperty(ref _money, value); }
		}

	}
}
