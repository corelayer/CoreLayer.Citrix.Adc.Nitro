using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic
{
    public class ServerBindingServiceGroupConfiguration
    {
        public string Name { get; set; }
        public string ServiceGroupName { get; set; }
        [JsonPropertyName("sp")]public string SurgeProtection { get; set; }
        [JsonPropertyName("sc")]public string SureConnect { get; set; }
        [JsonPropertyName("servicegroupentname2")]public string ServiceGroupEntName2 { get; set; }
        [JsonPropertyName("svcitmpriority")]public string ServiceItmPriority { get; set; }
        [JsonPropertyName("svrtimeout")]public string ServerTimeout { get; set; }
        [JsonPropertyName("serviceipstr")]public string ServiceIpString { get; set; }
        [JsonPropertyName("tcpb")]public string TcpBuffering { get; set; }
        [JsonPropertyName("cip")]public string InjectClientIp { get; set; }
        [JsonPropertyName("dup_port")]public int? DuplicatePort { get; set; }
        [JsonPropertyName("svcitmboundsvcs")]public string ServiceItmBoundServices { get; set; }
        public string CustomServerId { get; set; }
        public string Weight { get; set; }
        [JsonPropertyName("boundtd")]public string BoundTrafficDomain { get; set; }
        [JsonPropertyName("downstateflush")]public string DownStateFlush { get; set; }
        [JsonPropertyName("svctype")]public string ServiceType { get; set; }
        [JsonPropertyName("cka")]public string ClientKeepAlive { get; set; }
        [JsonPropertyName("svrstate")]public string ServerState { get; set; }
        [JsonPropertyName("appflowlog")]public string AppFlowLogging { get; set; }
        [JsonPropertyName("cipheader")]public string ClientIpHeader { get; set; }
        [JsonPropertyName("maxclient")]public string MaxClients { get; set; }
        [JsonPropertyName("clttimeout")]public string ClientTimeout { get; set; }
        public int? Port { get; set; }
        [JsonPropertyName("dup_svctype")]public string DuplicateServiceType { get; set; }
        [JsonPropertyName("cmp")]public string Compression { get; set; }
        [JsonPropertyName("monthreshold")]public string MonitorWeightThreshold { get; set; }
        [JsonPropertyName("maxreq")]public string MaxRequests { get; set; }
        public string ServiceIpAddress { get; set; }
        [JsonPropertyName("svcitmactsvcs")]public string ServiceItmActiveServices { get; set; }
        [JsonPropertyName("usip")]public string UseSourceIp { get; set; }
        public string Cacheable { get; set; }
        public string MaxBandwidth { get; set; }
        [JsonPropertyName("svrcfgflags")]public string ServerCfgFlags { get; set; }
        
    }
}