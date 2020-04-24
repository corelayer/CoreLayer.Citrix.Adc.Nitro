namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.NS
{
    public class NsTcpProfileConfiguration
    {
        
        public string Name { get; set; }
        public string Ws { get; set; }
        public string Sack { get; set; }
        public string WsVal { get; set; }
        public string Nagle { get; set; }
        public string AckOnPush { get; set; }
        public string Mss { get; set; }
        public string MaxBurst { get; set; }
        public string InitialCwnd { get; set; }
        public string DelayedAck { get; set; }
        public string OooQSize { get; set; }
        public string MaxPktPermss { get; set; }
        public string PktPerretx { get; set; }
        public string Minrto { get; set; }
        public string SlowStartIncr { get; set; }
        public string BufferSize { get; set; }
        public string Flavor { get; set; }
        public string RefCnt { get; set; }
        public string SynCookie { get; set; }
        public string KaProbeUpdateLastActivity { get; set; }
        public string DynamicReceiveBuffering { get; set; }
        public string Ka { get; set; }
        public string KaConnIdleTime { get; set; }
        public string KaMaxProbes { get; set; }
        public string KaProbeInterval { get; set; }
        public string SendBuffSize { get; set; }
        public string MpTcp { get; set; }
        public string EstablishClientConn { get; set; }
        public string TcpSegOffload { get; set; }
        public string RstWindowAttenuate { get; set; }
        public string RstMaxAck { get; set; }
        public string TimeStamp { get; set; }
        public string SpoofSynDrop { get; set; }
        public string Ecn { get; set; }
        public string MpTcpDropDataOnPreestsf { get; set; }
        public string MpTcpFastOpen { get; set; }
        public string MpTcpSessionTimeout { get; set; }
        public string DsAck { get; set; }
        public string AckAggregation { get; set; }
        public string Frto { get; set; }
        public string Maxcwnd { get; set; }
        public string FAck { get; set; }
        public string TcpMode { get; set; }
        public string TcpFastOpen { get; set; }
        public string HyStart { get; set; }
        public string DupAckThresh { get; set; }
        public string BurstRateControl { get; set; }
        public string TcpRate { get; set; }
        public string RateQMax { get; set; }
        public string DropHalfClosedConnOnTimeout { get; set; }
        public string DropEstConnOnTimeout { get; set; }
        public string ApplyAdaptiveTcp { get; set; }
        public string[] BuiltIn { get; set; }
        public string Feature { get; set; }
        public string TcpFastOpenCookieSize { get; set; }
        public string TailLossProbe { get; set; }
        public string ClientIpTcpOption { get; set; }
        public string ClientIpTcpOptionNumber { get; set; }
    }
}