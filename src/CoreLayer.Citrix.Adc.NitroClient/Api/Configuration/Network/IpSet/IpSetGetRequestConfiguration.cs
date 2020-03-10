using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Network.IpSet
{
    public class IpSetGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/ipset";
        public override INitroRequestDataRoot DataRoot => new IpSetGetRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new IpSetGetRequestOptions();
    }
}