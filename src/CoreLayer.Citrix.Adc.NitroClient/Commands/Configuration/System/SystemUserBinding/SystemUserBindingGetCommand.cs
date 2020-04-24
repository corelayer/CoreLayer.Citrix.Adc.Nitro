using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemUserBinding;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.System.SystemUserBinding
{
    public class SystemUserBindingGetCommand : NitroCommand<SystemUserBindingGetResponse>
    {
        public SystemUserBindingGetCommand(INitroServiceClient client, INitroRequestConfiguration requestConfiguration) :
            base(client, requestConfiguration)
        {
            
        }
    }
}