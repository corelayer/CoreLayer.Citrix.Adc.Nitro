using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ssl
{
    public class SslvServerStats
    {
        public string VserverName { get; set; }    
        public string VslbHealth { get; set; }    
        public string PrimaryIpAddress { get; set; }    
        public double? PrimaryPort { get; set; }    
        public string Type { get; set; }    
        public string State { get; set; }    
        public string ActSvcs { get; set; }    
        public string SslTotClientAuthSuccess { get; set; }    
        public double? SslClientAuthSuccessRate { get; set; }    
        public string SslTotClientAuthFailure { get; set; }    
        public double? SslClientAuthFailureRate { get; set; }    
        public string SslCtxTotEncBytes { get; set; }    
        public double? SslCtxEncBytesRate { get; set; }    
        public string SslCtxTotDecBytes { get; set; }    
        public double? SslCtxDecBytesRate { get; set; }    
        public string SslCtxTotHwEncBytes { get; set; }    
        public double? SslCtxHwEncBytesRate { get; set; }    
        [JsonPropertyName("sslctxtothwdec_bytes")]public string SslCtxTotHwDecBytes { get; set; }    
        [JsonPropertyName("sslctxhwdec_bytesrate")]public double? SslCtxHwDecBytesRate { get; set; }    
        public string SslCtxTotSessionNew { get; set; }    
        public double? SslCtxSessionNewRate { get; set; }    
        public string SslCtxTotSessionHits { get; set; }    
        public double? SslCtxSessionHitsRate { get; set; }
    }
}