using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network
{
    public class MapBmrStats
    {
        public string Name { get; set; }
        [JsonPropertyName("bmrv6rxpktsrate")]public double? BmrV6ReceivePacketsRate { get; set; }
        [JsonPropertyName("bmrv4rxpktsudprate")]public double? BmrV4ReceivePacketsUdpRate { get; set; }
        [JsonPropertyName("bmrtotv6txpkts")]public string BmrTotalV6TransmitPackets { get; set; }
        [JsonPropertyName("bmrv6rxpktsudprate")]public double? BmrV6ReceivePacketsUdpRate { get; set; }
        [JsonPropertyName("bmrtotv6txpktsicmp")]public string BmrTotalV6TransmitPacketsIcmp { get; set; }
        [JsonPropertyName("bmrtotv4rxpktsudp")]public string BmrTotalV4ReceivePacketsUdp { get; set; }
        [JsonPropertyName("bmrv6txpktsudprate")]public double? BmrV6TransmitPacketsUdpRate { get; set; }
        [JsonPropertyName("bmrv4txpktsicmprate")]public double? BmrV4TransmitPacketsIcmpRate { get; set; }
        [JsonPropertyName("bmrtotv6rxpkts")]public string BmrTotalV6ReceivePackets { get; set; }
        [JsonPropertyName("bmrv4txpktsrate")]public double? BmrV4TransmitPacketsRate { get; set; }
        [JsonPropertyName("bmrtotv4rxpkts")]public string BmrTotalV4ReceivePackets { get; set; }
        [JsonPropertyName("bmrv4txpktstcprate")]public double? BmrV4TransmitPacketsTcpRate { get; set; }
        [JsonPropertyName("bmrv4rxpktsicmprate")]public double? BmrV4ReceivePacketsIcmpRate { get; set; }
        [JsonPropertyName("bmrv4rxpktstcprate")]public double? BmrV4ReceivePacketsTcpRate { get; set; }
        [JsonPropertyName("bmrv6txpktsicmprate")]public double? BmrV6TransmitPacketsIcmpRate { get; set; }
        [JsonPropertyName("bmrv6txpktstcprate")]public double? BmrV6TransmitPacketsTcpRate { get; set; }
        [JsonPropertyName("bmrtotv6rxpktsicmp")]public string BmrTotalV6ReceivePacketsIcmp { get; set; }
        [JsonPropertyName("bmrtotv6txpktsudp")]public string BmrTotalV6TransmitPacketsUdp { get; set; }
        [JsonPropertyName("bmrv6rxpktstcprate")]public double? BmrV6ReceivePacketsTcpRate { get; set; }
        [JsonPropertyName("bmrtotv4txpktsicmp")]public string BmrTotalV4TransmitPacketsIcmp { get; set; }
        [JsonPropertyName("bmrtotv4txpktstcp")]public string BmrTotalV4TransmitPacketsTcp { get; set; }
        [JsonPropertyName("bmrtotv4rxpktsicmp")]public string BmrTotalV4ReceivePacketsIcmp { get; set; }
        [JsonPropertyName("bmrv6txpktsrate")]public double? BmrV6TransmitPacketsRate { get; set; }
        [JsonPropertyName("bmrtotv4txpktsudp")]public string BmrTotalV4TransmitPacketsUdp { get; set; }
        [JsonPropertyName("bmrtotv4rxpktstcp")]public string BmrTotalV4ReceivePacketsTcp { get; set; }
        [JsonPropertyName("bmrtotv4txpkts")]public string BmrTotalV4TransmitPackets { get; set; }
        [JsonPropertyName("bmrv4txpktsudprate")]public double? BmrV4TransmitPacketsUdpRate { get; set; }
        [JsonPropertyName("bmrtotv6rxpktsudp")]public string BmrTotalV6ReceivePacketsUdp { get; set; }
        [JsonPropertyName("bmrtotv6txpktstcp")]public string BmrTotalV6TransmitPacketsTcp { get; set; }
        [JsonPropertyName("bmrtotv6rxpktstcp")]public string BmrTotalV6ReceivePacketsTcp { get; set; }
        [JsonPropertyName("bmrv4rxpktsrate")]public double? BmrV4ReceivePacketsRate { get; set; }
        [JsonPropertyName("bmrv6rxpktsicmprate")]public double? BmrV6ReceivePacketsIcmpRate { get; set; }
 
    }
}