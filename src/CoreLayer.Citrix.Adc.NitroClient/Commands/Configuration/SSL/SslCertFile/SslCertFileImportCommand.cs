using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.SSL.SslCertFile;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.SSL.SslCertFile
{
    public class SslCertFileImportCommand : NitroCommand<SslCertFileImportResponse>
    {
        public SslCertFileImportCommand(INitroServiceClient client, INitroRequestConfiguration requestConfiguration) :
            base(client, requestConfiguration)
        {
            
        }
    }
}