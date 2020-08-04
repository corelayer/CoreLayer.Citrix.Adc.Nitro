using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.NsPartition
{
    public class NsPartitionStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/nspartition";
        public override INitroRequestOptions Options { get; set; } = new NsPartitionStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new NsPartitionStatRequestDataRoot();
                        
        public NsPartitionStatRequestConfiguration() {}
    }
}