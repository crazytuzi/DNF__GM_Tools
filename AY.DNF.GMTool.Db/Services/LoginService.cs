using AY.DNF.GMTool.Db.DbModels.d_taiwan;
using AY.DNF.GMTool.Db.DbModels.taiwan_billing;
using AY.DNF.GMTool.Db.DbModels.taiwan_cain;
using AY.DNF.GMTool.Db.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AY.DNF.GMTool.Db.Services
{
    /// <summary>
    /// 登录相关服务
    /// </summary>
    public class LoginService
    {
        /// <summary>
        /// 登录 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<LoginInfoModel?> Login(string userName, string password = "")
        {
            LoginInfoModel? result = null;

            //string pwd = "";
            //var md5 = MD5.Create(); //实例化一个md5对像
            //                        // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
            //byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
            //// 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得
            //for (int i = 0; i < s.Length; i++)
            //{
            //    // 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符 
            //    pwd = pwd + s[i].ToString("X");
            //}

            //pwd = pwd.ToLower();

            var account = await DbFrameworkScope.DTaiwan.Queryable<Accounts>().Where(t => t.Accountname == userName).FirstAsync();// && t.Password == password).FirstAsync();
            if (account == null) return result;

            result = new LoginInfoModel
            {
                AccountName = userName,
                Uid = account.UID.ToString(),
                VIP = account.VIP.Trim() == "1" ? "VIP用户" : "非VIP用户"
            };

            // D币
            var dCoin = await DbFrameworkScope.TaiwanBilling.Queryable<CashCera>().Where(t => t.Account == account.UID.ToString()).FirstAsync();
            var dPoint = await DbFrameworkScope.TaiwanBilling.Queryable<CashCeraPoint>().Where(t => t.Account == account.UID.ToString()).FirstAsync();

            result.DCoin = dCoin.Cera;
            result.DPoint = dPoint.CeraPoint;

            var punish = await DbFrameworkScope.DTaiwan.Queryable<MemberPunishInfo>().Where(t => t.MId == account.UID).FirstAsync();
            result.Status = punish == null ? "正常" : "封停";

            // 角色
            var roles =
                // 角色信息编码问题，用这种方式查询可以解决乱码
                await DbFrameworkScope.TaiwanCain.SqlQueryable<CharacInfo>($"Set Charset latin1; select charac_no CharacNo,charac_name CharacName,lev from charac_info where delete_flag!=1 and m_id={account.UID}").ToListAsync();
            result.MemberInfos.AddRange(roles.Select(t => new SimpleMemberInfoModel { CharacNo = t.CharacNo, CharacName = t.CharacName, Level = t.Lev }));

            return result;
        }
    }
}
