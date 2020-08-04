using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.NsMemory;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Ns.NsMemory
{
    public class NsMemoryStatCommand : NitroCommand<NsMemoryStatResponse>
    {
        public NsMemoryStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration) { }
    }
}