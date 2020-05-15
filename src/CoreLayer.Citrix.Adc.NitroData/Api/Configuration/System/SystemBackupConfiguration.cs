namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.System
{
    public class SystemBackupConfiguration
    {
        public string FileName { get; set; }
        public string Level { get; set; }
        public string IncludeKernel { get; set; }
        public string Comment { get; set; }
        public double Size { get; set; }
        public bool UseLocalTimeZone { get; set; }
        public string CreationTime { get; set; }
        public string Version { get; set; }
        public string CreatedBy { get; set; }
        public string IpAddress { get; set; }
    }
}