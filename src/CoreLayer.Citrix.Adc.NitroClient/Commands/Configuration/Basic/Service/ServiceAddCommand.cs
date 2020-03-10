using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Service;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.Service
{
    public class ServiceAddCommand : NitroCommand
    {
        public ServiceAddCommand(INitroHttpClient httpClient, ServiceAddRequestConfiguration requestConfiguration) :
            base(httpClient, requestConfiguration) { }
    }
}