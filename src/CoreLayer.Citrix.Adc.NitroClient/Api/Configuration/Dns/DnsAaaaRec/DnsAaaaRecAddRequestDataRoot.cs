using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsAaaaRec
{
    public class DnsAaaaRecAddRequestDataRoot : INitroRequestDataRoot
    {
        public DnsAaaaRecAddRequestDataRoot(dynamic data)
        {
            DnsAaaaRec = new dynamic[] {data};
        }
        public DnsAaaaRecAddRequestDataRoot(dynamic[] data)
        {
            DnsAaaaRec = data;
        }
        public dynamic[] DnsAaaaRec { get; set; }
    }
}