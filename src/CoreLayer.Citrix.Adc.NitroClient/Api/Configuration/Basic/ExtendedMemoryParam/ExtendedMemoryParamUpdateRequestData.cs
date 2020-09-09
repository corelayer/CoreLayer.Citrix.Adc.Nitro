using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ExtendedMemoryParam
{
    public class ExtendedMemoryParamUpdateRequestData : INitroRequestData
    {
        public double? MemLimit { get; set; }//public double? MemoryLimit { get; set; }
    }
}