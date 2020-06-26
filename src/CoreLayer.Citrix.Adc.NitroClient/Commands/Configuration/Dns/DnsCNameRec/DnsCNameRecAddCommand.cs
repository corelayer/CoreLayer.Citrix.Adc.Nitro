using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsCNameRec;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Dns.DnsCNameRec
{
    public class DnsCNameRecAddCommand : NitroCommand<DnsCNameRecAddResponse>
    {
        public DnsCNameRecAddCommand(INitroServiceClient serviceClient,
            INitroRequestConfiguration requestConfiguration) : base(
            serviceClient, requestConfiguration)
        {
            
        }
    }
}