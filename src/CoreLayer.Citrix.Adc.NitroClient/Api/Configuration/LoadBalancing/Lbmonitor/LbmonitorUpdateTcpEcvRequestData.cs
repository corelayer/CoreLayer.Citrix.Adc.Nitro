namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbmonitor
{
    public class LbmonitorUpdateTcpEcvRequestData : LbmonitorUpdateRequestData
    {
        public LbmonitorUpdateTcpEcvRequestData(string monitorName) : base(monitorName)
        {
        }

        public string Type => "TCP-ECV";
        public string Send { get; set; }
        public string Recv { get; set; }
        public string Lrtm { get; set; }
        public double? Deviation { get; set; }
        public string Units1 { get; set; } 
        public string DestIp { get; set; }
        public int? DestPort { get; set; }
        public string Transparent { get; set; } 
        public string IpTunnel { get; set; } 
        public string Tos { get; set; } 
        public double? TosId { get; set; }
    }
}