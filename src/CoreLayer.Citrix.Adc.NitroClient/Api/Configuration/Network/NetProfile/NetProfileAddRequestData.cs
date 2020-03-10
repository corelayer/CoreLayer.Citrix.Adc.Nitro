using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Network.NetProfile
{
    public class NetProfileAddRequestData : INitroRequestData
    {
        public string Name { get; }
        public double? Td { get; set; }
        public string SrcIp { get; set; }
        public string SrcIpPersistency { get; set; }
        public string OverrideLsn { get; set; }

        public NetProfileAddRequestData(string name)
        {
            Name = name;
        }
    }
}