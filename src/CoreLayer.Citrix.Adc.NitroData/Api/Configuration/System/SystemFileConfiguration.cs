namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.System
{
    public class SystemFileConfiguration
    {
        public string FileName { get; set; }
        public string FileLocation { get; set; }
        public string FileContent { get; set; }
        public string FileEncoding { get; set; }
        public string FileAccessTime { get; set; }
        public string FileModifiedTime { get; set; }
        public string[] FileMode { get; set; }
        public string FileSize { get; set; }
    }
}