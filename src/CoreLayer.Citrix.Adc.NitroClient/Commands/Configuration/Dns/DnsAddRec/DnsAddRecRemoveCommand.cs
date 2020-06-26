using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsAddRec;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Dns.DnsAddRec
{
    public class DnsAddRecRemoveCommand : NitroCommand<DnsAddRecRemoveResponse>
    {
        public DnsAddRecRemoveCommand(INitroServiceClient serviceClient,
            INitroRequestConfiguration requestConfiguration) : base(
            serviceClient, requestConfiguration)
        {
            
        }
    }
}