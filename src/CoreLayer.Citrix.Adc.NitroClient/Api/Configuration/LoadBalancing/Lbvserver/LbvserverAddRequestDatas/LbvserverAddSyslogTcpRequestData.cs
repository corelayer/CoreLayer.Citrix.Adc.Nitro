namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver.LbvserverAddRequestDatas
{
    public class LbvserverAddSyslogTcpRequestData : LbvserverAddRequestData
    {
        public LbvserverAddSyslogTcpRequestData(string lbvserverName) : base(lbvserverName)
        {
        }

        public override string ServiceType { get; } = "SYSLOGTCP";
        
        public double? DataLength { get; set; }
        public double? DataOffset { get; set; }
        public string TcpProfileName { get; set; }
    }
}