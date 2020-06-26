using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsAaaaRec;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Dns.DnsAaaaRec
{
    public class DnsAaaaRecAddCommand : NitroCommand<DnsAaaaRecAddResponse>
    {
        public DnsAaaaRecAddCommand(INitroServiceClient serviceClient,
            INitroRequestConfiguration requestConfiguration) : base(
            serviceClient, requestConfiguration)
        {
            
        }
    }
}