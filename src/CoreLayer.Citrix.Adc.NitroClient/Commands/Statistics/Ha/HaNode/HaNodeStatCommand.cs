using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ha.HaNode;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Ha.HaNode
{
    public class HaNodeStatCommand : NitroCommand<HaNodeStatResponse>
    {
        public HaNodeStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration)
        {
                                               
        }
    }
}