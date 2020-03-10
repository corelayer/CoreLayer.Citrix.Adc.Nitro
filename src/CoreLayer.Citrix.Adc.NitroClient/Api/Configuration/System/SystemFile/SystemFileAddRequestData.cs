using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemFile
{
    public class SystemFileAddRequestData : INitroRequestData
    {
        public string FileName { get; }
        public string FileContent { get; }
        public SystemFileAddRequestData(string fileName, string fileContent)
        {
            FileName = fileName;
            FileContent = fileContent;
        }
        
        public string FileLocation { get; set; }
        public string FileEncoding { get; set; }
    }
}