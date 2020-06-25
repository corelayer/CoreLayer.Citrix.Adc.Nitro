using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsAddRec
{
    public class DnsAddRecAddRequestDataRoot : INitroRequestDataRoot
    {
        public DnsAddRecAddRequestDataRoot(dynamic data)
        {
            DnsAddRec = new dynamic[] {data};
        }
        public DnsAddRecAddRequestDataRoot(dynamic[] data)
        {
            DnsAddRec = data;
        }
        public dynamic[] DnsAddRec { get; set; }

        public override string ToString()
        {
            string result= "";
            foreach (var dataItem in DnsAddRec)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }
    }
}