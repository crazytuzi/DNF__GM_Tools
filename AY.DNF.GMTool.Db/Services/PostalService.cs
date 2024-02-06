using AY.DNF.GMTool.Db.DbModels.taiwan_cain_2nd;
using System;
using System.Threading.Tasks;

namespace AY.DNF.GMTool.Db.Services
{
    /// <summary>
    /// 邮件功能服务
    /// </summary>
    public class PostalService
    {
        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="characNo"></param>
        /// <param name="itemId"></param>
        /// <param name="count"></param>
        /// <param name="forge"></param>
        /// <param name="strengthen"></param>
        /// <param name="red">3-力量 4-智力 1-体力 2-精神</param>
        /// <param name="redValue"></param>
        /// <returns></returns>
        public async Task<(bool, int)> SendPostal(int characNo, string letterText, int itemId, int count, int forge, int strengthen, int red, int redValue, bool isPackaged)
        {
            try
            {
                DbFrameworkScope.TaiwanCain2nd.Ado.BeginTran();

                // 因为字符编码问题，先设备字符集再插入数据
                await DbFrameworkScope.TaiwanCain2nd.Ado.ExecuteCommandAsync($"set charset latin1;insert into letter(charac_no,send_charac_no,send_charac_name,letter_text,reg_date,stat) values({characNo},0,'GM','{letterText}','{DateTime.Now:yyyy-MM-dd HH:mm:ss}',1);");
                var dt = await DbFrameworkScope.TaiwanCain2nd.Ado.GetDataTableAsync("SELECT LAST_INSERT_ID()");
                var letterId = int.Parse(dt.Rows[0][0].ToString());

                var postal = new Postal
                {
                    OccTime = DateTime.Now,
                    SendCharacNo = 0,
                    SendCharacName = "GM",
                    ReceiveCharacNo = characNo,
                    ItemId = itemId,
                    AddInfo = count,
                    Upgrade = strengthen,
                    AmplifyOption = red,
                    AmplifyValue = redValue,
                    LetterId = letterId,
                    SeperateUpgrade = forge,
                    SealFlag = isPackaged ? 1 : 0
                };

                var postalId = await DbFrameworkScope.TaiwanCain2nd.Insertable<Postal>(postal).ExecuteReturnIdentityAsync();

                DbFrameworkScope.TaiwanCain2nd.Ado.CommitTran();
                return (true, letterId);
            }
            catch
            {
                DbFrameworkScope.TaiwanCain2nd.Ado.RollbackTran();
                return (false, -1);
            }
        }

        /// <summary>
        /// 删除最近发送的邮件
        /// </summary>
        /// <param name="letterId"></param>
        /// <returns></returns>
        public async Task<bool> Delete(int letterId)
        {
            try
            {
                DbFrameworkScope.TaiwanCain2nd.Ado.BeginTran();

                await DbFrameworkScope.TaiwanCain2nd.Ado.ExecuteCommandAsync($"delete from letter where letter_id={letterId}");
                await DbFrameworkScope.TaiwanCain2nd.Ado.ExecuteCommandAsync($"delete from postal where letter_id={letterId}");

                DbFrameworkScope.TaiwanCain2nd.Ado.CommitTran();

                return true;
            }
            catch (Exception)
            {
                DbFrameworkScope.TaiwanCain2nd.Ado.RollbackTran();
                return false;
            }
        }

        /// <summary>
        /// 删除全服
        /// </summary>
        /// <returns></returns>
        public async Task<bool> DeleteAll()
        {
            try
            {
                DbFrameworkScope.TaiwanCain2nd.Ado.BeginTran();

                await DbFrameworkScope.TaiwanCain2nd.Ado.ExecuteCommandAsync("delete from letter");
                await DbFrameworkScope.TaiwanCain2nd.Ado.ExecuteCommandAsync("delete from postal");

                DbFrameworkScope.TaiwanCain2nd.Ado.CommitTran();

                return true;
            }
            catch (Exception)
            {
                DbFrameworkScope.TaiwanCain2nd.Ado.RollbackTran();
                return false;
            }
        }
    }
}
