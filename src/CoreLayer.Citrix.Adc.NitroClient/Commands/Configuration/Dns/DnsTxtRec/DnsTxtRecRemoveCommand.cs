using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsTxtRec;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Dns.DnsTxtRec
{
    public class DnsTxtRecRemoveCommand : NitroCommand<DnsTxtRecRemoveResponse>
    {
        public DnsTxtRecRemoveCommand(INitroServiceClient serviceClient,
            INitroRequestConfiguration requestConfiguration) : base(
            serviceClient, requestConfiguration)
        {
            
        }
    }
}