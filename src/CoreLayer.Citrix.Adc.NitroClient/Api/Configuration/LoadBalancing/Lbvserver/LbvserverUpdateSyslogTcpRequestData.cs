namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver
{
    public class LbvserverUpdateSyslogTcpRequestData : LbvserverUpdateRequestData
    {
        public LbvserverUpdateSyslogTcpRequestData(string lbvserverName) : base(lbvserverName)
        {
        }
        
        public double? DataLength { get; set; }
        public double? DataOffset { get; set; }
        public string TcpProfileName { get; set; }
    }
}