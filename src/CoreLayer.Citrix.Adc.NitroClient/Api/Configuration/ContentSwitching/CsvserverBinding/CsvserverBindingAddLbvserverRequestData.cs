using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding
{
    public class CsvserverBindingAddLbvserverRequestData : INitroRequestData
    {
        public string Name { get; }
        public string LbvServer { get; set; }
        public string TargetVserver { get; set; }

        public CsvserverBindingAddLbvserverRequestData(string CsvserverName)
        {
            Name = CsvserverName;
        }
    }
}