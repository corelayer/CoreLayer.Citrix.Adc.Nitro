using System;
using System.Net;
using System.Net.Http;
using System.Security.Authentication;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient
{
    public static class NitroServiceHttpClientGenerator
    {
        public static HttpClient Generate(NitroHttpClientCertificateValidation certificateValidation)
        {
            var httpClient = certificateValidation == NitroHttpClientCertificateValidation.Enabled
                ? new HttpClient(GetInSecureHttpMessageHandler())
                : new HttpClient(GetSecureHttpMessageHandler());
            return httpClient;
        }

        private static HttpClientHandler GetInSecureHttpMessageHandler()
        {
            return new HttpClientHandler
            {
                UseCookies = false,
                SslProtocols = SslProtocols.Tls12,
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                ServerCertificateCustomValidationCallback = (req, cert, chain, errors) => true
            };
        }
        
        private static HttpClientHandler GetSecureHttpMessageHandler()
        {
            return new HttpClientHandler
            {
                UseCookies = false,
                SslProtocols = SslProtocols.Tls12,
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
            };
        }
    }
}