using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network
{
    public class InatStats
    {
        public string Name { get; set; }
        [JsonPropertyName("nat46tottcp46")]public string Nat46TotalTcp46Translations { get; set; }
        [JsonPropertyName("nat46tcp46rate")]public double? Nat46Tcp46TranslationsRate { get; set; }
        [JsonPropertyName("nat46totudp46")]public string Nat46TotalUdp46Translations { get; set; }
        [JsonPropertyName("nat46udp46rate")]public double? Nat46Udp46TranslationsRate { get; set; }
        [JsonPropertyName("nat46toticmp46")]public string Nat46TotalIcmp46Translations { get; set; }
        [JsonPropertyName("nat46icmp46rate")]public double? Nat46Icmp46TranslationsRate { get; set; }
        [JsonPropertyName("nat46totdrop46")]public string Nat46TotalDrop46 { get; set; }
        [JsonPropertyName("nat46drop46rate")]public double? Nat46Drop46Rate { get; set; }
        [JsonPropertyName("nat46tottcp64")]public string Nat46TotalTcp64Translations { get; set; }
        [JsonPropertyName("nat46tcp64rate")]public double? Nat46Tcp64TranslationsRate { get; set; }
        [JsonPropertyName("nat46totudp64")]public string Nat46TotalUdp64Translations { get; set; }
        [JsonPropertyName("nat46udp64rate")]public double? Nat46Udp64TranslationsRate { get; set; }
        [JsonPropertyName("nat46toticmp64")]public string Nat46TotalIcmp64Translations { get; set; }
        [JsonPropertyName("nat46icmp64rate")]public double? Nat46Icmp64TranslationsRate { get; set; }
        [JsonPropertyName("nat46totdrop64")]public string Nat46TotalDrop64 { get; set; }
        [JsonPropertyName("nat46drop64rate")]public double? Nat46Drop64Rate { get; set; }
        [JsonPropertyName("inatnat46tcp46")]public string InatNat46Tcp46Translations { get; set; }
        [JsonPropertyName("inatnat46tcp46rate")]public double? InatNat46Tcp46TranslationsRate { get; set; }
        [JsonPropertyName("inatnat46udp46")]public string InatNat46Udp46Translations { get; set; }
        [JsonPropertyName("inatnat46udp46rate")]public double? InatNat46Udp46TranslationsRate { get; set; }
        [JsonPropertyName("inatnat46icmp46")]public string InatNat46Icmp46Translations { get; set; }
        [JsonPropertyName("inatnat46icmp46rate")]public double? InatNat46Icmp46TranslationsRate { get; set; }
        [JsonPropertyName("inatnat46drop46")]public string InatNat46Drop46 { get; set; }
        [JsonPropertyName("inatnat46drop46rate")]public double? InatNat46Drop46Rate { get; set; }
        [JsonPropertyName("inatnat46tcp64")]public string InatNat46Tcp64Translations { get; set; }
        [JsonPropertyName("inatnat46tcp64rate")]public double? InatNat46Tcp64TranslationsRate {get; set; }
        [JsonPropertyName("inatnat46udp64")]public string InatNat46Udp64Translations { get; set; }
        [JsonPropertyName("inatnat46udp64rate")]public double? InatNat46Udp64TranslationsRate { get; set; }
        [JsonPropertyName("inatnat46icmp64")]public string InatNat46Icmp64Translations { get; set; }
        [JsonPropertyName("inatnat46icmp64rate")]public double? InatNat46Icmp64TranslationsRate { get; set; }
        [JsonPropertyName("inatnat46drop64")]public string InatNat46Drop64 { get; set; }
        [JsonPropertyName("inatnat46drop64rate")]public double? InatNat46Drop64Rate { get; set; }

    }
}