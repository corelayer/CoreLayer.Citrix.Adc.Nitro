using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Logout;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Logout
{
    public class NitroLogoutCommand : NitroCommand<NitroLogoutResponse>
    {
        public NitroLogoutCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) 
            : base(serviceClient, requestConfiguration) { }
    }
}