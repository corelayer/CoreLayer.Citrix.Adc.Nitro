using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Vpn
{
    public class VpnStats
    {
        [JsonPropertyName("indexhtmlhit")]public string IndexHtmlHit { get; set; }        
        [JsonPropertyName("indexhtmlnoserved")]public string IndexHtmlNotServed { get; set; }        
        [JsonPropertyName("cfghtmlserved")]public string ConfigurationHtmlServed { get; set; }        
        [JsonPropertyName("cfghtmlservedrate")]public double? ConfigurationHtmlServedRate { get; set; }        
        [JsonPropertyName("dnsreqhit")]public string DnsRequestHit { get; set; }        
        [JsonPropertyName("dnsreqhitrate")]public double? DnsRequestHitRate { get; set; }        
        [JsonPropertyName("winsrequesthit")]public string WinsRequestHit { get; set; }        
        [JsonPropertyName("winsrequesthitrate")]public double? WinsRequestHitRate { get; set; }        
        [JsonPropertyName("csrequesthit")]public string ClientToServerRequestHit { get; set; }        
        [JsonPropertyName("csrequesthitrate")]public double? ClientToServerRequestHitRate { get; set; }        
        [JsonPropertyName("csnonhttpprobehit")]public string ClientToServerNonHttpProbeHit { get; set; }        
        [JsonPropertyName("csnonhttpprobehitrate")]public double? ClientToServerNonHttpProbeHitRate { get; set; }        
        [JsonPropertyName("cshttpprobehit")]public string ClientToServerHttpProbeHit { get; set; }        
        [JsonPropertyName("cshttpprobehitrate")]public double? ClientToServerHttpProbeHitRate { get; set; }        
        [JsonPropertyName("totalcsconnsucc")]public string TotalClientToServerConnectionSuccess { get; set; }        
        [JsonPropertyName("csconnsuccrate")]public double? ClientToServerConnectionSuccessRate { get; set; }        
        [JsonPropertyName("totalfsrequest")]public string TotalFileSystemRequest { get; set; }        
        [JsonPropertyName("fsrequestrate")]public double? FileSystemRequestRate { get; set; }        
        [JsonPropertyName("vpnlicensefail")]public string VpnLicenseFail { get; set; }        
        [JsonPropertyName("iipdisabledmipused")]public string IipDisabledMipUsed { get; set; }        
        [JsonPropertyName("iipdisabledmipusedrate")]public double? IipDisabledMipUsedRate { get; set; }        
        [JsonPropertyName("iipfailedmipused")]public string IipFailedMipUsed { get; set; }        
        [JsonPropertyName("iipfailedmipusedrate")]public double? IipFailedMipUsedRate { get; set; }        
        [JsonPropertyName("iipspillovermipused")]public string IipSpillOverMipUsed { get; set; }        
        [JsonPropertyName("iipspillovermipusedrate")]public double? IipSpillOverMipUsedRate { get; set; }        
        [JsonPropertyName("iipdisabledmipdisabled")]public string IipDisabledMipDisabled { get; set; }        
        [JsonPropertyName("iipdisabledmipdisabledrate")]public double? IipDisabledMipDisabledRate { get; set; }        
        [JsonPropertyName("iipfailedmipdisabled")]public string IipFailedMipDisabled { get; set; }        
        [JsonPropertyName("iipfailedmipdisabledrate")]public double? IipFailedMipDisabledRate { get; set; }        
        [JsonPropertyName("socksmethreqrcvd")]public string SocksMethodRequestsReceived { get; set; }        
        [JsonPropertyName("socksmethreqrcvdrate")]public double? SocksMethodRequestsReceivedRate { get; set; }        
        [JsonPropertyName("socksmethreqsent")]public string SocksMethodRequestsSent { get; set; }        
        [JsonPropertyName("socksmethreqsentrate")]public double? SocksMethodRequestsSentRate { get; set; }        
        [JsonPropertyName("socksmethresprcvd")]public string SocksMethodResponseReceived { get; set; }        
        [JsonPropertyName("socksmethresprcvdrate")]public double? SocksMethodResponseReceivedRate { get; set; }        
        [JsonPropertyName("socksmethrespsent")]public string SocksMethodResponseSent { get; set; }        
        [JsonPropertyName("socksmethrespsentrate")]public double? SocksMethodResponseSentRate { get; set; }        
        [JsonPropertyName("socksconnreqrcvd")]public string SocksConnectionRequestsReceived { get; set; }        
        [JsonPropertyName("socksconnreqrcvdrate")]public double? SocksConnectionRequestsReceivedRate { get; set; }        
        [JsonPropertyName("socksconnreqsent")]public string SocksConnectionRequestsSent { get; set; }        
        [JsonPropertyName("socksconnreqsentrate")]public double? SocksConnectionRequestsSentRate { get; set; }        
        [JsonPropertyName("socksconnresprcvd")]public string SocksConnectionResponseReceived { get; set; }        
        [JsonPropertyName("socksconnresprcvdrate")]public double? SocksConnectionResponseReceivedRate { get; set; }        
        [JsonPropertyName("socksconnrespsent")]public string SocksConnectionResponseSent { get; set; }        
        [JsonPropertyName("socksconnrespsentrate")]public double? SocksConnectionResponseSentRate { get; set; }        
        [JsonPropertyName("socksservererror")]public string SocksServerError { get; set; }        
        [JsonPropertyName("socksservererrorrate")]public double? SocksServerErrorRate { get; set; }        
        [JsonPropertyName("socksclienterror")]public string SocksClientError { get; set; }        
        [JsonPropertyName("socksclienterrorrate")]public double? SocksClientErrorRate { get; set; }        
        [JsonPropertyName("staconnsuccess")]public string StaConnectionSuccess { get; set; }        
        [JsonPropertyName("staconnsuccessrate")]public double? StaConnectionSuccessRate { get; set; }        
        [JsonPropertyName("staconnfailure")]public string StaConnectionFailure { get; set; }        
        [JsonPropertyName("staconnfailurerate")]public double? StaConnectionFailureRate { get; set; }        
        [JsonPropertyName("cpsconnsuccess")]public string CpsConnectionSuccess { get; set; }        
        [JsonPropertyName("cpsconnsuccessrate")]public double? CpsConnectionSuccessRate { get; set; }        
        [JsonPropertyName("cpsconnfailure")]public string CpsConnectionFailure { get; set; }        
        [JsonPropertyName("cpsconnfailurerate")]public double? CpsConnectionFailureRate { get; set; }        
        [JsonPropertyName("starequestsent")]public string StaRequestSent { get; set; }        
        [JsonPropertyName("starequestsentrate")]public double? StaRequestSentRate { get; set; }        
        [JsonPropertyName("staresponserecvd")]public string StaResponseReceived { get; set; }        
        [JsonPropertyName("staresponserecvdrate")]public double? StaResponseReceivedRate { get; set; }        
        [JsonPropertyName("icalicensefailure")]public string IcaLicenseFailure { get; set; }        
        [JsonPropertyName("icalicensefailurerate")]public double? IcaLicenseFailureRate { get; set; }        
        [JsonPropertyName("stamonsent")]public string StaMonitorRequestsSent { get; set; }        
        [JsonPropertyName("stamonsentrate")]public double? StaMonitorRequestsSentRate { get; set; }        
        [JsonPropertyName("stamonrcvd")]public string StaMonitorRequestsReceived { get; set; }        
        [JsonPropertyName("stamonrcvdrate")]public double? StaMonitorRequestsReceivedRate { get; set; }        
        [JsonPropertyName("stamonsucc")]public string StaMonitorSuccessfulResponse { get; set; }        
        [JsonPropertyName("stamonsuccrate")]public double? StaMonitorSuccessfulResponseRate { get; set; }        
        [JsonPropertyName("stamonfail")]public string StaMonitorFailure { get; set; }        
        [JsonPropertyName("stamonfailrate")]public double? StaMonitorFailureRate { get; set; }        
        [JsonPropertyName("csgptktvalidatenotstarted")]public string CitrixSecureGatewayPrimaryTicketValidateNotStarted { get; set; }        
        [JsonPropertyName("csgptktvalidatenotstartedrate")]public double? CitrixSecureGatewayPrimaryTicketValidateNotStartedRate { get; set; }        
        [JsonPropertyName("csgrtktvalidatenotstarted")]public string CitrixSecureGatewayRedundantTicketValidateNotStarted { get; set; }        
        [JsonPropertyName("csgrtktvalidatenotstartedrate")]public double? CitrixSecureGatewayRedundantTicketValidateNotStartedRate { get; set; }
    }
}