namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver
{
    public class LbvserverAddSyslogUdpRequestData : LbvserverAddRequestData
    {
        public LbvserverAddSyslogUdpRequestData(string lbvserverName) : base(lbvserverName)
        {
        }

        public override string ServiceType { get; } = "SYSLOGUDP";
        
        
    }
}