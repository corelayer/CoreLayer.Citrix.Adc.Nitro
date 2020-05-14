using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Service;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.Service
{
    public class ServiceUpdateCommand : NitroCommand<ServiceUpdateResponse>
    {
        public ServiceUpdateCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : base(
            serviceClient, requestConfiguration)
        {
            
        }
    }
}