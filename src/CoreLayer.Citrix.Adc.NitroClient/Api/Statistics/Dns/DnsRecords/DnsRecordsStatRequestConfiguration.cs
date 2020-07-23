using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Dns.DnsRecords
{
    public class DnsRecordsStatRequestConfiguration : NitroRequestConfiguration
    {
         public override HttpMethod Method => HttpMethod.Get;
         public override string ResourcePath => "/nitro/v1/stat/dnsrecords";
         public override INitroRequestOptions Options { get; set; } = new DnsRecordsStatRequestOptions();
         public override INitroRequestDataRoot DataRoot => new DnsRecordsStatRequestDataRoot();
                                
         public DnsRecordsStatRequestConfiguration() {}
    }
}