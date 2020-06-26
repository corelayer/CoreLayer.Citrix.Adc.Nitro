using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsAaaaRec;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Dns.DnsAaaaRec
{
    public class DnsAaaaRecRemoveCommand : NitroCommand<DnsAaaaRecRemoveResponse>
    {
        public DnsAaaaRecRemoveCommand(INitroServiceClient serviceClient,
            INitroRequestConfiguration requestConfiguration) : base(
            serviceClient, requestConfiguration)
        {
            
        }
    }
}