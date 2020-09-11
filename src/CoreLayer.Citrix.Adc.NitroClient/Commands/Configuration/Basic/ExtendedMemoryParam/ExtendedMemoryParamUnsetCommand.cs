using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ExtendedMemoryParam;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.ExtendedMemoryParam
{
    public class ExtendedMemoryParamUnsetCommand : NitroCommand<ExtendedMemoryParamUnsetResponse>
    {
        public ExtendedMemoryParamUnsetCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) 
            :base(serviceClient, requestConfiguration){}
    }
}