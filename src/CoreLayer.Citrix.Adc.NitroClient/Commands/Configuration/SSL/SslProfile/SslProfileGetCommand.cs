using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.SSL.SslProfile;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.SSL.SslProfile
{
    public class SslProfileGetCommand : NitroCommand<SslProfileGetResponse>
    {
        public SslProfileGetCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : base(
            serviceClient, requestConfiguration)
        {
            
        }
    }
}