using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Service;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.Service
{
    public class ServiceAddCommand : NitroCommand<NitroResponse>
    {
        public ServiceAddCommand(INitroServiceClient serviceClient, ServiceAddRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration) { }
    }
}