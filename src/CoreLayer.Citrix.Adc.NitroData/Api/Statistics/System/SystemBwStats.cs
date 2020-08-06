using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.System
{
    public class SystemBwStats
    {
            [JsonPropertyName("httpcltpoolinactive")]public string HttpClientPoolInactive { get; set; }    
            [JsonPropertyName("httpcltpooloutactive")]public string HttpClientPoolOutactive { get; set; }    
            [JsonPropertyName("httpsvr200okresp")]public string HttpServer200OkResponse { get; set; }    
            [JsonPropertyName("httpsvr200okresprate")]public double? HttpServer200OkResponseRate { get; set; }    
            [JsonPropertyName("httpsvr404notfound")]public string HttpServer404NotFound { get; set; }    
            [JsonPropertyName("httpsvr404notfoundrate")]public double? HttpServer404NotFoundRate { get; set; }    
            [JsonPropertyName("httpclterrstray")]public string HttpClientErrorStray { get; set; }    
            [JsonPropertyName("httpclterrstrayrate")]public double? HttpClientErrorStrayRate { get; set; }    
            [JsonPropertyName("httpcltttfplwm")]public string HttpClientTtfpLwmFailures { get; set; }    
            [JsonPropertyName("httpcltttfplwmrate")]public double? HttpCltTtfpLwmFailuresRate { get; set; }    
            [JsonPropertyName("httpcltttfp_0")]public string HttpClientTtfpBand0Failures { get; set; }    
            [JsonPropertyName("httpcltttfp_0rate")]public double? HttpClientTtfpBand0FailuresRate { get; set; }    
            [JsonPropertyName("httpcltttfp_1")]public string HttpClientTtfpBand1Failures { get; set; }    
            [JsonPropertyName("httpcltttfp_1rate")]public double? HttpClientTtfpBand1FailuresRate { get; set; }    
            [JsonPropertyName("httpcltttfp_2")]public string HttpClientTtfpBand2Failures { get; set; }    
            [JsonPropertyName("httpcltttfp_2rate")]public double? HttpClientTtfpBand2FailuresRate { get; set; }    
            [JsonPropertyName("httpcltttfp_3")]public string HttpClientTtfpBand3Failures { get; set; }    
            [JsonPropertyName("httpcltttfp_3rate")]public double? HttpClientTtfpBand3FailuresRate { get; set; }    
            [JsonPropertyName("httpcltttfp_4")]public string HttpClientTtfpBand4Failures { get; set; }    
            [JsonPropertyName("httpcltttfp_4rate")]public double? HttpClientTtfpBand4FailuresRate { get; set; }    
            [JsonPropertyName("httpcltttfp_5")]public string HttpClientTtfpBand5Failures { get; set; }    
            [JsonPropertyName("httpcltttfp_5rate")]public double? HttpClientTtfpBand5FailuresRate { get; set; }    
            [JsonPropertyName("httpcltttfp_6")]public string HttpClientTtfpBand6Failures { get; set; }    
            [JsonPropertyName("httpcltttfp_6rate")]public double? HttpClientTtfpBand6FailuresRate { get; set; }    
            [JsonPropertyName("httpcltttfp_7")]public string HttpClientTtfpBand7Failures { get; set; }    
            [JsonPropertyName("httpcltttfp_7rate")]public double? HttpClientTtfpBand7FailuresRate { get; set; }    
            [JsonPropertyName("httpcltttfphwm")]public string HttpClientTtfpHwmFailures { get; set; }    
            [JsonPropertyName("httpcltttfphwmrate")]public double? HttpClientTtfpHwmFailuresRate { get; set; }    
            [JsonPropertyName("httpcltttfpmax")]public string HttpClientTtfpMax { get; set; }    
            [JsonPropertyName("httpcltttlplwm")]public string HttpClientTtlpLwmFailures { get; set; }    
            [JsonPropertyName("httpcltttlplwmrate")]public double? HttpClientTtlpLwmFailuresRate { get; set; }    
            [JsonPropertyName("httpcltttlp_0")]public string HttpCltTtlpBand0Failures { get; set; }    
            [JsonPropertyName("httpcltttlp_0rate")]public double? HttpClientTtlpBand0Failuresrate { get; set; }    
            [JsonPropertyName("httpcltttlp_1")]public string HttpClientTtlpBand1Failures { get; set; }    
            [JsonPropertyName("httpcltttlp_1rate")]public double? HttpClientTtlpBand1FailuresRate { get; set; }    
            [JsonPropertyName("httpcltttlp_2")]public string HttpClientTtlpBand2Failures { get; set; }    
            [JsonPropertyName("httpcltttlp_2rate")]public double? HttpClientTtlpBand2FailuresRate { get; set; }    
            [JsonPropertyName("httpcltttlp_3")]public string HttpClientTtlpBand3Failures { get; set; }    
            [JsonPropertyName("httpcltttlp_3rate")]public double? HttpClientTtlpBand3FailuresRate { get; set; }    
            [JsonPropertyName("httpcltttlp_4")]public string HttpClientTtlpBand4Failures { get; set; }    
            [JsonPropertyName("httpcltttlp_4rate")]public double? HttpClientTtlpBand4FailuresRate { get; set; }    
            [JsonPropertyName("httpcltttlp_5")]public string HttpClientTtlpBand5Failures { get; set; }    
            [JsonPropertyName("httpcltttlp_5rate")]public double? HttpClientTtlpBand5FailuresRate { get; set; }    
            [JsonPropertyName("httpcltttlp_6")]public string HttpClientTtlpBand6Failures { get; set; }    
            [JsonPropertyName("httpcltttlp_6rate")]public double? HttpClientTtlpBand6FailuresRate { get; set; }    
            [JsonPropertyName("httpcltttlp_7")]public string HttpClientTtlpBand7Failures { get; set; }    
            [JsonPropertyName("httpcltttlp_7rate")]public double? HttpClientTtlpBand7FailuresRate { get; set; }    
            [JsonPropertyName("httpcltttlphwm")]public string HttpClientTtlpHwmFailures { get; set; }    
            [JsonPropertyName("httpcltttlphwmrate")]public double? HttpClientTtlpHwmRate { get; set; }    
            [JsonPropertyName("httpcltttlpmax")]public string HttpClientTtlpMax { get; set; }
    }
}