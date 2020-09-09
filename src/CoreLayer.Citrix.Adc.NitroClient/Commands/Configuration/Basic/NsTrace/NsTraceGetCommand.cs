using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.NsTrace;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.NsTrace
{
    public class NsTraceGetCommand : NitroCommand<NsTraceGetResponse>
    {
        public NsTraceGetCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) 
            :base(serviceClient, requestConfiguration){}
    }
}