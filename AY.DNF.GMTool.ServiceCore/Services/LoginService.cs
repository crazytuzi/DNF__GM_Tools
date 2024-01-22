using AY.DNF.GMTool.Db;
using AY.DNF.GMTool.Db.DbModels.d_taiwan;
using AY.DNF.GMTool.ServiceCore.IServices;
using AY.DNF.GMTool.ServiceCore.Models;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AY.DNF.GMTool.ServiceCore.Services
{
    public class LoginService : MyRepository<Accounts>, ILoginService
    {
        public LoginService() : base("d_taiwan") { }

        public async Task<LoginInfo?> Login(string username, string password)
        {
           


        }
    }
}
