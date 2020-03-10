namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbmonitor.LbmonitorUpdateRequestDatas
{
    public class LbmonitorUpdateHttpInlineRequestData : LbmonitorUpdateRequestData
    {
        public LbmonitorUpdateHttpInlineRequestData(string monitorName) : base(monitorName)
        {
        }

        public string Type => "HTTP-INLINE";
        public string Action { get; set; }
        public string[] RespCode { get; set; }
        public string HttpRequest { get; set; }
        public string CustomHeaders { get; set; }
    }
}