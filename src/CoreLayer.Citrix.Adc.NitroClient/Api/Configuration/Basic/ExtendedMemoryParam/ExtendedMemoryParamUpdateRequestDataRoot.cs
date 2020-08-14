using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ExtendedMemoryParam
{
    public class ExtendedMemoryParamUpdateRequestDataRoot : INitroRequestDataRoot
    {
        public ExtendedMemoryParamUpdateRequestDataRoot(dynamic data)
        {
            ExtendedMemoryParam = data;
        }
        public dynamic ExtendedMemoryParam { get; set; }
    }
}