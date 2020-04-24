namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.LoadBalancing
{
    public class LbvserverServiceBindingConfiguration
    {
        public string ServiceName { get; set; }
        public string ServicegroupName { get; set; }
        public string Name { get; set; }
        public string Weight { get; set; }
        public string CookieIpPort { get; set; }
        public int Port { get; set; }
        public int VsvrBindSvcPort { get; set; }
        public string CurState { get; set; }
        public string PreferredLocation { get; set; }
        public string VserverIp { get; set; }
        public string IpV46 { get; set; }
        public string DynamicWeight { get; set; }
        public string VsvrBindSvcIp { get; set; }
        public string ServiceType { get; set; }
    }
}