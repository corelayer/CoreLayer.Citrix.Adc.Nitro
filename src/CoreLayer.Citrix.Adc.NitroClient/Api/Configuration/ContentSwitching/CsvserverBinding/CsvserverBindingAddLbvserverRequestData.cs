using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding
{
    public class CsvserverBindingAddLbvserverRequestData : INitroRequestData
    {
        public string Name { get; }
        [JsonPropertyName("lbvserver")]public string LoadBalancingVirtualServer { get; set; }
        public string TargetVirtualServer { get; set; }

        public CsvserverBindingAddLbvserverRequestData(string CsvserverName)
        {
            Name = CsvserverName;
        }
    }
}