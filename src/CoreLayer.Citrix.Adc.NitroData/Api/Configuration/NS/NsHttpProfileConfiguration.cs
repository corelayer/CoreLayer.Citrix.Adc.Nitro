namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.NS
{
    public class NsHttpProfileConfiguration
    {
        public string Name { get; set; }
        public string DropInvalReqs { get; set; }
        public string MarkHttp09Inval { get; set; }
        public string MarkConnReqInval { get; set; }
        public string MarkTraceReqInval { get; set; }
        public string MarkRfc7230NonCompliantInval { get; set; }
        public string CmpOnPush { get; set; }
        public string ConMultiPlex { get; set; }
        public string MaxReusePool { get; set; }
        public string WebSocket { get; set; }
        public string RefCnt { get; set; } 
        public string DropExtraCrlf { get; set; }
        public string InCompHdrDelay { get; set; } 
        public string ReqTimeout { get; set; } 
        public string AdptTimeout { get; set; } 
        public string ReqTimeoutAction { get; set; }
        public string DropExtraData { get; set; }
        public string Weblog { get; set; }
        public string ClientIpHdrExpr { get; set; }
        public string MaxReq { get; set; } 
        public string PersistentEtag { get; set; }
        public string Spdy { get; set; }
        public string Http2 { get; set; }
        public string Http2Direct { get; set; }
        public string Http2StrictCipher { get; set; }
        public string AltSvc { get; set; }
        public string Http2MaxHeaderListSize { get; set; }
        public string Http2MaxFrameSize { get; set; }
        public string Http2MaxConcurrentStreams { get; set; }
        public string Http2InitialWindowSize { get; set; }
        public string Http2HeaderTableSize { get; set; }
        public string Http2MinSeverConn { get; set; }
        public string Http2MaxPingFramesPerMin { get; set; }
        public string Http2MaxSettingsFramesPerMin { get; set; }
        public string Http2MaxResetFramesPerMin { get; set; }
        public string Http2MaxEmptyFramesPerMin { get; set; }
        public string ReusePoolTimeout { get; set; }
        public string MaxHeaderLen { get; set; }
        public string RtspTunnel { get; set; }
        public string MinReusePool { get; set; }
        public string[] BuiltIn { get; set; }
        public string Feature { get; set; }
        public string ApdexSvrRespTimeThreshold { get; set; }
        public string ApdexCltRespTimeThreshold { get; set; }
        
    }
}