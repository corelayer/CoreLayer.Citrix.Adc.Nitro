namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Network
{
    public interface IIpsetConfiguration
    {
        string Name { get; set; }
        string TrafficDomain { get; set; } //[JsonPropertyName("td")]
        double? Count { get; set; } //[JsonPropertyName("__count")]
    }
}