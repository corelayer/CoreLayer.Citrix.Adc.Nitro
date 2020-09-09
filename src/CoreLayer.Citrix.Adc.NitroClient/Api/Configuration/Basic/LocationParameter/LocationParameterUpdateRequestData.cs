using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationParameter
{
    public class LocationParameterUpdateRequestData : INitroRequestData
    {
        public string Context { get; set; }
        public string Q1Label { get; set; }//public string Qualifier1Label { get; set; }
        public string Q2Label { get; set; }//public string Qualifier2Label { get; set; }
        public string Q3Label { get; set; }//public string Qualifier3Label { get; set; }
        public string Q4Label { get; set; }//public string Qualifier4Label { get; set; }
        public string Q5Label { get; set; }//public string Qualifier5Label { get; set; }
        public string Q6Label { get; set; }//public string Qualifier6Label { get; set; }
        
    }
}