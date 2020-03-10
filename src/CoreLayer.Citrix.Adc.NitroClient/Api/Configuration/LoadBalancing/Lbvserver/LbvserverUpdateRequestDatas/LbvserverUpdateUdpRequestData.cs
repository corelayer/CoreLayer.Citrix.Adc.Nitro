namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver.LbvserverUpdateRequestDatas
{
    public class LbvserverUpdateUdpRequestData : LbvserverUpdateRequestData
    {
        public LbvserverUpdateUdpRequestData(string lbvserverName) : base(lbvserverName)
        {
        }
        
        public string IpV46 { get; set; } 
        public string IpPattern { get; set; }
        public string IpMask { get; set; }
        public string PersistenceType { get; set; }
        public string SkipPersistency { get; set; }
    }
}