namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Basic
{
    public class ServicegroupMemberStatistics
    {
        public string ServicegroupName { get; set; }
        public string AvgSvrTtfb { get; set; }
        public string PrimaryIpAddress { get; set; }
        public int? PrimaryPort { get; set; }
        public string ServiceType { get; set; }
        public string State { get; set; }
        public string TotalRequests { get; set; }
        public double? RequestsRate { get; set; }
        public string TotalResponses { get; set; }
        public double? ResponsesRate { get; set; }
        public string TotalRequestBytes { get; set; }
        public double? RequestBytesRate { get; set; }
        public string TotalResponseBytes { get; set; }
        public double? ResponseBytesRate { get; set; }
        public string CurClntConnections { get; set; }
        public string SurgeCount { get; set; }
        public string CurSrvrConnections { get; set; }
        public string SvrEstablishedConn { get; set; }
        public string CurReusePool { get; set; }
        public string MaxClients { get; set; }
        public string TotalConnReassemblyQueue75 { get; set; }
        public string TotalConnReassemblyQueueFlush { get; set; }
        public string TotSvrTtlbTransactions { get; set; }
        public string ToleratingTtlbTransactions { get; set; }
        public string FrustratingTtlbTransactions { get; set; }
        public string CurLoad { get; set; }
        public string HttpMaxHdrSzPkts { get; set; }
        public string TcpMaxOooPkts { get; set; }

    }
}