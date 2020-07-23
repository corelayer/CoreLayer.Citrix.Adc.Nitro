namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Vpn
{
    public class VpnVserverStats
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string State { get; set; }
        public int? PrimaryPort { get; set; }
        public string PrimaryIpAddress { get; set; }
        public string TotalRequests { get; set; }
        public double? RequestsRate { get; set; }
        public string TotalResponses { get; set; }
        public double? ResponsesRate { get; set; }
        public string TotalRequestBytes { get; set; }
        public double? RequestBytesRate { get; set; }
        public string TotalResponseBytes { get; set; }
        public double? ResponseBytesRate { get; set; }
    }
}