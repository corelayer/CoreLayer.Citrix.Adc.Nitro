using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.NS.NsHttpProfile;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.NS.NsHttpProfile
{
    public class NsHttpProfileGetCommand : NitroCommand<NsHttpProfileGetResponse>
    {
        public NsHttpProfileGetCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration) :
            base(httpClient, requestConfiguration)
        {
            
        }
    }
}