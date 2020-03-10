namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver.LbvserverUpdateRequestDatas
{
    public class LbvserverUpdateSslBridgeRequestData : LbvserverUpdateRequestData
    {
        public LbvserverUpdateSslBridgeRequestData(string lbvserverName) : base(lbvserverName)
        {
        }
        
        public string IpV46 { get; set; } 
        public string IpPattern { get; set; }
        public string IpMask { get; set; }
        public string PersistenceType { get; set; }
        public string TcpProfileName { get; set; }
    }
}