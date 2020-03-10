using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.NS.NsTcpProfile
{
    public class NsTcpProfileUpdateRequestData : INitroRequestData
    {
                public string Name { get; }

        public NsTcpProfileUpdateRequestData(string profileName)
        {
            Name = profileName;
        }
        
        public string Ws { get; set; }
        public string Sack { get; set; }
        public double? WsVal { get; set; }
        public string Nagle { get; set; }
        public string AckOnPush { get; set; }
        public double? Mss { get; set; }
        public double? MaxBurst { get; set; }
        public double? InitialCwnd { get; set; }
        public double? DelayEdAck { get; set; }
        public double? OooQSize { get; set; }
        public double? MaxPktPermss { get; set; }
        public double? PktPerrextx { get; set; }
        public double? Minrto { get; set; }
        public double? SlozStartIncr { get; set; }
        public double? Buffersize { get; set; }
        public string SynCookie { get; set; }
        public string KaProbeUpdateLastActivity { get; set; }
        public string Flavor { get; set; }
        public string DynamicReceiveBuffering { get; set; }
        public string Ka { get; set; }
        public double? KaConnIdleTime { get; set; }
        public double? KaMaxProbes { get; set; }
        public double? KaProbeInterval { get; set; }
        public double? SendBuffSize { get; set; }
        public string MpTcp { get; set; }
        public string EstablishClientConn { get; set; }
        public string TcpSegOffload { get; set; }
        public string RstWindowAttenuate { get; set; }
        public string RstMaxAck { get; set; }
        public string SpoofSynDrop { get; set; }
        public string Ecn { get; set; }
        public string MpTcpDropDataOnPreestsf { get; set; }
        public string MpTcpFastOpen { get; set; }
        public double? MpTcpSessionTimeout { get; set; }
        public string TimeStamp { get; set; }
        public string DSack { get; set; }
        public string AckAggregation { get; set; }
        public string Frto { get; set; }
        public double? MaxCwnd { get; set; }
        public string FAck { get; set; } 
        public string TcpMode { get; set; }
        public string TcpFastOpen { get; set; }
        public string HyStart { get; set; }
        public double? DupAckThresh { get; set; }
        public string BurstRateControl { get; set; }
        public double? TcpRate { get; set; }
        public double? RateQMax { get; set; }
        public string DropHalfClosedConnOnTimeout { get; set; }
        public string DropEstConnOnTimeout { get; set; }
        public string ApplyAdaptiveTcp { get; set; }
        public double? TcpFastOpenCookieSize { get; set; }
    }
}