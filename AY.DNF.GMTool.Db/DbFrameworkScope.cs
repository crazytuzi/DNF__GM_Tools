using AY.DNF.GMTool.Db.DbModels.GMTool;
using AY.DNF.GMTool.Db.DbModels.local;
using SqlSugar;
using System;
using System.IO;
using TiaoTiaoCode.NLogger;

namespace AY.DNF.GMTool.Db
{
    public class DbFrameworkScope
    {
        #region 数据库

        static SqlSugarScope? _dTaiwan;
        static SqlSugarScope? _taiwanCain;
        static SqlSugarScope? _taiwanBillinig;
        static SqlSugarScope? _taiwanCain2nd;
        //static SqlSugarScope? _localDb;
        static SqlSugarScope? _gmToolDb;
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

        /// <summary>
        /// 邮件 背包
        /// </summary>
        public static SqlSugarScope TaiwanCain2nd => _taiwanCain2nd!;

        ///// <summary>
        ///// 本地数据
        ///// </summary>
        //public static SqlSugarScope LocalDb => _localDb!;

        /// <summary>
        /// GM工具数据库
        /// </summary>
        public static SqlSugarScope GMToolDb => _gmToolDb!;

        #endregion

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="server"></param>
        /// <param name="userName"></param>
        /// <param name="pwd"></param>
        /// <param name="port"></param>
        public static bool Init(string server, string userName, string pwd, int port)
        {
            try
            {
                _dTaiwan = new SqlSugarScope(new ConnectionConfig
                {
                    DbType = DbType.MySql,
                    ConfigId = "d_taiwan",
                    ConnectionString = $"Server={server};Port={port};Database=d_taiwan;Uid={userName};Pwd={pwd};Charset=utf8;AllowZeroDateTime=True;ConvertZeroDateTime=True",
                    IsAutoCloseConnection = true,
                });

                _taiwanCain = new SqlSugarScope(new ConnectionConfig
                {
                    DbType = DbType.MySql,
                    ConfigId = "taiwan_cain",
                    ConnectionString = $"Server={server};Port={port};Database=taiwan_cain;Uid={userName};Pwd={pwd};Charset=utf8;AllowZeroDateTime=True;ConvertZeroDateTime=True",
                    IsAutoCloseConnection = true,
                });

                _taiwanBillinig = new SqlSugarScope(new ConnectionConfig
                {
                    DbType = DbType.MySql,
                    ConfigId = "taiwan_billing",
                    ConnectionString = $"Server={server};Port={port};Database=taiwan_billing;Uid={userName};Pwd={pwd};Charset=utf8;AllowZeroDateTime=True;ConvertZeroDateTime=True",
                    IsAutoCloseConnection = true,
                });

                _taiwanCain2nd = new SqlSugarScope(new ConnectionConfig
                {
                    DbType = DbType.MySql,
                    ConfigId = "taiwan_cain_2nd",
                    ConnectionString = $"Server={server};Port={port};Database=taiwan_cain_2nd;Uid={userName};Pwd={pwd};Charset=utf8;AllowZeroDateTime=True;ConvertZeroDateTime=True",
                    IsAutoCloseConnection = true,
                });

                //_localDb = new SqlSugarScope(new ConnectionConfig
                //{
                //    DbType = DbType.Access,
                //    ConfigId = "local",
                //    ConnectionString = $"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = {Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LocalData", "DNF.mdb")}",
                //    IsAutoCloseConnection = true
                //});

                var sqliteDb = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LocalData", "dnf.db");
                _gmToolDb = new SqlSugarScope(new ConnectionConfig
                {
                    DbType = DbType.Sqlite,
                    ConfigId = "gm_tool",
                    ConnectionString = $"DataSource={sqliteDb}",
                    IsAutoCloseConnection = true,
                });

                _dTaiwan.Ado.CheckConnection();
                _taiwanCain.Ado.CheckConnection();
                _taiwanBillinig.Ado.CheckConnection();
                _taiwanCain2nd.Ado.CheckConnection();
                //_localDb.Ado.CheckConnection();

                if (!_gmToolDb.DbMaintenance.IsAnyTable("DungeonDictionary"))
                    _gmToolDb.CodeFirst.InitTables(typeof(DungeonDictionary));
                if (!_gmToolDb.DbMaintenance.IsAnyTable("EquipDictionary"))
                    _gmToolDb.CodeFirst.InitTables(typeof(EquipDictionary));
                if (!_gmToolDb.DbMaintenance.IsAnyTable("LocalAllItems"))
                    _gmToolDb.CodeFirst.InitTables(typeof(LocalAllItems));

                _gmToolDb.Ado.CheckConnection();
                return true;
            }
            catch (System.Exception ex)
            {
                TiaoTiaoNLogger.LogDebug(ex.Message);
                return false;
            }
        }
    }
}
