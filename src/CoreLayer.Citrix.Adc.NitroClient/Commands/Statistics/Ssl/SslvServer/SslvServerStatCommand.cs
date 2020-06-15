using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ssl.SslvServer;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Ssl.SslvServer
{
    public class SslvServerStatCommand : NitroCommand<SslvServerStatResponse>
    {
        public SslvServerStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : 
            base(serviceClient, requestConfiguration) { }
    }
}