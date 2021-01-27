using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.SSL.SslCertKey;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.SSL.SslCertKey
{
    public class SslCertKeyAddCommand : NitroCommand<SslCertKeyAddResponse>
    {
        public SslCertKeyAddCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : base(
            serviceClient, requestConfiguration)
        {
            
        }
    }
}