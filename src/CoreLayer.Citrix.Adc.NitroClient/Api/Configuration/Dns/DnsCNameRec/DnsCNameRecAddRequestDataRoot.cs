using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsCNameRec
{
    public class DnsCNameRecAddRequestDataRoot : INitroRequestDataRoot
    {
        public DnsCNameRecAddRequestDataRoot(dynamic data)
        {
            DnsCNameRec = new dynamic[] {data};
        }
        public DnsCNameRecAddRequestDataRoot(dynamic[] data)
        {
            DnsCNameRec = data;
        }
        public dynamic[] DnsCNameRec { get; set; }
    }
}