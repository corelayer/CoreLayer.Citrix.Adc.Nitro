using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ExtendedMemoryParam
{
    public class ExtendedMemoryParamUnsetRequestData : INitroRequestData
    {
        public bool MemLimit => true; //public bool MemoryLimit => true;
    }
}