using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.NS
{
    public class NsHttpProfileConfiguration
    {
        public string Name { get; set; }
        [JsonPropertyName("dropinvalreqs")]public string DropInvalidRequests { get; set; }
        [JsonPropertyName("markhttp09inval")]public string MarkHttp09Invalid { get; set; }
        [JsonPropertyName("markconnreqinval")]public string MarkConnectionRequestInvalid { get; set; }
        [JsonPropertyName("marktracereqinval")]public string MarkTraceRequestsInvalid { get; set; }
        [JsonPropertyName("markrfc723noncompliantinval")]public string MarkRfc7230NonCompliantInvalid { get; set; }
        [JsonPropertyName("cmponpush")]public string CompressionOnPush { get; set; }
        [JsonPropertyName("conmultiplex")]public string ConnectionMultiplex { get; set; }
        public string MaxReusePool { get; set; }
        public string WebSocket { get; set; }
        [JsonPropertyName("refcnt")]public string ReferenceCount { get; set; } 
        [JsonPropertyName("dropextracrlf")]public string DropExtraCrAndLf { get; set; }
        [JsonPropertyName("incomphdrdelay")]public string IncompleteHeaderPacketsDelay { get; set; } 
        [JsonPropertyName("reqtimeout")]public string RequestTimeout { get; set; } 
        [JsonPropertyName("adpttimeout")]public string AdaptTimeout { get; set; } 
        [JsonPropertyName("reqtimeoutaction")]public string RequestTimeoutAction { get; set; }
        public string DropExtraData { get; set; }
        [JsonPropertyName("weblog")]public string WebLogging { get; set; }
        [JsonPropertyName("clientiphdrexpr")]public string ClientIpHeaderExpression { get; set; }
        [JsonPropertyName("maxreq")]public string MaxRequests { get; set; } 
        public string PersistentEtag { get; set; }
        [JsonPropertyName("spdy")]public string EnableSpdy { get; set; }
        public string Http2 { get; set; }
        public string Http2Direct { get; set; }
        public string Http2StrictCipher { get; set; }
        [JsonPropertyName("altsvc")]public string AlternativeService { get; set; }
        public string Http2MaxHeaderListSize { get; set; }
        public string Http2MaxFrameSize { get; set; }
        public string Http2MaxConcurrentStreams { get; set; }
        public string Http2InitialWindowSize { get; set; }
        public string Http2HeaderTableSize { get; set; }
        [JsonPropertyName("http2minseverconn")]public string Http2MinimumSeverConnection { get; set; }
        public string Http2MaxPingFramesPerMin { get; set; }
        public string Http2MaxSettingsFramesPerMin { get; set; }
        public string Http2MaxResetFramesPerMin { get; set; }
        public string Http2MaxEmptyFramesPerMin { get; set; }
        public string ReusePoolTimeout { get; set; }
        [JsonPropertyName("maxheaderlen")]public string MaxHeaderLength { get; set; }
        [JsonPropertyName("rtsptunnel")]public string AllowRtspTunnel { get; set; }
        [JsonPropertyName("minreusepool")]public string MinimumReusePool { get; set; }
        public string[] BuiltIn { get; set; }
        public string Feature { get; set; }
        [JsonPropertyName("apdexsvrresptimethreshold")]public string ApdexServerResponseTimeThreshold { get; set; }
        [JsonPropertyName("apdexcltresptimethreshold")]public string ApdexClientResponseTimeThreshold { get; set; }
        
    }
}