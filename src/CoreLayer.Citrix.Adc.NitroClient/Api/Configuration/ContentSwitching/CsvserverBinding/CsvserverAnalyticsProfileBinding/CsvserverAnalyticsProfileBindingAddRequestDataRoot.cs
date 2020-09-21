using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAnalyticsProfileBinding
{
    public class CsvserverAnalyticsProfileBindingAddRequestDataRoot : INitroRequestDataRoot
    {
        public CsvserverAnalyticsProfileBindingAddRequestDataRoot(dynamic data)
        {
            Csvserver_AnalyticsProfile_Binding = new dynamic[]{data};
        }

        public CsvserverAnalyticsProfileBindingAddRequestDataRoot(dynamic[] data)
        {
            Csvserver_AnalyticsProfile_Binding = data;
        }
        
        // name doesnt follow convention because it gets serialized
        public dynamic[] Csvserver_AnalyticsProfile_Binding { get; set; }
    }
}