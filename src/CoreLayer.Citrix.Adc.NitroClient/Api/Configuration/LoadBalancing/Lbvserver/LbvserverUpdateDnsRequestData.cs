namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver
{
    public class LbvserverUpdateDnsRequestData : LbvserverUpdateRequestData
    {
        public LbvserverUpdateDnsRequestData(string lbvserverName) : base(lbvserverName)
        {
        }
        
        public string IpV46 { get; set; } 
        public string IpPattern { get; set; }
        public string IpMask { get; set; }
        public string PersistenceType { get; set; }
        public string Dns64 { get; set; }
        public string Bypassaaaa { get; set; }
        public string RecursionAvailable { get; set; }
        public string DnsProfileName { get; set; }
    }
}