using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.SSL.SslCertFile
{
    public class SslCertFileImportRequestDataRoot : INitroRequestDataRoot
    {
        public SslCertFileImportRequestDataRoot(dynamic data)
        {
            SslCertFile = new dynamic[] {data};
        }
        public SslCertFileImportRequestDataRoot(dynamic[] data)
        {
            SslCertFile = data;
        }
        public dynamic[] SslCertFile { get; set; }

    }
}