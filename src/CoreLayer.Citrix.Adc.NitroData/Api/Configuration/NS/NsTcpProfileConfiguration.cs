using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.NS
{
    public class NsTcpProfileConfiguration
    {
        
        public string Name { get; set; }
        [JsonPropertyName("ws")]public string WindowScaling { get; set; }
        [JsonPropertyName("sack")] public string EnableSelectiveAcknowledgement { get; set; }
        [JsonPropertyName("wsval")]public string WindowScalingValue { get; set; }
        [JsonPropertyName("nagle")]public string EnableNagle { get; set; }
        [JsonPropertyName("ackonpush")]public string AcknowledgementOnPush { get; set; }
        [JsonPropertyName("mss")]public string MaximumOctetsAllowed { get; set; }
        public string MaxBurst { get; set; }
        [JsonPropertyName("initialcwnd")]public string InitialMaxPacketsOnTcpLink { get; set; }
        [JsonPropertyName("delayedack")]public string DelayedAcknowledgement { get; set; }
        [JsonPropertyName("oooqsize")]public string OutOfOrderPacketQueueSize { get; set; }
        [JsonPropertyName("maxpktpermss")]public string MaxPacketsPerMaximumSegmentSize { get; set; }
        [JsonPropertyName("pktperretx")]public string PacketPerRetransmit { get; set; }
        [JsonPropertyName("minrto")]public string MinimumRetransmitionsTimeout { get; set; }
        [JsonPropertyName("slowstartincr")]public string SlowStartIncrement { get; set; }
        public string BufferSize { get; set; }
        public string Flavor { get; set; }
        [JsonPropertyName("refcnt")]public string ReferenceCount { get; set; }
        [JsonPropertyName("syncookie")]public string SynCookie { get; set; } //todo
        [JsonPropertyName("kaprobeupdatelastactivity")]public string KeepAliveProbeUpdateLastActivity { get; set; }
        public string DynamicReceiveBuffering { get; set; }
        [JsonPropertyName("ka")]public string KeepAlive { get; set; }
        [JsonPropertyName("kaconnidletime")]public string KeepAliveConnectionIdleTime { get; set; }
        [JsonPropertyName("kamaxprobes")]public string KeepAliveMaxProbes { get; set; }
        [JsonPropertyName("kaprobeinterval")]public string KeepAliveProbeInterval { get; set; }
        [JsonPropertyName("sendbuffsize")]public string SendBufferSize { get; set; }
        [JsonPropertyName("mptcp")]public string MultiPathTcp { get; set; }
        [JsonPropertyName("establishclientconn")]public string EstablishClientConnection { get; set; }
        [JsonPropertyName("tcpsegoffload")]public string TcpSegmentationOffload { get; set; }
        [JsonPropertyName("rstwindowattenuate")]public string RstWindowAttenuate { get; set; } //todo
        [JsonPropertyName("rstmaxack")]public string RstMaxAcknowledgement { get; set; }
        public string TimeStamp { get; set; }
        [JsonPropertyName("spoofsyndrop")]public string SpoofSynDrop { get; set; } //todo
        [JsonPropertyName("ecn")]public string ExplicitCongestionNotification { get; set; }
        [JsonPropertyName("mptcpdropdataonpreestsf")]public string MultiPathTcpDropDataOnPreEstablishedSubFlow { get; set; }
        public string MpTcpFastOpen { get; set; }
        public string MpTcpSessionTimeout { get; set; }
        [JsonPropertyName("dsack")]public string DsAck { get; set; } //todo
        [JsonPropertyName("ackaggregation")]public string AcknowledgementAggregation { get; set; }
        [JsonPropertyName("frto")]public string ForwardRtoRecovery { get; set; }
        [JsonPropertyName("maxcwnd")]public string MaxCongestionWindow { get; set; }
        [JsonPropertyName("fack")]public string ForwardAcknowledgement { get; set; }
        public string TcpMode { get; set; }
        public string TcpFastOpen { get; set; }
        [JsonPropertyName("hystart")]public string HyStart { get; set; } //todo
        [JsonPropertyName("dupacktresh")]public string DuplicateAcknowledgementThreshold { get; set; }
        public string BurstRateControl { get; set; }
        public string TcpRate { get; set; }
        [JsonPropertyName("rateqmax")]public string RateQueueMax { get; set; }
        [JsonPropertyName("drophalfclosedconnontimeout")]public string DropHalfClosedConnectionOnTimeout { get; set; }
        [JsonPropertyName("dropestconnontimeout")]public string DropEstablishedConnectionOnTimeout { get; set; }
        public string ApplyAdaptiveTcp { get; set; }
        public string[] BuiltIn { get; set; }
        public string Feature { get; set; }
        public string TcpFastOpenCookieSize { get; set; }
        public string TailLossProbe { get; set; }
        public string ClientIpTcpOption { get; set; }
        public string ClientIpTcpOptionNumber { get; set; }
    }
}