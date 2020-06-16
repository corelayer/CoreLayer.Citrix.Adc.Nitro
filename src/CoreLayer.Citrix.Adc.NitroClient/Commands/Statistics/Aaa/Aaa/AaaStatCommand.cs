using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Aaa.Aaa;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Aaa.Aaa
{
    public class AaaStatCommand : NitroCommand<AaaStatResponse>
    {
        public AaaStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) :
            base(
                serviceClient, requestConfiguration)
        {
            
        }
    }
}