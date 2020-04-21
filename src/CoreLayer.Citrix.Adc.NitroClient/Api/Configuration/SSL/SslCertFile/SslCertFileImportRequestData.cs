using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.SSL.SslCertFile
{
    public class SslCertFileImportRequestData : INitroRequestData
    {
        public string Name { get; set; }
        public string Src { get; set; }
    }
}