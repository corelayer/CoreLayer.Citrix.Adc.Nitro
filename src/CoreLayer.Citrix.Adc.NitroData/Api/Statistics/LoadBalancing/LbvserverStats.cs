using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.LoadBalancing
{
    public class LbvserverStats
    {
        public string Name { get; set; }
        [JsonPropertyName("avgcltttlb")]public string AverageClientTimeToLastByte { get; set; }
        [JsonPropertyName("cltresponsetimeapdex")]public double? ClientResponseTimeApdexIndex { get; set; }
        [JsonPropertyName("vsvrsurgecount")]public string VirtualServerSurgeCount { get; set; }
        [JsonPropertyName("establishedconn")]public string EstablishedConnections { get; set; }
        [JsonPropertyName("inactsvcs")]public string InactiveServices { get; set; }
        [JsonPropertyName("vslbhealth")]public string VirtualServerHealth { get; set; }
        public string PrimaryIpAddress { get; set; }
        public int? PrimaryPort { get; set; }
        public string Type { get; set; }
        public string State { get; set; }
        [JsonPropertyName("actsvcs")]public string ActiveServices{ get; set; }
        [JsonPropertyName("tothits")]public string TotalHits { get; set; }
        public double? HitsRate { get; set; }
        public string TotalRequests { get; set; }
        public double? RequestsRate { get; set; }
        public string TotalResponses { get; set; }
        public double? ResponsesRate { get; set; }
        public string TotalRequestBytes { get; set; }
        public double? RequestBytesRate { get; set; }
        public string TotalResponseBytes { get; set; }
        public double? ResponseBytesRate { get; set; }
        [JsonPropertyName("totalpktsrecvd")]public string TotalPacketsReceived { get; set; }
        [JsonPropertyName("pktsrecvdrate")]public double? PacketsReceivedRate { get; set; }
        [JsonPropertyName("totalpktssent")]public string TotalPacketsSent { get; set; }
        [JsonPropertyName("pktssentrate")]public double? PacketsSentRate { get; set; }
        [JsonPropertyName("curclntconnections")]public string CurrentClientConnections { get; set; }
        [JsonPropertyName("cursrvrconnections")]public string CurrentServerConnections { get; set; }
        [JsonPropertyName("curpersistencesessions")]public string CurrentPersistenceSessions { get; set; }
        public string SurgeCount { get; set; }
        [JsonPropertyName("svcsurgecount")]public string ServicesSurgeCount { get; set; }
        [JsonPropertyName("sothreshold")]public string SpillOverThreshold { get; set; }
        [JsonPropertyName("totspillovers")]public string TotalSpillOvers { get; set; }
        [JsonPropertyName("labelledconn")]public string LabelledConnections { get; set; }
        [JsonPropertyName("pushlabel")]public string PushLabels { get; set; }
        [JsonPropertyName("deferredreq")]public string DeferredRequests { get; set; }
        [JsonPropertyName("deferredreqrate")]public double? DeferredRequestRate { get; set; }
        public string InvalidRequestResponse { get; set; }
        public string InvalidRequestResponseDropped { get; set; }
        [JsonPropertyName("totvserverdownbackuphits")]public string TotalVirtualServerDownBackupHits { get; set; }
        [JsonPropertyName("curmptcpsessions")]public string CurrentMultiPathTcpSessions { get; set; }
        [JsonPropertyName("cursubflowconn")]public string CurrentMultiPathTcpSubFlowConnections { get; set; }
        [JsonPropertyName("totcltttlbtransactions")]public string TotalClientTimeToLastByteTransactions { get; set; }
        [JsonPropertyName("cltttlbtransactionsrate")]public double? TotalClientTimeToLastByteTransactionsRate { get; set; }
        [JsonPropertyName("toleratingttlbtransactions")]public string ToleratingTimeToLastByteTransactions { get; set; }
        [JsonPropertyName("toleratingttlbtransactionsrate")]public double? ToleratingTimeToLastByteTransactionsRate { get; set; }
        [JsonPropertyName("frustratingttlbtransactions")]public string FrustratingTimeToLastByteTransactions { get; set; }
        [JsonPropertyName("frustratingttlbtransactionsrate")]public double? FrustratingTimeToLastByteTransactionsRate { get; set; }
        [JsonPropertyName("totalconnreassemblyqueue75")]public string TotalConnectionReassemblyQueue75 { get; set; }
        [JsonPropertyName("totalconnreassemblyqueueflush")]public string TotalConnectionReassemblyQueueFlush { get; set; }
        [JsonPropertyName("totalsvrbusyerr")]public string TotalServerBusyError { get; set; }
        [JsonPropertyName("svrbusyerrrate")]public double? ServerBusyErrorRate { get; set; }
        [JsonPropertyName("httpmaxhdrszpkts")]public string HttpMaxHeaderSizePackets { get; set; }
        [JsonPropertyName("tcpmaxooopkts")]public string TcpMaxOutOfOrderPackets { get; set; }
    }
}