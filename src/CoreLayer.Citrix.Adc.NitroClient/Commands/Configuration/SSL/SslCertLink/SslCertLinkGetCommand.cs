using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.SSL.SslCertLink;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.SSL.SslCertLink
{
    public class SslCertLinkGetCommand : NitroCommand<SslCertLinkGetResponse>
    {
        public SslCertLinkGetCommand(INitroServiceClient client, INitroRequestConfiguration requestConfiguration) : base(
            client, requestConfiguration)
        {
            
        }
    }
}