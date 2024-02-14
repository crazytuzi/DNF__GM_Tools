namespace AY.DNF.GMTool.Models
{
    public class ConnectInfoModel
    {
        public string IP { get; set; } = string.Empty;
        public int Port { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Pwd { get; set; } = string.Empty;
        public string Account { get; set; } = string.Empty;

        public string ExeFilePath { get; set; } = string.Empty;
    }
}
