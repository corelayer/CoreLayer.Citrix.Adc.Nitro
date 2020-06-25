using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsAddRec;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Dns.DnsAddRec
{
    public class DnsAddRecAddCommand : NitroCommand<DnsAddRecAddResponse>
    {
        public DnsAddRecAddCommand(INitroServiceClient serviceClient,
            INitroRequestConfiguration requestConfiguration) : base(
            serviceClient, requestConfiguration)
        {
            
        }
    }
}