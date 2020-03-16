using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Basic.Service;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Basic.Service
{
    public class ServiceStatCommand : NitroCommand<ServiceStatResponse>
    {
        public ServiceStatCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration) : base(
            httpClient, requestConfiguration)
        {
            
        }
    }
}