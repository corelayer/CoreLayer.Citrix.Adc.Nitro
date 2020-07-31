using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbmonitor
{
    public abstract class LbmonitorUpdateRequestData : INitroRequestData
    {
        public string MonitorName { get; }

        public LbmonitorUpdateRequestData(string monitorName)
        {
            MonitorName = monitorName;
        }
        
        public int? Interval { get; set; } 
        [JsonPropertyName("units3")]public string IntervalUnits { get; set; }
        [JsonPropertyName("resptimeout")]public int? ResponseTimeout { get; set; } 
        [JsonPropertyName("units4")]public string ResponseTimeoutUnits { get; set; }
        [JsonPropertyName("resptimeoutthresh")]public double? ResponseTimeoutThreshold { get; set; }
        public int? Retries { get; set; } 
        public int? FailureRetries { get; set; } 
        public int? AlertRetries { get; set; } 
        public int? SuccessRetries { get; set; } 
        public int? Downtime { get; set; }
        [JsonPropertyName("units2")]public string DowntimeUnits { get; set; }
        public string State { get; set; } 
        public string Reverse { get; set; }
        public string Secure { get; set; }
        public string NetProfile { get; set; }
        public string SslProfile { get; set; }
    }
}