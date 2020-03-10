namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver.LbvserverAddRequestDatas
{
    public class LbvserverAddDnsRequestData : LbvserverAddRequestData
    {
        public LbvserverAddDnsRequestData(string lbvserverName) : base(lbvserverName)
        {
        }

        public override string ServiceType { get; } = "DNS";
        
        public string IpV46 { get; set; } 
        public string IpPattern { get; set; }
        public string IpMask { get; set; }
        public int? Port { get; set; }
        public string PersistenceType { get; set; }
        public string Dns64 { get; set; }
        public string Bypassaaaa { get; set; }
        public string RecursionAvailable { get; set; }
        public string DnsProfileName { get; set; }
    }
}