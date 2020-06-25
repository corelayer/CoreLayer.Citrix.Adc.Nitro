using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsNsRec;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Dns.DnsNsRec
{
    public class DnsNsRecRemoveCommand : NitroCommand<DnsNsRecRemoveResponse>
    {
        public DnsNsRecRemoveCommand(INitroServiceClient serviceClient,
            INitroRequestConfiguration requestConfiguration) : base(
            serviceClient, requestConfiguration)
        {
            
        }
    }
}