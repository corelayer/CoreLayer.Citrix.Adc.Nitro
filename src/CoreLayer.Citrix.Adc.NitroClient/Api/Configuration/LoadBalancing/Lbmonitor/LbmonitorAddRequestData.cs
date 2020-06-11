using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbmonitor
{
    public abstract class LbmonitorAddRequestData : INitroRequestData
    {
        
        //private string RtspRequest { get; set; }
        //public double? MaxForwards { get; set; }
        //public string SipMethod { get; set; } 
        //public string SipUri { get; set; } 
        //public string SipRegUri { get; set; } 
        //public string Query { get; set; }
        //private string QueryType { get; set; }
        //public string ScriptName { get; set; }
        //public string ScriptArgs { get; set; } 
        //public string DispatcherIp { get; set; }
        //public int? DispatcherPort { get; set; }
        //public string UserName { get; set; }
        //public string Password { get; set; } 
        //public string SecondaryPassword { get; set; }
        //public string LogonPointName { get; set; }
        //public string LasVersion { get; set; }
        //public string RadKey { get; set; }
//        string RadnasId { get; }
//        string RadnasIp { get; }
//        double RadAccountType { get; }
//        string RadFrameDip { get; }
//        string RadApn { get; }
//        string RadMsisdn { get; }
//        string RadAccountSession { get; }
        public int? Interval { get; set; } 
        public string Units3 { get; set; }
        public int? RespTimeout { get; set; } 
        public string Units4 { get; set; }
        public double? RespTimeoutThresh { get; set; }
        public int? Retries { get; set; } 
        public int? FailureRetries { get; set; } 
        public int? AlertRetries { get; set; } 
        public int? SuccessRetries { get; set; } 
        public int? Downtime { get; set; }
        public string Units2 { get; set; }
        public string State { get; set; } 
        public string Reverse { get; set; }
        public string Secure { get; set; }
        //public string ValidateCred { get; set; }
        //public string Domain { get; set; }
        //public string[]? IpAddress { get; set; }
        //public string Group { get; set; }
        //public string FileName { get; set; }
        //public string BaseDn { get; set; }
        //string BindDn { get; }
        //string Filter { get; }
        //string Attribute { get; }
        //string Database { get; }
        //string OraclesId { get; }
        //string SqlQuery { get; }
        //string EvalRule { get; }
        //string MsSqlProtocolVersion { get; }
//        string SnmpOid { get; }
//        string SnmpCommunity {get;}
//        string SnmpThreshold {get;}
//        string SnmpVersion {get;}
        //public string MetricTable { get; set; }
//        string Application {get;}
//        string Sitepath {get;}
//        string Storename {get;}
//        string StorefrontAcctService {get;}
//        string Hostname {get;}
          public string NetProfile { get; set; }
//        string OriginHost {get;}
//        string OriginRealm {get;}
        //public string HostIpAddress { get; set; }
//        double VendorId {get;}
//        string ProductName {get;}
//        double FirmwareRevision {get;}
//        double[] AuthApplicationId {get;}
//        double[] AcctApplicationId {get;}
//        string InbandSecurityId { get; }
//        double[] SupportedVendorIds { get; }
//        double VendorSpecificVendorId { get; }
//        double[] VendorSpecificAuthApplicationIds { get; }
//        double[] VendorSpecificAcctApplicationIds { get; }
//        string KcdAccount { get; }
//        string StoreDb { get; }
//        string StoreFrontCheckBackendServices { get; }
            public string SslProfile { get; set; }
//        

    }
}