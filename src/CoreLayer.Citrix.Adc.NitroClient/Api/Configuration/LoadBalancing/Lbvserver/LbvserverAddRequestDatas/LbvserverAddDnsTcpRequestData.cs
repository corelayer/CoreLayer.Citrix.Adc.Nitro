namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver.LbvserverAddRequestDatas
{
    public class LbvserverAddDnsTcpRequestData : LbvserverAddRequestData
    {
        public LbvserverAddDnsTcpRequestData(string lbvserverName) : base(lbvserverName)
        {
        }

        public override string ServiceType { get; } = "DNS_TCP";
        
        public string IpV46 { get; set; } 
        public string IpPattern { get; set; }
        public string IpMask { get; set; }
        public int? Port { get; set; }
        public string PersistenceType { get; set; }
        public double? DataLength { get; set; }
        public double? DataOffset { get; set; }
        public string TcpProfileName { get; set; }
        public string Dns64 { get; set; }
        public string Bypassaaaa { get; set; }
        public string RecursionAvailable { get; set; }
        public string DnsProfileName { get; set; }
    }
}