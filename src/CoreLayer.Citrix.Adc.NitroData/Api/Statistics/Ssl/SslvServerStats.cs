using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ssl
{
    public class SslvServerStats
    {
        [JsonPropertyName("vservername")]public string VirtualServerName { get; set; }    
        [JsonPropertyName("vslbhealth")]public string VirtualServerHealth { get; set; }    
        public string PrimaryIpAddress { get; set; }    
        public double? PrimaryPort { get; set; }    
        public string Type { get; set; }    
        public string State { get; set; }    
        [JsonPropertyName("actsvcs")]public string ActiveServices { get; set; }    
        [JsonPropertyName("ssltotclientauthsuccess")]public string SslTotalClientAuthenticationSuccess { get; set; }    
        [JsonPropertyName("sslclientauthsuccessrate")]public double? SslClientAuthenticationSuccessRate { get; set; }    
        [JsonPropertyName("ssltotclientauthfailure")]public string SslTotalClientAuthenticationFailure { get; set; }    
        [JsonPropertyName("sslclientauthfailurerate")]public double? SslClientAuthenticationFailureRate { get; set; }    
        [JsonPropertyName("sslCtxTotEncBytes")]public string SslCtxTotalEncryptedBytes { get; set; }    
        [JsonPropertyName("sslctxencbytesrate")]public double? SslCtxEncryptedBytesRate { get; set; }    
        [JsonPropertyName("sslctxtotdecbytes")]public string SslCtxTotalDecryptedBytes { get; set; }    
        [JsonPropertyName("sslctxdecbytesrate")]public double? SslCtxDecryptedBytesRate { get; set; }    
        [JsonPropertyName("sslctxtothwencbytes")]public string SslCtxTotalHardwareEncryptedBytes { get; set; }    
        [JsonPropertyName("sslctxhzencbytesrate")]public double? SslCtxHardwareEncryptedBytesRate { get; set; }    
        [JsonPropertyName("sslctxtothwdec_bytes")]public string SslCtxTotalHardwareDecryptedBytes { get; set; }    
        [JsonPropertyName("sslctxhwdec_bytesrate")]public double? SslCtxHardwareDecryptedBytesRate { get; set; }    
        [JsonPropertyName("sslctxtotsessionnew")]public string SslCtxTotalNewSessions { get; set; }    
        [JsonPropertyName("sslctxsessionnewrate")]public double? SslCtxNewSessionsRate { get; set; }    
        [JsonPropertyName("sslctxtotsessionhits")]public string SslCtxTotalSessionHits { get; set; }    
        public double? SslCtxSessionHitsRate { get; set; }
    }
}