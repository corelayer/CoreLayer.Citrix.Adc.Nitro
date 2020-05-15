using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.NS.NsVersion;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.NS.NsVersion
{
    public class NsVersionGetCommand : NitroCommand<NsVersionGetResponse>
    {
        public NsVersionGetCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration)
        {
            
        }
    }
}