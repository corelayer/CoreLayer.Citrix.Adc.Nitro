using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.ContentSwitching
{
    public class CsvserverStats
    {
        public string Name { get; set; }
        [JsonPropertyName("curclntconnections")]public string CurrentClientConnections { get; set; }
        [JsonPropertyName("establishedconn")]public string EstablishedConnections { get; set; }
        [JsonPropertyName("totalpktssent")]public string TotalPacketsSent { get; set; }
        [JsonPropertyName("labelledconn")]public string LabelledConnections { get; set; }
        [JsonPropertyName("tothits")]public string TotalHits { get; set; }
        public string TotalRequests { get; set; }
        [JsonPropertyName("sothreshold")]public string SpillOverThreshold { get; set; }
        [JsonPropertyName("cursubflowconn")]public string CurrentSubFlowConnections { get; set; }
        public double? ResponseBytesRate { get; set; }
        public string InvalidRequestResponseDropped { get; set; }
        public string TotalResponses { get; set; }
        public double? RequestBytesRate { get; set; }
        [JsonPropertyName("avgcltttlb")]public string AverageClientTimeToLastByte { get; set; }
        public string Type { get; set; }
        public double? HitsRate { get; set; }
        [JsonPropertyName("cursrvrconnections")]public string CurrentServerConnections { get; set; }
        [JsonPropertyName("cltresponsetimeapdex")]public double? ClientResponseTimeApdex { get; set; }
        [JsonPropertyName("totcltttlbtransactions")]public string TotalClientTimeToLastByteTransactions { get; set; }
        [JsonPropertyName("pktsrecvdrate")]public double? PacketsReceivedRate { get; set; }
        public string PrimaryIpAddress { get; set; }
        public string PushLabel { get; set; }
        [JsonPropertyName("toleratingttlbtransactions")]public string ToleratingTimeToLastByteTransactions { get; set; }
        public double? ResponsesRate { get; set; }
        [JsonPropertyName("deferredreq")]public string DeferredRequests { get; set; }
        [JsonPropertyName("curmptcpsessions")]public string CurrentMultiPathTcpSessions { get; set; }
        [JsonPropertyName("totspillovers")]public string TotalSpillovers { get; set; }
        public string TotalRequestBytes { get; set; }
        public string InvalidRequestResponse { get; set; }
        public string State { get; set; }
        [JsonPropertyName("deferredreqrate")]public double? DeferredRequestsRate { get; set; }
        [JsonPropertyName("totalpktsrecvd")]public string TotalPacketsReceived { get; set; }
        [JsonPropertyName("pktssentrate")]public double? PacketsSentRate { get; set; }
        [JsonPropertyName("frustratingttlbtransactions")]public string FrustratingTimeToLastByteTransactions { get; set; }
        public string TotalResponseBytes { get; set; }
        public int? PrimaryPort { get; set; }
        public double? RequestsRate { get; set; }
        [JsonPropertyName("totvserverdownbackuphits")]public string TotalVirtualServerDownBackupHits { get; set; }
        [JsonPropertyName("httpmaxhdrszpkts")]public string HttpMaxHeaderSizePackets { get; set; }
        [JsonPropertyName("tcpmaxooopkts")]public string TcpMaxOutOfOrderPackets { get; set; }
        [JsonPropertyName("frustratingttlbtransactionsrate")]public double? FrustratingTimeToLastByteTransactionsRate { get; set; }
        [JsonPropertyName("toleratingttlbtransactionsrate")]public double? ToleratingTimeToLastByteTransactionsRate { get; set; }
    }
}