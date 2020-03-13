using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Logout
{
    public class NitroLogoutCommand : NitroCommand<NitroResponse>
    {
        public NitroLogoutCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration) 
            : base(httpClient, requestConfiguration) { }
    }
}