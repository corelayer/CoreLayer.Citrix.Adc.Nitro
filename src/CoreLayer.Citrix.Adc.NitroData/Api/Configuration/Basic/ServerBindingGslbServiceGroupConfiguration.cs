using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic
{
    public class ServerBindingGslbServiceGroupConfiguration
    {
        public string Name { get; set; }
        public string ServiceGroupName { get; set; }
        [JsonPropertyName("svrtimeout")]public string ServerTimeout { get; set; }
        [JsonPropertyName("serviceipstr")]public string ServiceIpString { get; set; }
        [JsonPropertyName("cip")]public string InjectClientIp { get; set; }
        [JsonPropertyName("dup_port")]public int? DuplicatePort { get; set; }
        [JsonPropertyName("customserverid")]public string CustomServerId { get; set; }
        [JsonPropertyName("boundtd")]public string BoundTrafficDomain { get; set; }
        public string DownStateFlush { get; set; }
        [JsonPropertyName("svctype")]public string ServiceType { get; set; }
        [JsonPropertyName("svrstate")]public string ServerState { get; set; }
        [JsonPropertyName("appflowlog")]public string AppFlowLogging { get; set; }
        [JsonPropertyName("cipheader")]public string ClientIpHeader { get; set; }
        public string MaxClient { get; set; }
        [JsonPropertyName("clttimeout")]public string ClientTimeout { get; set; }
        public int? Port { get; set; }
        [JsonPropertyName("dup_svctype")]public string DuplicateServiceType { get; set; }
        [JsonPropertyName("monthreshold")]public string MonitorWeightThreshold { get; set; }
        [JsonPropertyName("maxreq")]public string MaxRequests { get; set; }
        public string ServiceIpAddress { get; set; }
        public string MaxBandwidth { get; set; }
        [JsonPropertyName("svrcfgflags")]public string ServerCfgFlags { get; set; }
        
    }
}