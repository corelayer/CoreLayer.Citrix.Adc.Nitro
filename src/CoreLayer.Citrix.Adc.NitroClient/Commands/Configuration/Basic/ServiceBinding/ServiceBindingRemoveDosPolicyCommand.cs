using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServiceBinding;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.ServiceBinding
{
    public class ServiceBindingRemoveDosPolicyCommand : NitroCommand<ServiceBindingRemoveResponse>
    {
        public ServiceBindingRemoveDosPolicyCommand(INitroServiceClient serviceClient,
            INitroRequestConfiguration requestConfiguration) : base(serviceClient, requestConfiguration)
        {
            
        }
    }
}