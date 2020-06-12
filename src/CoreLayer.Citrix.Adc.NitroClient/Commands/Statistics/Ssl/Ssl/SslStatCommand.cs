using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ssl.Ssl;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Ssl.Ssl
{
    public class SslStatCommand : NitroCommand<SslStatResponse>
    {
        public SslStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : 
            base(serviceClient, requestConfiguration) { }
    }
}