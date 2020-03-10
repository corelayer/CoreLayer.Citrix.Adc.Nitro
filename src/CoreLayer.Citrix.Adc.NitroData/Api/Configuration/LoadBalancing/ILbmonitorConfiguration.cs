namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.LoadBalancing
{
    public interface ILbmonitorConfiguration
    {
        string MonitorName { get; set; }
        string Type { get; set; }
        string Action { get; set; }
        string[] ResponseCodes { get; set; } //[JsonPropertyName("respcode")]
        string HttpRequest { get; set; }
        string RtspRequest { get; set; }
        string CustomHeaders { get; set; }
        string MaxForwards { get; set; }
        string SipMethod { get; set; } 
        string SipUri { get; set; }
        string SipRegisterUri { get; set; } //[JsonPropertyName("sipreguri")]
        string Send { get; set; }
        string Receive { get; set; } //[JsonPropertyName("recv")]
        string Query { get; set; }
        string QueryType { get; set; }
        string ScriptName { get; set; }
        string ScriptArgs { get; set; }
        string DispatcherIp { get; set; }
        int? DispatcherPort { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string SecondaryPassword { get; set; }
        string LogonPointName { get; set; }
        string LasVersion { get; set; }
        string RadKey { get; set; }
        string RadNetworkAccessServerId { get; set; } //[JsonPropertyName("radnasid")]
        string RadNetworkAccessServerIp { get; set; } //[JsonPropertyName("radnasip")]
        string RadAccountType { get; set; }
        string RadFramedIp { get; set; }
        string RadApn { get; set; }
        string RadMsisdn { get; set; }
        string RadAccountSession { get; set; }
        string LeastResponseTimes { get; set; } //[JsonPropertyName("lrtm")]
        string Deviation { get; set; }
        string UnitsDeviation { get; set; } //[JsonPropertyName("units1")]
        int? Interval { get; set; }
        string UnitsInterval { get; set; } //[JsonPropertyName("units3")]
        int? ResponseTimeout { get; set; } //[JsonPropertyName("resptimeout")]
        string UnitsResponseTimeout { get; set; } //[JsonPropertyName("units4")]
        string ResponseTimeoutThreshold { get; set; } //[JsonPropertyName("resptimeoutthresh")]
        int? Retries { get; set; }
        int? FailureRetries { get; set; }
        int? AlertRetries { get; set; }
        int? SuccessRetries { get; set; }
        int? DownTime { get; set; }
        string UnitsDownTime { get; set; } //[JsonPropertyName("units2")]
        string DestinationIp { get; set; } //[JsonPropertyName("destip")]
        int? DestinationPort { get; set; } //[JsonPropertyName("destport")]
        string State { get; set; }
        string Reverse { get; set; }
        string Transparent { get; set; }
        string IpTunnel { get; set; }
        string TypeOfService { get; set; } //[JsonPropertyName("tos")]
        double? TypeOfServiceId { get; set; } //[JsonPropertyName("tosid")]
        string Secure { get; set; }
        string ValidateCred { get; set; }
        string Domain { get; set; }
        string[] IpAddress { get; set; }
        string Group { get; set; }
        string FileName { get; set; }
        string BaseDistinguishedName { get; set; } //[JsonPropertyName("basedn")]
        string BindDistinguishedName { get; set; } //[JsonPropertyName("binddn")]
        string Filter { get; set; }
        string Attribute { get; set; }
        string DataBase { get; set; }
        string OracleServiceId { get; set; } //[JsonPropertyName("oraclesid")]
        string SqlQuery { get; set; }
        string EvaluationRule { get; set; } //[JsonPropertyName("evalrule")]
        string MsSqlProtocolVersion { get; set; }
        string SnmpOid { get; set; }
        string SnmpCommunity { get; set; }
        string SnmpThreshold { get; set; }
        string SnmpVersion { get; set; }
        string MetricTable { get; set; }
        string Application { get; set; }
        string SitePath { get; set; }
        string StoreName { get; set; }
        string StoreFrontAcctService { get; set; }
        string HostName { get; set; }
        string NetProfile { get; set; }
        string OriginHost { get; set; }
        string OriginRealm { get; set; }
        string HostIpAddress { get; set; }
        string VendorId { get; set; }
        string ProductName { get; set; }
        string FirmwareVersion { get; set; }
        double[] AuthenticationApplicationId { get; set; } //[JsonPropertyName("authapplicationId")]
        double[] AccountApplicationId { get; set; } //[JsonPropertyName("acctapplicationid")]
        string InBandSecurityId { get; set; }
        double[] SupportedVendorIds { get; set; }
        string VendorSpecificVendorId { get; set; }
        double[] VendorSpecificAuthApplicationIds { get; set; }
        double[] VendorSpecificAcctApplicationIds { get; set; }
        string KdcAccount { get; set; }
        string StoreDatabase { get; set; } //[JsonPropertyName("storedb")]
        string StoreFrontCheckBackendServices { get; set; }
        string TrofsCode { get; set; }
        string TrofsString { get; set; }
        string SslProfile { get; set; }
        string Metric { get; set; }
        string MetricThreshold { get; set; }
        string MetricWeight { get; set; }
        string ServiceName { get; set; }
        string ServicegroupName { get; set; }
        int? LeastResponseTimesConfigurationState { get; set; } //[JsonPropertyName("lrtmconf")]
        string LeastResponseTimesConfigurationString { get; set; } //[JsonPropertyName("lrtmconfstr")]
        int? DynamicResponseTimeout { get; set; }
        int? DynamicInterval { get; set; }
        string[] MultiMetricTable { get; set; }
        string DupState { get; set; } //[JsonPropertyName("dup_state")]
        string DupWeight { get; set; } //[JsonPropertyName("dup_weight")]
        string Weight { get; set; }
        bool? Ca { get; set; }
        double? Count { get; set; } //[JsonPropertyName("__count")]
        }
}