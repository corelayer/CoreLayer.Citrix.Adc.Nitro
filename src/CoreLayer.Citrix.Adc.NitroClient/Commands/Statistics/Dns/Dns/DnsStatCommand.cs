using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Dns.Dns;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Dns.Dns
{
    public class DnsStatCommand: NitroCommand<DnsStatResponse>
    {
        public DnsStatCommand(INitroServiceClient serviceClient, 
            INitroRequestConfiguration requestConfiguration) :
            base(
                serviceClient, requestConfiguration)
        {
            
        }
    }
}