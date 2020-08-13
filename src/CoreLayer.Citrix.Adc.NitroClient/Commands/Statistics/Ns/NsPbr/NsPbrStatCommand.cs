using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.NsPbr;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Ns.NsPbr
{
    public class NsPbrStatCommand : NitroCommand<NsPbrStatResponse>
    {
        public NsPbrStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration) { }
    }
}