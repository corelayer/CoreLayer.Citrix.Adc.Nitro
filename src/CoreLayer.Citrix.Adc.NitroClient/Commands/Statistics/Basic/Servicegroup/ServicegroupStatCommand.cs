using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Basic.Servicegroup;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Basic.Servicegroup
{
    public class ServicegroupStatCommand : NitroCommand<ServicegroupStatResponse>
    {
        public ServicegroupStatCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration) :
            base(httpClient, requestConfiguration)
        {
            
        }
    }
}