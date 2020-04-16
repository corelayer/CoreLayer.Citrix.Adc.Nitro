using System.Dynamic;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Ssl
{
    public class SslProfileConfiguration
    {
        
        public string Name { get; set; }
        public string Dh { get; set; }
        public string DhFile { get; set; }
        public string DhCount { get; set; }
        public string DhKeyExpSizeLimit { get; set; } 
        public string Ersa { get; set; }
        public string ErsaCount { get; set; }
        public string SessReuse { get; set; }
        public string SessTimeout { get; set; }
        public string CipherRedirect { get; set; }
        public string CipherUrl { get; set; }
        public string ClientAuth { get; set; }
        public string ClientCert { get; set; }
        public string SslRedirect { get; set; }
        public string RedirectPortRewrite { get; set; }
        public string NonFipsCiphers { get; set; }
        public string Ssl3 { get; set; }
        public string Tls1 { get; set; }
        public string Tls11 { get; set; }
        public string Tls12 { get; set; }
        public string Tls13 { get; set; }
        public string SniEnable { get; set; }
        public string OcspStapling { get; set; }
        public string ServerAuth { get; set; }
        public string CommonName { get; set; }
        public string PushEncTrigger { get; set; }
        public string SendCloseNotify { get; set; }
        public int ClearTextPort { get; set; }
        public string InsertionEncoding { get; set; }
        public string DenySslReneg { get; set; }
        public string QuantumSize { get; set; }
        public string StrictCaChecks { get; set; }
        public string EncryptTriggerPktCount { get; set; }
        public string PushFlag { get; set; } 
        public string DropReqWithNoHostHeader { get; set; }
        public string SniHttpHostMatch { get; set; }
        public string PushEncTriggerTimeout { get; set; }
        public string SslTriggerTimeout { get; set; } 
        public string CipherPriority { get; set; }
        public string CipherName { get; set; }
        public string CrlCheck { get; set; }
        public string OcspCheck { get; set; }
        public bool SniCert { get; set; }
        public bool SkipCaName { get; set; }
        public bool Invoke { get; set; }
        public string LabelType { get; set; }
        public string SslProfileType { get; set; }
        public string ClientAuthUseBoundCaChain { get; set; }
        public string SslLogProfile { get; set; }
        public string Service { get; set;  }
        public string[] BuiltIn { get; set; }
        public string Feature { get; set; }
        public string SslPfObjectType { get; set; } 
        public string SslInterception { get; set; }
        public string SsliVerifyServerCertForReuse { get; set; }
        public string SsliReneg { get; set; }
        public string SsliOcspCheck { get; set; }
        public string SsliMaxSessPerServer { get; set; } 
        public string SessionTicket { get; set; }
        public string SessionTicketLifetime { get; set; }
        public string SessionTicketKeyRefresh { get; set; }
        public string SessionTicketKeyData { get; set; }
        public string SessionKeyLifetime { get; set; } 
        public string PrevSessionKeyLifetime { get; set; }
        public string Hsts { get; set; }
        public string MaxAge { get; set; } 
        public string IncludeSubdomains { get; set; }
        public string Preload { get; set; }
        public string StrictSigDigestCheck { get; set; }
        public string SkipClientCertPolicyCheck { get; set; }
        public string ZeroRttEarlyData { get; set; }
        public string Tls13SessionTicketsPerAuthContext { get; set;  }
        public string DheKeyExchangeWithPsk { get; set; }

    }
}