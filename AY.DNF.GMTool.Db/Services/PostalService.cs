using AY.DNF.GMTool.Db.DbModels.taiwan_cain_2nd;
using System;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace AY.DNF.GMTool.Db.Services
{
    public class PostalService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="characNo"></param>
        /// <param name="itemId"></param>
        /// <param name="count"></param>
        /// <param name="forge"></param>
        /// <param name="strengthen"></param>
        /// <param name="red">3-力量 4-智力 1-体力 2-精神</param>
        /// <param name="redValue"></param>
        /// <returns></returns>
        public async Task<bool> SendPostal(int characNo, string letterText, int itemId, int count, int forge, int strengthen, int red, int redValue)
        {
            // add_info => count
            // upgrade => strengthen
            // seperate_upgrade => forge
            // amplify_option => red
            // amplify_value => redValue

            try
            {
                DbFrameworkScope.TaiwanCain2nd.Ado.BeginTran();

                //var letter = new Letter
                //{
                //    CharacNo = characNo,
                //    SendCharacNo = 0,
                //    SendCharacName = "GM",
                //    LetterText = Encoding.UTF8.GetString(Encoding.GetEncoding("latin1").GetBytes(letterText)),
                //    RegDate = DateTime.Now,
                //    Stat = 1
                //};
                //var letterId = await DbFrameworkScope.TaiwanCain2nd.Insertable<Letter>(letter).ExecuteReturnIdentityAsync();
                await DbFrameworkScope.TaiwanCain2nd.Ado.ExecuteCommandAsync($"set charset latin1;insert into letter(charac_no,send_charac_no,send_charac_name,letter_text,reg_date,stat) values({characNo},0,'GM','{letterText}','{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}',1);");
                var dt = await DbFrameworkScope.TaiwanCain2nd.Ado.GetDataTableAsync("SELECT LAST_INSERT_ID()");
                var letterId = int.Parse(dt.Rows[0][0].ToString());

                //DbFrameworkScope.TaiwanCain2nd.SqlQueryable("insert into postal(letter_id,count,upgrade,seperate_upgrade,amplify_option,amplify_value,occ_time,send_charac_no,send_charac_name)")
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
                };

                var postalId = await DbFrameworkScope.TaiwanCain2nd.Insertable<Postal>(postal).ExecuteReturnIdentityAsync();

                DbFrameworkScope.TaiwanCain2nd.Ado.CommitTran();
            }
            catch
            {
                DbFrameworkScope.TaiwanCain2nd.Ado.RollbackTran();
                return false;
            }


            return true;
        }

    }
}
