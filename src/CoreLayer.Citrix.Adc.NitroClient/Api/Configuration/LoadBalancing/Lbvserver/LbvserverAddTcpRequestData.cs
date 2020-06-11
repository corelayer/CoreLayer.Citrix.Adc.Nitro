namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver
{
    public class LbvserverAddTcpRequestData : LbvserverAddRequestData
    {
        public LbvserverAddTcpRequestData(string lbvserverName) : base(lbvserverName)
        {
        }

        public override string ServiceType { get; } = "TCP";
        
        public string IpV46 { get; set; } 
        public string IpPattern { get; set; }
        public string IpMask { get; set; }
        public int? Port { get; set; }
        public string PersistenceType { get; set; }
        public double? DataLength { get; set; }
        public double? DataOffset { get; set; }
        public string TcpProfileName { get; set; }
    }
}