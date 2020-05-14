namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic
{
    public class ServicegroupBindingServicegroupMemberConfiguration
    {
        //todo check  documented types == actual returned types
        public string ServicegroupName { get; set; }
        public string Ip { get; set; }
        public int? Port { get; set; }
        public string NameServer { get; set; }
        public string State { get; set; }
        public double? HashId { get; set; }
        public double? ServerId { get; set; }
        public string ServerName { get; set; }
        public string CustomServerId { get; set; }
        public double? Weight { get; set; }
        public double? DbsTtl { get; set; }
        public double? SvcitmPriority { get; set; }
        public double? Delay { get; set; }
        public string StateChangeTimeSec { get; set; }
        public string SvrState { get; set; }
        public double? TicksSinceLastStateChange { get; set; }
        public string TrofsReason { get; set; }
        public string Graceful { get; set; }
    }
}