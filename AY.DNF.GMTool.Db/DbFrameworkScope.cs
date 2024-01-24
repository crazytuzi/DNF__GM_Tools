using SqlSugar;

namespace AY.DNF.GMTool.Db
{
    public class DbFrameworkScope
    {
        #region 数据库

        static SqlSugarScope? _dTaiwan;
        static SqlSugarScope? _taiwanCain;
        static SqlSugarScope? _taiwanBillinig;
        static SqlSugarScope? _taiwanCain2nd;

        /// <summary>
        /// 用户信息库
        /// </summary>
        public static SqlSugarScope DTaiwan => _dTaiwan!;

        /// <summary>
        /// 角色信息库
        /// </summary>
        public static SqlSugarScope TaiwanCain => _taiwanCain!;

        /// <summary>
        /// 支付信息库
        /// D币 D点
        /// </summary>
        public static SqlSugarScope TaiwanBilling => _taiwanBillinig!;

        public static SqlSugarScope TaiwanCain2nd => _taiwanCain2nd!;

        #endregion

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="server"></param>
        /// <param name="userName"></param>
        /// <param name="pwd"></param>
        /// <param name="port"></param>
        public static void Init(string server, string userName, string pwd, int port)
        {
            _dTaiwan = new SqlSugarScope(new ConnectionConfig
            {
                DbType = DbType.MySql,
                ConfigId = "d_taiwan",
                ConnectionString = $"Server={server};Port={port};Database=d_taiwan;Uid={userName};Pwd={pwd};Charset=utf8;",
                IsAutoCloseConnection = true,
            });

            _taiwanCain = new SqlSugarScope(new ConnectionConfig
            {
                DbType = DbType.MySql,
                ConfigId = "taiwan_cain",
                ConnectionString = $"Server={server};Port={port};Database=taiwan_cain;Uid={userName};Pwd={pwd};Charset=utf8;",
                IsAutoCloseConnection = true,
            });

            _taiwanBillinig = new SqlSugarScope(new ConnectionConfig
            {
                DbType = DbType.MySql,
                ConfigId = "taiwan_billing",
                ConnectionString = $"Server={server};Port={port};Database=taiwan_billing;Uid={userName};Pwd={pwd};Charset=utf8;",
                IsAutoCloseConnection = true,
            });

            _taiwanCain = new SqlSugarScope(new ConnectionConfig
            {
                DbType = DbType.MySql,
                ConfigId = "taiwan_cain_2nd",
                ConnectionString = $"Server={server};Port={port};Database=taiwan_cain;Uid={userName};Pwd={pwd};Charset=utf8;",
                IsAutoCloseConnection = true,
            });
        }
    }
}
