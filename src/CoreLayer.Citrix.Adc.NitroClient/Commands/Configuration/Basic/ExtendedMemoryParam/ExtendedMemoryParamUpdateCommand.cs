using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ExtendedMemoryParam;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.ExtendedMemoryParam
{
    public class ExtendedMemoryParamUpdateCommand : NitroCommand<ExtendedMemoryParamUpdateResponse>
    {
        public ExtendedMemoryParamUpdateCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) 
            :base(serviceClient, requestConfiguration){}
    }
}