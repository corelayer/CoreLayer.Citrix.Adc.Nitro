using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.LbvserverBinding
{
    public class LbvserverBindingAddServiceRequestData : INitroRequestData
    {
        public string Name { get; }
        public string ServiceName { get; set; }
        public double? Weight { get; set; }
        public string ServicegroupName { get; set; }

        public LbvserverBindingAddServiceRequestData(string lbvserverName)
        {
            Name = lbvserverName;
        }
    }
}