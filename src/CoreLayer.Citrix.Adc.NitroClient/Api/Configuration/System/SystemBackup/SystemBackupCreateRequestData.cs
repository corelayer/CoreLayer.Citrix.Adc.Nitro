namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemBackup
{
    public class SystemBackupCreateRequestData : ISystemBackupCreateRequestData
    {
        private readonly string _level;

        public SystemBackupCreateRequestData(string level)
        {
            _level = level;
        }

        public string Filename { get; set; }
        public string Comment { get; set; }
        public string Level => _level;
    }
}