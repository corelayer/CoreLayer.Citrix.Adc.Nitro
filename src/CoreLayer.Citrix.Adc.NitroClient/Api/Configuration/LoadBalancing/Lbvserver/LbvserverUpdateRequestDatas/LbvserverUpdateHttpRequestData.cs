namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver.LbvserverUpdateRequestDatas
{
    public class LbvserverUpdateHttpRequestData : LbvserverUpdateRequestData
    {
        public LbvserverUpdateHttpRequestData(string lbvserverName) : base(lbvserverName)
        {
        }
        
        public string IpV46 { get; set; } 
        public string IpPattern { get; set; }
        public string IpMask { get; set; }
        public string PersistenceType { get; set; }
        public string RedirUrl { get; set; }
        public string Cacheable { get; set; }
        public string RedirectPortRewrite { get; set; }
        public string InsertVserverIpPort { get; set; }
        public string VipHeader { get; set; }
        public string AuthenticationHost { get; set; }
        public string Authentication { get; set; } 
        public string Authn401 { get; set; }
        public string AuthnVsName { get; set; }
        public string TcpProfileName { get; set; }
        public string HttpProfileName { get; set; }
        public string AuthnProfile { get; set; }
    }
}