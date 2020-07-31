using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network
{
    public class Nat64Stats
    {
        [JsonPropertyName("nat64icmpsessionsrate")]public double? Nat64IcmpSessionsRate { get; set; }
        [JsonPropertyName("nat64toticmpsessions")]public string Nat64TotalIcmpSessions { get; set; }
        [JsonPropertyName("nat64sessionsrate")]public double? Nat64SessionsRate { get; set; }
        [JsonPropertyName("nat64totsessions")]public string Nat64TotalSessions { get; set; }
        [JsonPropertyName("nat64udpsessionsrate")]public double? Nat64UdpSessionsRate { get; set; }
        [JsonPropertyName("nat64totudpsessions")]public string Nat64TotalUdpSessions { get; set; }
        [JsonPropertyName("nat64tcpsessionsrate")]public double? Nat64TcpSessionsRate { get; set; }
        [JsonPropertyName("nat64tottcpsessions")]public string Nat64TotalTcpSessions { get; set; }
    }
}