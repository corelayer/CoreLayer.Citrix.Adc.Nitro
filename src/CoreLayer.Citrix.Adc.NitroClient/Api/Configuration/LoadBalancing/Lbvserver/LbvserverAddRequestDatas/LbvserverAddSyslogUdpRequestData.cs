namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver.LbvserverAddRequestDatas
{
    public class LbvserverAddSyslogUdpRequestData : LbvserverAddRequestData
    {
        public LbvserverAddSyslogUdpRequestData(string lbvserverName) : base(lbvserverName)
        {
        }

        public override string ServiceType { get; } = "SYSLOGUDP";
        
        
    }
}