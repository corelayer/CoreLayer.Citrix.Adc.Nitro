namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic
{
    public class ServicegroupBindingsConfiguration
    {
        public string ServicegroupName { get; set; }
        public string IpAddress { get; set; }
        public int? Port { get; set; }
        public string State { get; set; }
        public string SvrState { get; set; }
        public string VserverName { get; set; }
    }
}