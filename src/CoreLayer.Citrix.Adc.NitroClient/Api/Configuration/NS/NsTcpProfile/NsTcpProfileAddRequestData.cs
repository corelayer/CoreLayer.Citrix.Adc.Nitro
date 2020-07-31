using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.NS.NsTcpProfile
{
    public class NsTcpProfileAddRequestData : INitroRequestData
    {
        public string Name { get; }

        public NsTcpProfileAddRequestData(string profileName)
        {
            Name = profileName;
        }
        
        [JsonPropertyName("ws")]public string WindowScaling { get; set; }
        [JsonPropertyName("sack")]public string SelectiveAcknowledgement { get; set; }
        [JsonPropertyName("wsval")]public double? WindowScalingValue { get; set; }
        public string Nagle { get; set; }
        [JsonPropertyName("ackonpush")]public string AcknowledgementOnPush { get; set; }
        [JsonPropertyName("mss")]public double? MaximumSegmentSize { get; set; }
        public double? MaxBurst { get; set; }
        [JsonPropertyName("initialcwnd")]public double? InitialCongestionWindow { get; set; }
        [JsonPropertyName("delayedack")]public double? DelayedAcknowledgement { get; set; }
        [JsonPropertyName("oooqsize")]public double? OutOfOrderPacketQueueSize { get; set; }
        [JsonPropertyName("maxpktpermss")]public double? MaxPacketsPerMaximumSegmentSize { get; set; }
        [JsonPropertyName("pktperretx")]public double? PacketPerRetransmit { get; set; }
        [JsonPropertyName("minrto")]public double? MinimumRetransmitionsTimeout { get; set; }
        [JsonPropertyName("slowstartincr")]public double? SlowStartIncrement { get; set; }
        public double? Buffersize { get; set; }
        [JsonPropertyName("syncookie")]public string SynCookie { get; set; }
        [JsonPropertyName("kaprobeupdatelastactivity")]public string KeepAliveProbeUpdateLastActivity { get; set; }
        public string Flavor { get; set; }
        public string DynamicReceiveBuffering { get; set; }
        [JsonPropertyName("ka")]public string KeepAlive { get; set; }
        [JsonPropertyName("kaconnidletime")]public double? KeepAliveConnectionIdleTime { get; set; }
        [JsonPropertyName("kamaxprobes")]public double? KeepAliveMaxProbes { get; set; }
        [JsonPropertyName("kaprobeinterval")]public double? KeepAliveProbeInterval { get; set; }
        [JsonPropertyName("sendbuffsize")]public double? SendBufferSize { get; set; }
        [JsonPropertyName("mptcp")]public string MultiPathTcp { get; set; }
        [JsonPropertyName("establishclientconn")]public string EstablishClientConnection { get; set; }
        [JsonPropertyName("tcpsegoffload")]public string TcpSegmentOffload { get; set; }
        public string RstWindowAttenuate { get; set; }
        [JsonPropertyName("rstmaxack")]public string RstMaxAcknowledgement { get; set; }
        public string SpoofSynDrop { get; set; }
        [JsonPropertyName("ecn")]public string ExplicitCongestionNotification { get; set; }
        [JsonPropertyName("mptcpdropdataonpreestsf")]public string MultiPathTcpDropDataOnPreEstablishedSubFlow { get; set; }
        [JsonPropertyName("mptcpfastopen")]public string MultiPathTcpFastOpen { get; set; }
        [JsonPropertyName("mptcpsessiontimeout")]public double? MultiPathTcpSessionTimeout { get; set; }
        public string TimeStamp { get; set; }
        [JsonPropertyName("dsack")]public string DSack { get; set; }
        [JsonPropertyName("ackaggregation")]public string AcknowledgementAggregation { get; set; }
        [JsonPropertyName("frto")]public string ForwardRtoRecovery { get; set; }
        [JsonPropertyName("maxcwnd")]public double? MaxCongestionWindow { get; set; }
        [JsonPropertyName("fack")]public string ForwardAcknowledgement { get; set; } 
        public string TcpMode { get; set; }
        public string TcpFastOpen { get; set; }
        public string HyStart { get; set; }
        [JsonPropertyName("dupackthresh")]public double? DuplicateAcknowledgementThreshold { get; set; }
        public string BurstRateControl { get; set; }
        public double? TcpRate { get; set; }
        [JsonPropertyName("rateqmax")]public double? RateQueueMax { get; set; }
        [JsonPropertyName("drophalfclosedconnontimeout")]public string DropHalfClosedConnectionOnTimeout { get; set; }
        [JsonPropertyName("dropestconnontimeout")]public string DropEstablishedConnectionOnTimeout { get; set; }
        public string ApplyAdaptiveTcp { get; set; }
        public double? TcpFastOpenCookieSize { get; set; }
    }
}