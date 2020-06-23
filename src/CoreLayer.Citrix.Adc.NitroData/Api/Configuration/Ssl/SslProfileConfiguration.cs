using System.Dynamic;
using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Ssl
{
    public class SslProfileConfiguration
    {
        
        public string Name { get; set; }
        [JsonPropertyName("dh")]public string DiffieHellmanKeyExchange { get; set; } 
        [JsonPropertyName("dhfile")]public string DiffieHellmanFile { get; set; }
        [JsonPropertyName("dhcount")]public string DiffieHellmanKeyPairInteractionsCount { get; set; }
        [JsonPropertyName("dhkeyexpsizelimit")]public string DiffieHellmanKeySizeLimit { get; set; } 
        [JsonPropertyName("ersa")]public string EphemeralRsa { get; set; }
        [JsonPropertyName("ersacount")]public string EphemeralRsaCount { get; set; }
        [JsonPropertyName("sessreuse")]public string SessionReuse { get; set; }
        [JsonPropertyName("sesstimeout")]public string SessionTimeout { get; set; }
        public string CipherRedirect { get; set; }
        public string CipherUrl { get; set; }
        [JsonPropertyName("clientauth")]public string ClientAuthentication { get; set; }
        [JsonPropertyName("clientcert")]public string ClientCertificate { get; set; }
        public string SslRedirect { get; set; }
        public string RedirectPortRewrite { get; set; }
        [JsonPropertyName("nonfipsciphers")]public string NonFipsCiphers { get; set; } //todo
        public string Ssl3 { get; set; }
        public string Tls1 { get; set; }
        public string Tls11 { get; set; }
        public string Tls12 { get; set; }
        public string Tls13 { get; set; }
        [JsonPropertyName("snienable")]public string ServerNameIndicationEnable { get; set; }
        [JsonPropertyName("ocspstapling")]public string OcspStapling { get; set; } //todo
        [JsonPropertyName("serverauth")]public string ServerAuthentication { get; set; }
        public string CommonName { get; set; }
        [JsonPropertyName("pushenctrigger")]public string PushEncryptionTrigger { get; set; }
        public string SendCloseNotify { get; set; }
        public int ClearTextPort { get; set; }
        public string InsertionEncoding { get; set; }
        [JsonPropertyName("denysslreneg")]public string DenySslRenegotiation { get; set; }
        public string QuantumSize { get; set; }
        [JsonPropertyName("strictcachecks")]public string StrictCertificateAuthorityChecks { get; set; }
        [JsonPropertyName("ecrypttriggerpktcount")]public string EncryptTriggerPacketCount { get; set; }
        public string PushFlag { get; set; } 
        [JsonPropertyName("dropreqwithnohostheader")]public string DropRequestsWithNoHostHeader { get; set; }
        [JsonPropertyName("snihttphostmatch")]public string ServerNameIndicationHttpHostMatch { get; set; }
        [JsonPropertyName("pushenctriggertimeout")]public string PushEncryptionTriggerTimeout { get; set; }
        public string SslTriggerTimeout { get; set; } 
        public string CipherPriority { get; set; }
        public string CipherName { get; set; }
        [JsonPropertyName("crlcheck")]public string CrlCheck { get; set; } //todo
        public string OcspCheck { get; set; } // todo
        [JsonPropertyName("snicert")]public bool ServerNameIndicationCertificate { get; set; }
        [JsonPropertyName("skipcaname")]public bool SkipCertificateAuthorityName { get; set; }
        public bool Invoke { get; set; }
        public string LabelType { get; set; }
        public string SslProfileType { get; set; }
        [JsonPropertyName("clientauthuseboundcachain")]public string ClientAuthenticationUseBoundCertificateAuthorityChain { get; set; }
        public string SslLogProfile { get; set; }
        public string Service { get; set;  }
        public string[] BuiltIn { get; set; }
        public string Feature { get; set; }
        [JsonPropertyName("sslpfobjecttype")]public string SslProfileObjectType { get; set; } 
        public string SslInterception { get; set; }
        [JsonPropertyName("ssliverifyservercertforreuse")]public string SslVerifyServerCertificateForReuse { get; set; }
        [JsonPropertyName("sslireneg")]public string SsliRenegotiation { get; set; } //todo
        public string SsliOcspCheck { get; set; } //todo
        public string SsliMaxSessPerServer { get; set; } //todo
        public string SessionTicket { get; set; }
        public string SessionTicketLifetime { get; set; }
        public string SessionTicketKeyRefresh { get; set; }
        public string SessionTicketKeyData { get; set; }
        public string SessionKeyLifetime { get; set; } 
        [JsonPropertyName("prevsessionkeylifetime")]public string PreviousSessionKeyLifetime { get; set; }
        [JsonPropertyName("hsts")]public string Hsts { get; set; } // todo
        public string MaxAge { get; set; } 
        public string IncludeSubdomains { get; set; }
        public string Preload { get; set; }
        [JsonPropertyName("strictsigdigestcheck")]public string StrictSignatureDigestCheck { get; set; }
        public string SkipClientCertPolicyCheck { get; set; }
        [JsonPropertyName("zerorttearlydata")]public string ZeroRttEarlyData { get; set; } //todo
        [JsonPropertyName("tls13sessionticketsperauthcontext")]public string Tls13SessionTicketsPerAuthenticationContext { get; set;  }
        public string DheKeyExchangeWithPsk { get; set; } //todo

    }
}