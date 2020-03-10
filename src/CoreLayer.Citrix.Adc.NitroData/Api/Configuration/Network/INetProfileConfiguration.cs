namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Network
{
    public interface INetProfileConfiguration
    {
        string Name { get; set; }
        string TrafficDomain { get; set; } //[JsonPropertyName("td")]
        string SourceIp { get; set; } //[JsonPropertyName("srcip")]
        string SourceIpPersistency { get; set; } //[JsonPropertyName("srcippersistency")]
        string OverrideLsn { get; set; }
        string NatRule { get; set; }
        string NetMask { get; set; }
        string RewriteIp { get; set; }
        string Mbf { get; set; }
        string ProxyProtocol { get; set; }
        string ProxyProtocolTxVersion { get; set; }
        double? Count { get; set; } //[JsonPropertyName("__count")]
    }
}