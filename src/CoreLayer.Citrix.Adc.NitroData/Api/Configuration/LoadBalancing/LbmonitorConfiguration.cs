using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.LoadBalancing
{
    public class LbmonitorConfiguration //: ILbmonitorConfiguration
    {
        public string MonitorName { get; set; }
        public string Type { get; set; }
        public string Action { get; set; }
        [JsonPropertyName("respcode")]public string[] ResponseCodes { get; set; }
        public string HttpRequest { get; set; }
        public string RtspRequest { get; set; }
        public string CustomHeaders { get; set; }
        public string MaxForwards { get; set; }
        [JsonPropertyName("sipmethod")]public string SipMethod { get; set; } //todo
        public string SipUri { get; set; }
        [JsonPropertyName("sipreguri")]public string SipUriUser { get; set; }
        public string Send { get; set; }
        [JsonPropertyName("recv")]public string Receive { get; set; }
        public string Query { get; set; }
        public string QueryType { get; set; }
        public string ScriptName { get; set; }
        [JsonPropertyName("scriptargs")]public string ScriptArguments { get; set; }
        public string DispatcherIp { get; set; }
        public int? DispatcherPort { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string SecondaryPassword { get; set; }
        public string LogonPointName { get; set; }
        [JsonPropertyName("lasversion")]public string CitrixAdvancedAccessControlLogonAgentVersion { get; set; }
        [JsonPropertyName("radkey")]public string RadiusKey { get; set; }
        [JsonPropertyName("radnasid")]public string RadiusNasId { get; set; } //todo
        [JsonPropertyName("radnasip")]public string RadiusNasIp { get; set; }
        [JsonPropertyName("radaccounttype")]public string RadiusAccountType { get; set; }
        [JsonPropertyName("radframedip")]public string RadiusFramedIp { get; set; }
        [JsonPropertyName("radapn")]public string RadiusCalledStationId { get; set; }
        [JsonPropertyName("radmsisdn")]public string RadiusCallingStationsId { get; set; }
        [JsonPropertyName("radaccountsession")]public string RadiusAccountSession { get; set; }
        [JsonPropertyName("lrtm")]public string LeastResponseTime { get; set; }
        public string Deviation { get; set; }
        [JsonPropertyName("units1")]public string DeviationUnits { get; set; }
        public int? Interval { get; set; }
        [JsonPropertyName("units3")]public string IntervalUnits { get; set; }
        [JsonPropertyName("resptimeout")]public int? ResponseTimeout { get; set; }
        [JsonPropertyName("units4")]public string ResponseTimeoutUnits { get; set; }
        [JsonPropertyName("resptimeoutthresh")]public string ResponseTimeoutThreshold { get; set; }
        public int? Retries { get; set; }
        public int? FailureRetries { get; set; }
        public int? AlertRetries { get; set; }
        public int? SuccessRetries { get; set; }
        public int? DownTime { get; set; }
        [JsonPropertyName("units2")]public string DownTimeUnits { get; set; }
        [JsonPropertyName("destip")]public string DestinationIp { get; set; }
        [JsonPropertyName("destport")]public int? DestinationPort { get; set; }
        public string State { get; set; }
        public string Reverse { get; set; }
        public string Transparent { get; set; }
        public string IpTunnel { get; set; }
        [JsonPropertyName("tos")]public string Tos { get; set; } //todo
        [JsonPropertyName("tosid")]public double? TosId { get; set; } //todo
        public string Secure { get; set; }
        [JsonPropertyName("validatecred")]public string ValidateCredentials { get; set; }
        public string Domain { get; set; }
        public string[] IpAddress { get; set; }
        public string Group { get; set; }
        public string FileName { get; set; }
        [JsonPropertyName("basedn")]public string BaseDistinguishedName { get; set; }
        [JsonPropertyName("binddn")]public string BindDistinguishedName { get; set; }
        public string Filter { get; set; }
        public string Attribute { get; set; }
        public string DataBase { get; set; }
        public string OracleSId { get; set; }
        public string SqlQuery { get; set; }
        [JsonPropertyName("evalrule")]public string EvaluationRule { get; set; }
        public string MsSqlProtocolVersion { get; set; }
        [JsonPropertyName("snmpoid")]public string SnmpOid { get; set; } // todo
        public string SnmpCommunity { get; set; } //todo
        public string SnmpThreshold { get; set; }//todo
        public string SnmpVersion { get; set; }//todo
        public string MetricTable { get; set; }
        public string Application { get; set; }
        public string SitePath { get; set; }
        public string StoreName { get; set; }
        [JsonPropertyName("storefrontacctservice")]public string StoreFrontAccountService { get; set; }
        public string HostName { get; set; }
        public string NetProfile { get; set; }
        public string OriginHost { get; set; }
        public string OriginRealm { get; set; }
        public string HostIpAddress { get; set; }
        public string VendorId { get; set; }
        public string ProductName { get; set; }
        public string FirmwareVersion { get; set; }
        [JsonPropertyName("authapplicationid")]public double[] AuthenticationApplicationIds { get; set; }
        [JsonPropertyName("acctapplictionid")]public double[] AccounttApplicationIds { get; set; }
        public string InBandSecurityId { get; set; }
        public double[] SupportedVendorIds { get; set; }
        public string VendorSpecificVendorId { get; set; }
        [JsonPropertyName("vendorspecificauthapplicationids")]public double[] VendorSpecificAuthenticationApplicationIds { get; set; }
        [JsonPropertyName("vendorspecificacctapplictionids")]public double[] VendorSpecificAccountApplicationIds { get; set; }
        [JsonPropertyName("kdcaccount")]public string KdcAccount { get; set; } //todo
        [JsonPropertyName("storedb")]public string StoreDateBase { get; set; }
        public string StoreFrontCheckBackendServices { get; set; }
        public string TrofsCode { get; set; }
        public string TrofsString { get; set; }
        public string SslProfile { get; set; }
        public string Metric { get; set; }
        public string MetricThreshold { get; set; }
        public string MetricWeight { get; set; }
        public string ServiceName { get; set; }
        public string ServicegroupName { get; set; }
        [JsonPropertyName("lrtmconf")]public int? LeastResponseTimeConfiguration { get; set; } 
        [JsonPropertyName("lrtmconfstr")]public string LeastResponseTimeConfigurationString { get; set; } 
        public int? DynamicResponseTimeout { get; set; }
        public int? DynamicInterval { get; set; }
        public string[] MultiMetricTable { get; set; }
        [JsonPropertyName("dup_state")]public string DuplicateState { get; set; }
        [JsonPropertyName("dup_weight")]public string DuplicateWeight { get; set; }
        public string Weight { get; set; }
        [JsonPropertyName("ca")]public bool? Ca { get; set; } //todo
        [JsonPropertyName("__count")]public double? Count { get; set; }
    }
}