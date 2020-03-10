using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.NS.NsHttpProfile
{
    public class NsHttpProfileUpdateRequestData : INitroRequestData
    {
        public string Name { get; }

        public NsHttpProfileUpdateRequestData(string profileName)
        {
            Name = profileName;
        }
        
        public string DropInvalReqs { get; set; }
        public string MarkHttp09Inval { get; set; }
        public string MarkConnReqInval { get; set; }
        public string CmpOnPush { get; set; }
        public string ConMultiplex { get; set; }
        public double? MaxReusePool { get; set; }
        public string DropExtraCrlf { get; set; }
        public double? IncomphdrDelay { get; set; }
        public string WebSocket { get; set; }
        public string RtspTunnel { get; set; }
        public double? ReqTimeout { get; set; }
        public string AdptTimeout { get; set; }
        public string ReqTimeoutAction { get; set; }
        public string DropExtraData { get; set; }
        public string WebLog { get; set; }
        public string ClientIpHdrExpr { get; set; }
        public double? MaxReq { get; set; }
        public string PersistentEtag { get; set; }
        public string Spdy { get; set; }
        public string Http2 { get; set; }
        public string Http2Direct { get; set; }
        public string AltSvc { get; set; }
        public double? ReusePoolTimeout { get; set; }
        public double? MaxHeaderLen { get; set; }
        public double? MinReusePool { get; set; }
        public double? Http2MaxHeaderListSize { get; set; }
        public double? Http2MaxFrameSize { get; set; }
        public double? Http2MaxConcurrentStreams { get; set; }
        public double? Http2InitialWindowSize { get; set; }
        public double? Http2HeaderTableSize { get; set; }
        public double? Http2MinSeverConn { get; set; }
        public double? ApdexcltRespTimeThreshold { get; set; }
    }
}