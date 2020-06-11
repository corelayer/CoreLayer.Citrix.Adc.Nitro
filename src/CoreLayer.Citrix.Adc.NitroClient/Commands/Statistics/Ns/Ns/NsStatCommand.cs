using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.Ns;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Ns.Ns
{
    public class NsStatCommand : NitroCommand<NsStatResponse>
    {
        public NsStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : 
            base(serviceClient, requestConfiguration) { }
    }
}