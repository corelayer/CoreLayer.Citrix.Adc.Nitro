using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.SSL.SslCertFile;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.SSL.SslCertFile
{
    public class SslCertFileRemoveCommand : NitroCommand<SslCertFileRemoveResponse>
    {
        public SslCertFileRemoveCommand(INitroServiceClient client, INitroRequestConfiguration requestConfiguration) :
            base(client, requestConfiguration)
        {
            
        }
    }
}