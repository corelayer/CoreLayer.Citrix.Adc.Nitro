using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsCNameRec;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Dns.DnsCNameRec
{
    public class DnsCNameRecRemoveCommand : NitroCommand<DnsCNameRecRemoveResponse>
    {
        public DnsCNameRecRemoveCommand(INitroServiceClient serviceClient,
            INitroRequestConfiguration requestConfiguration) : base(
            serviceClient, requestConfiguration)
        {
            
        }
    }
}