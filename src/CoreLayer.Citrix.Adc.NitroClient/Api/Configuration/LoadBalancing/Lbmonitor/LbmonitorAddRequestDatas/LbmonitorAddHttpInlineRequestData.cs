namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbmonitor.LbmonitorAddRequestDatas
{
    public class LbmonitorAddHttpInlineRequestData : LbmonitorAddRequestData
    {
        public string MonitorName { get; }
        public string Type => "HTTP-INLINE";
        
        public LbmonitorAddHttpInlineRequestData(string monitorName)
        {
            MonitorName = monitorName;
        }
        
        public string Action { get; set; }
        public string[] RespCode { get; set; }
        public string HttpRequest { get; set; }
        public string CustomHeaders { get; set; }
        
        
    }
}