using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsNsRec
{
    public class DnsNsRecAddRequestDataRoot : INitroRequestDataRoot
    {
        public DnsNsRecAddRequestDataRoot(dynamic data)
        {
            DnsNsRec = new dynamic[] {data};
        }
        public DnsNsRecAddRequestDataRoot(dynamic[] data)
        {
            DnsNsRec = data;
        }
        public dynamic[] DnsNsRec { get; set; }

        public override string ToString()
        {
            string result= "";
            foreach (var dataItem in DnsNsRec)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }
    }
}