using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Aaa
{
    public class AaaStats
    {
        [JsonPropertyName("aaaauthsuccess")]public string AaaAuthenticationSuccesses { get; set; }    
        [JsonPropertyName("aaaauthsuccessrate")]public double? AaaAuthenticationSuccessesRate { get; set; }    
        [JsonPropertyName("aaaauthfail")]public string AaaAuthenticationFailures { get; set; }    
        [JsonPropertyName("aaaauthfailrate")]public double? AaaAuthenticationFailuresRate { get; set; }    
        [JsonPropertyName("aaaauthonlyhttpsuccess")]public string AaaAuthenticationOnlyHttpSuccess { get; set; }    
        [JsonPropertyName("aaaauthonlyhttpsuccessrate")]public double? AaaAuthenticationOnlyHttpSuccessRate { get; set; }    
        [JsonPropertyName("aaaauthonlyhttpfail")]public string AaaAuthenticationOnlyHttpFail { get; set; }    
        [JsonPropertyName("aaaauthonlyhttpfailrate")]public double? AaaAuthenticationOnlyHttpFailRate { get; set; }    
        [JsonPropertyName("aaaauthnonhttpsuccess")]public string AaaAuthenticationNonHttpSuccess { get; set; }    
        [JsonPropertyName("aaaauthnonhttpsuccessrate")]public double? AaaAuthenticationNonHttpSuccessRate { get; set; }    
        [JsonPropertyName("aaaauthnonhttpfail")]public string AaaAuthenticationNonHttpFail { get; set; }    
        [JsonPropertyName("aaaauthnonhttpfailrate")]public double? AaaAuthenticationNonHttpFailRate { get; set; }    
        [JsonPropertyName("aaacursessions")]public string AaaCurrentSessions { get; set; }    
        [JsonPropertyName("aaacursessionsrate")]public double? AaaCurrentSessionsRate { get; set; }    
        [JsonPropertyName("aaatotsessions")]public string AaaTotalSessions { get; set; }    
        [JsonPropertyName("aaasessionsrate")]public double? AaaSessionsRate { get; set; }    
        [JsonPropertyName("aaatotsessiontimeout")]public string AaaTotalSessionsTimedOut { get; set; }    
        [JsonPropertyName("aaasessiontimeoutrate")]public double? AaaSessionsTimedOutRate { get; set; }    
        [JsonPropertyName("aaacuricasessions")]public string AaaCurrentIcaSessions { get; set; }    
        [JsonPropertyName("aaacuricasessionsrate")]public double? AaaCurrentIcaSessionsRate { get; set; }    
        [JsonPropertyName("aaacuriceonlyconn")]public string AaaCurrentIcaOnlyConnections { get; set; }    
        [JsonPropertyName("aaacuricaonlyconnrate")]public double? AaaCurrentIcaOnlyConnectionsRate { get; set; }    
        [JsonPropertyName("aaacuricaconn")]public string AaaCurrentIcaConnections { get; set; }    
        [JsonPropertyName("aaacuricaconnrate")]public double? AaaCurrentIcaConnectionsRate { get; set; }    
        [JsonPropertyName("aaacurtmsessions")]public string AaaCurrentTmSessions { get; set; }    
        [JsonPropertyName("aaacurtmsessionsrate")]public double? AaaCurrentTmSessionsRate { get; set; }    
        [JsonPropertyName("aaatottmsessions")]public string AaaTotalTmSessions { get; set; }    
        [JsonPropertyName("aaatmsessionsrate")]public double? AaaTmSessionsRate { get; set; }
    }
}