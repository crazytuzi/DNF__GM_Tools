using Prism.Mvvm;

namespace AY.DNF.GMTool.Models
{
    public class LoginBindableModel : BindableBase
    {
        private int _dPoint;
        private int _dCoin;
        private string? _status;
        private string? _uid;
        private string? _accountName;
        private string? _vip;

        /// <summary>
        /// UID
        /// </summary>
        public string? Uid
        {
            get { return _uid; }
            set { SetProperty(ref _uid, value); }
        }

        /// <summary>
        /// 账号名
        /// </summary>
        public string? AccountName
        {
            get { return _accountName; }
            set { SetProperty(ref _accountName, value); }
        }


        /// <summary>
        /// D点
        /// </summary>
        public int DPoint
        {
            get { return _dPoint; }
            set { SetProperty(ref _dPoint, value); }
        }

        /// <summary>
        /// D币
        /// </summary>
        public int DCoin
        {
            get { return _dCoin; }
            set { SetProperty(ref _dCoin, value); }
        }

        /// <summary>
        /// 封停状态
        /// </summary>
        public string? Status
        {
            get { return _status; }
            set { SetProperty(ref _status, value); }
        }

        /// <summary>
        /// VIP
        /// </summary>
        public string? VIP
        {
            get { return _vip; }
            set { SetProperty(ref _vip, value); }
        }

    }
}
