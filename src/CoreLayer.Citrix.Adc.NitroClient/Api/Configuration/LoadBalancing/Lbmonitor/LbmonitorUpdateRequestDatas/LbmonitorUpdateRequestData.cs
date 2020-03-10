using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbmonitor.LbmonitorUpdateRequestDatas
{
    public abstract class LbmonitorUpdateRequestData : INitroRequestData
    {
        public string MonitorName { get; }

        public LbmonitorUpdateRequestData(string monitorName)
        {
            MonitorName = monitorName;
        }
        
        public int? Interval { get; set; } 
        public string Units3 { get; set; }
        public int? RespTimeout { get; set; } 
        public string Units4 { get; set; }
        public double? RespTimeoutThresh { get; set; }
        public int? Retries { get; set; } 
        public int? FailureRetries { get; set; } 
        public int? AlertRetries { get; set; } 
        public int? SuccessRetries { get; set; } 
        public int? Downtime { get; set; }
        public string Units2 { get; set; }
        public string State { get; set; } 
        public string Reverse { get; set; }
        public string Secure { get; set; }
        public string NetProfile { get; set; }
        public string SslProfile { get; set; }
    }
}