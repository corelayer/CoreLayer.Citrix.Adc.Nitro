using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsTxtRec;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Dns.DnsTxtRec
{
    public class DnsTxtRecAddCommand : NitroCommand<DnsTxtRecAddResponse>
    {
        public DnsTxtRecAddCommand(INitroServiceClient serviceClient,
            INitroRequestConfiguration requestConfiguration) : base(
            serviceClient, requestConfiguration)
        {
            
        }
    }
}