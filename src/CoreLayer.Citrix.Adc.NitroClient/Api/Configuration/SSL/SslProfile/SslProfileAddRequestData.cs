using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.SSL.SslProfile
{
    public class SslProfileAddRequestData : INitroRequestData
    {
        public string Name { get; }

        public SslProfileAddRequestData(string profileName)
        {
            Name = profileName;
        }
        
        public string SslProfileType { get; set; }
        [JsonPropertyName("dhcount")]public double? DhKeyPairInteractionsCount { get; set; }
        [JsonPropertyName("dh")]public string DhKeyExchange { get; set; }
        public string DhFile { get; set; }
        [JsonPropertyName("ersa")]public string EphemeralRsa { get; set; }
        [JsonPropertyName("ersacount")]public double? EphemeralRsaCount { get; set; }
        [JsonPropertyName("sessreuse")]public string SessionReuse { get; set; }
        [JsonPropertyName("sesstimeout")]public double? SessionTimeout { get; set; }
        public string CipherRedirect { get; set; }
        public string CipherUrl { get; set; }
        [JsonPropertyName("clientauth")]public string ClientAuthentication { get; set; }
        [JsonPropertyName("clientcert")]public string ClientCertificate { get; set; }
        [JsonPropertyName("dhkeyexpsizelimit")]public string DhKeySizeLimit { get; set; }
        public string SslRedirect { get; set; }
        public string RedirectPortReWrite { get; set; }
        public string Ssl3 { get; set; }
        public string Tls1 { get; set; }
        public string Tls11 { get; set; }
        public string Tls12 { get; set; }
        [JsonPropertyName("snienable")]public string ServerNameIndicationEnable { get; set; }
        public string OcspStapling { get; set; }
        [JsonPropertyName("serverauth")]public string ServerAuthentication { get; set; }
        public string CommonName { get; set; }
        [JsonPropertyName("pushenctrigger")]public string PushEncryptionTrigger { get; set; }
        public string SendCloseNotify { get; set; }
        public int? CleartextPort { get; set; }
        public string InsertionEncoding { get; set; }
        [JsonPropertyName("denysslreneg")]public string DenySslRenegotiation { get; set; }
        public string QuantumSize { get; set; }
        [JsonPropertyName("strictcachecks")]public string StrictCertificateAuthorityChecks { get; set; }
        [JsonPropertyName("encrypttriggerpktcount")]public double? EncryptTriggerPacketCount { get; set; }
        public double? PushFlag { get; set; }
        [JsonPropertyName("dropreqwithnohostheader")]public string DropRequestsWithNoHostHeader { get; set; }
        [JsonPropertyName("pushenctriggertimeout")]public double? PushEncTriggerTimeout { get; set; }
        public double? SslTriggerTimeout { get; set; }
        [JsonPropertyName("clientauthuseboundcachain")]public string ClientAuthenticationUseBoundCerticateAuthorityChain { get; set; }
        public string SslInterception { get; set; }
        [JsonPropertyName("sslireneg")]public string SslIRenegotiation { get; set; }
        [JsonPropertyName("ssliocpscheck")]public string SslIocspCheck { get; set; }
        [JsonPropertyName("sslimaxsessperserver")]public double? SslIMaxSessionPerServer { get; set; }
        public string SessionTicket { get; set; }
        public double? SessionTicketLifetime { get; set; }
        public string SessionTicketKeyRefresh { get; set; }
        public string SessionTicketKeyData { get; set; }
        public double? SessionKeyLifetime { get; set; }
        [JsonPropertyName("prevsessionkeylifetime")]public double? PreviousSessionKeyLifetime { get; set; }
        public string Hsts { get; set; }
        public double? MaxAge { get; set; }
        public string IncludeSubDomains { get; set; }
        [JsonPropertyName("skipclientcertpolicycheck")]public string SkipClientCertificatePolicyCheck { get; set; }

    }
}