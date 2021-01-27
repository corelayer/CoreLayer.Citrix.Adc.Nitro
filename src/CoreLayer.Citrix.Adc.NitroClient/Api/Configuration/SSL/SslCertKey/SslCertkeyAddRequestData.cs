using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.SSL.SslCertKey
{
    public class SslCertKeyAddRequestData : INitroRequestData
    {
        public string FileName { get; }
        public string FileContent { get; }
        public SslCertKeyAddRequestData(string fileName, string fileContent)
        {
            FileName = fileName;
            FileContent = fileContent;
        }
        
        public string FileLocation { get; set; }
        public string FileEncoding { get; set; }
    }
}