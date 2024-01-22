using AY.DNF.GMTool.ServiceCore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AY.DNF.GMTool.ServiceCore.IServices
{
    public interface ILoginService
    {
        Task<LoginInfo> Login(string username, string password);
    }
}
