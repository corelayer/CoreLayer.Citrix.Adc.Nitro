using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.Interface
{
    public class InterfaceStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/interface";
        public override INitroRequestOptions Options { get; set; } = new InterfaceStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new InterfaceStatRequestDataRoot();
        
        public InterfaceStatRequestConfiguration() {}
    }
}