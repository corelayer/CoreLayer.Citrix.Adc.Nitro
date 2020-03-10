using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.SSL.SslProfile
{
    public class SslProfileUpdateRequestData : INitroRequestData
    {
        public string Name { get; }

        public SslProfileUpdateRequestData(string profileName)
        {
            Name = profileName;
        }
        
        public double? DhCount { get; set; }
        public string Dh { get; set; }
        public string DhFile { get; set; }
        public string Ersa { get; set; }
        public double? ErsaCount { get; set; }
        public string SessReUse { get; set; }
        public double? SessTimeout { get; set; }
        public string CipherRedirect { get; set; }
        public string CipherUrl { get; set; }
        public string ClientAuth { get; set; }
        public string ClientCert { get; set; }
        public string DhKeyExpSizeLimit { get; set; }
        public string SslRedirect { get; set; }
        public string RedirectPortReWrite { get; set; }
        public string Ssl3 { get; set; }
        public string Tls1 { get; set; }
        public string Tls11 { get; set; }
        public string Tls12 { get; set; }
        public string SniEnable { get; set; }
        public string OcspStapling { get; set; }
        public string ServerAuth { get; set; }
        public string CommonName { get; set; }
        public string PushEncTrigger { get; set; }
        public string SendCloseNotify { get; set; }
        public int? CleartextPort { get; set; }
        public string InsertionEncoding { get; set; }
        public string DenySslReneg { get; set; }
        public string QuantumSize { get; set; }
        public string StrictCaChecks { get; set; }
        public double? EncryptTriggerPktCount { get; set; }
        public double? PushFlag { get; set; }
        public string DropReqWithNoHostHeader { get; set; }
        public double? PushEncTriggerTimeout { get; set; }
        public double? SslTriggerTimeout { get; set; }
        public string ClientAuthUseBoundCaChain { get; set; }
        public string SslInterception { get; set; }
        public string SslIreNeg { get; set; }
        public string SslIocspCheck { get; set; }
        public double? SslMMaxSessPerServer { get; set; }
        public string SessionTicket { get; set; }
        public double? SessionTicketLifetime { get; set; }
        public string SessionTicketKeyRefresh { get; set; }
        public string SessionTicketKeyData { get; set; }
        public double? SessionKeyLifetime { get; set; }
        public double? PrevSessionKeyLifetime { get; set; }
        public string Hsts { get; set; }
        public double? MaxAge { get; set; }
        public string IncludeSubDomains { get; set; }
        public string SkipClientCertPolicyCheck { get; set; }
        public string CipherName { get; set; }
        public double? CipherPriority { get; set; }
        public string StrictSigDigestCheck { get; set; }
        
    }
}