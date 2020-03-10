namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbmonitor.LbmonitorUpdateRequestDatas
{
    public class LbmonitorUpdateHttpRequestData : LbmonitorUpdateRequestData
    {
        public LbmonitorUpdateHttpRequestData(string monitorName) : base(monitorName)
        {
        }

        public string Type => "HTTP";
        public string[] RespCode { get; set; }
        public string HttpRequest { get; set; }
        public string CustomHeaders { get; set; }
        public string Lrtm { get; set; }
        public double? Deviation { get; set; }
        public string Units1 { get; set; } 
        public string DestIp { get; set; }
        public int? DestPort { get; set; }
        public string Transparent { get; set; } 
        public string IpTunnel { get; set; } 
        public string Tos { get; set; } 
        public double? TosId { get; set; }
        public double? TrofsCode { get; set; }
        public string Trofsstring { get; set; }
    }
}