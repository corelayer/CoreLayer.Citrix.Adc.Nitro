using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemSshKey;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.System.SystemSshKey
{
    public class SystemSshKeyGetCommand : NitroCommand<SystemSshKeyGetResponse>
    {
        public SystemSshKeyGetCommand(INitroServiceClient client, INitroRequestConfiguration requestConfiguration) : base(
            client, requestConfiguration)
        {
            
        }
    }
}