using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.NsPartition;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Ns.NsPartition
{
    public class NsPartitionStatCommand : NitroCommand<NsPartitionStatResponse>
    {
        public NsPartitionStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration) { }
    }
}