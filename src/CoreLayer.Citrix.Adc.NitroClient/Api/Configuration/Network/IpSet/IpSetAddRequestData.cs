using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Network.IpSet
{
    public class IpSetAddRequestData : INitroRequestData
    {
        public string Name { get; }
        public double? Td { get; set; }

        public IpSetAddRequestData(string ipSetName)
        {
            Name = ipSetName;
        }
    }
}