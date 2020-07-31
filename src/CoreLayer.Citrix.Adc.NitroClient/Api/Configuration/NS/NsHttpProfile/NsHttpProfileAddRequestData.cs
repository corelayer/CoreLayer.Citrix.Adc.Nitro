using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.NS.NsHttpProfile
{
    public class NsHttpProfileAddRequestData : INitroRequestData
    {
        public string Name { get; }

        public NsHttpProfileAddRequestData(string profileName)
        {
            Name = profileName;
        }
        
        [JsonPropertyName("dropinvalreqs")]public string DropInvalidRequests { get; set; }
        [JsonPropertyName("markhttp09inval")]public string MarkHttp09RequestsInvalid { get; set; }
        [JsonPropertyName("markconnreqinval")]public string MarkConnectRequestInvalid { get; set; }
        [JsonPropertyName("cmponpush")]public string CompressionOnPush { get; set; }
        [JsonPropertyName("conmultiplex")]public string ConnectionMultiplex { get; set; }
        public double? MaxReusePool { get; set; }
        [JsonPropertyName("dropextracrlf")]public string DropExtraCrLfCharacters { get; set; }
        [JsonPropertyName("incomphdrdelay")]public double? IncompleteHeaderDelay { get; set; }
        public string WebSocket { get; set; }
        public string RtspTunnel { get; set; }
        [JsonPropertyName("reqtimeout")]public double? RequestTimeout { get; set; }
        [JsonPropertyName("adpttimeout")]public string AdaptTimeout { get; set; }
        [JsonPropertyName("reqtimeoutaction")]public string RequestTimeoutAction { get; set; }
        public string DropExtraData { get; set; }
        public string WebLog { get; set; }
        [JsonPropertyName("clientiphdrexpr")]public string ClientIpHeaderExpression { get; set; }
        [JsonPropertyName("maxreq")]public double? MaxRequests { get; set; }
        public string PersistentEtag { get; set; }
        [JsonPropertyName("spdy")]public string EnableSpdy { get; set; }
        public string Http2 { get; set; }
        public string Http2Direct { get; set; }
        [JsonPropertyName("altsvc")]public string AlternativeService { get; set; }
        public double? ReusePoolTimeout { get; set; }
        [JsonPropertyName("maxheaderlen")]public double? MaxHeaderLength { get; set; }
        public double? MinReusePool { get; set; }
        public double? Http2MaxHeaderListSize { get; set; }
        public double? Http2MaxFrameSize { get; set; }
        public double? Http2MaxConcurrentStreams { get; set; }
        public double? Http2InitialWindowSize { get; set; }
        public double? Http2HeaderTableSize { get; set; }
        [JsonPropertyName("http2minseverconn")]public double? Http2MinSeverConnections { get; set; }
        [JsonPropertyName("apdexcltresptimethreshold")]public double? ApdexClientResponseTimeThreshold { get; set; }
    }
}