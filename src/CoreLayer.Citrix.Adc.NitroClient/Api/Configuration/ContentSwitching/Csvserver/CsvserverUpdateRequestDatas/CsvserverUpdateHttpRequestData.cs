namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csvserver.CsvserverUpdateRequestDatas
{
    public class CsvserverUpdateHttpRequestData : CsvserverUpdateRequestData
    {
        public CsvserverUpdateHttpRequestData(string csvServerName) : base(csvServerName)
        {
        }
        
        public string Cacheable { get; set; } 
        public string RedirectUrl { get; set; } 
        public string RedirectPortRewrite { get; set; }
        public string InsertVserverIpPort { get; set; } 
        public string VipHeader { get; set; }
        public string AuthenticationHost { get; set; } 
        public string Authentication { get; set; }
        public string Authn401 { get; set; }
        public string AuthnVsName { get; set; }
        public string Push { get; set; }
        public string PushVserver { get; set; }
        public string PushLabel { get; set; }
        public string PushMulticlients { get; set; }
        public string TcpProfileName { get; set; }
        public string HttpProfileName { get; set; }
        public string AuthnProfile { get; set; }
    }
}